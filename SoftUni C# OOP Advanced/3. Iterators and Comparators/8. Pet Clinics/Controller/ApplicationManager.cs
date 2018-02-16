namespace _8.Pet_Clinics
{
    using System.Collections.Generic;
    using System.Linq;
    using System;
    public class ApplicationManager
    {
        public List<Pet> petList = new List<Pet>();
        public List<Clinic> clinicList = new List<Clinic>();

        public void CreatePet(string name, int age, string kind)
        {
            var currentPet = new Pet(name, age, kind);
            petList.Add(currentPet);

        }
        public void CreateClinic(string name, int roomNumber)
        {
            var clinic = new Clinic(name, roomNumber);
            clinicList.Add(clinic);
        }
        public bool AddPet(string petName,string clinicName)
        {
            var petToAdd = petList.FirstOrDefault(pn=>pn.Name==petName);
            var clinic = clinicList.FirstOrDefault(cn => cn.Name == clinicName);
            clinicList.Remove(clinic);
            if (petToAdd != null&&clinic!=null)
            {
                for (int i = 0; i < clinic.roomIndex; i++)
                {
                    if (clinic.AccomodatedPets[clinic.roomIndex - i-1] == null)
                    {
                        clinic.AccomodatedPets[clinic.roomIndex - i-1] = petToAdd;
                        clinicList.Add(clinic);    
                        return true;
                    }
                    if (clinic.AccomodatedPets[clinic.roomIndex + i-1] == null)
                    {
                        clinic.AccomodatedPets[clinic.roomIndex + i-1] = petToAdd;
                        clinicList.Add(clinic);
                        return true;
                    }
                }
            }
            clinicList.Add(clinic);
            return false;

        }
        public bool ReleasePet(string clinicName)
        {
            var clinic = clinicList.FirstOrDefault(cn => cn.Name == clinicName);
            clinicList.Remove(clinic);
            for (int i = 0; i < clinic.roomIndex; i++)
            {
                if (clinic.AccomodatedPets[clinic.roomIndex+i-1] != null)
                {
                    clinic.AccomodatedPets[clinic.roomIndex+i-1] = null;
                    clinicList.Add(clinic);
                    return true;
                }
            }
            for (int i = 0; i < clinic.roomIndex; i++)
            {
                if (clinic.AccomodatedPets[i] != null)
                {
                    clinic.AccomodatedPets[i] = null;
                    clinicList.Add(clinic);
                    return true;
                }
            }
            clinicList.Add(clinic);
            return false;
        }
        public bool HasEmptyRoom(string clinicName) => clinicList.FirstOrDefault(cn=>cn.Name==clinicName).AccomodatedPets.Any(room => room == null);

        public void Print(string clinicName,int room)
        {
            var petToPrint = clinicList.FirstOrDefault(cn => cn.Name == clinicName).AccomodatedPets[room - 1];
            if (petToPrint != null)
            {
                Console.WriteLine(petToPrint);
            }
        }
        public void Print(string clinicName)
        {
            var clinic = clinicList.FirstOrDefault(cn => cn.Name == clinicName);
            foreach (var item in clinic.AccomodatedPets)
            {
                if (item == null)
                {
                    Console.WriteLine("Room empty");
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
