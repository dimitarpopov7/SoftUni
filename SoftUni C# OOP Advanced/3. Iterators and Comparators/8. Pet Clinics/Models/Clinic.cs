namespace _8.Pet_Clinics
{
    using System;
    using System.Collections.Generic;

    public class Clinic
    {
        private string name;
        private int roomNumber;
        public Pet[] AccomodatedPets;
        public readonly int roomIndex;

        public Clinic(string name, int roomNumber)
        {
            this.Name = name;
            this.RoomNumber = roomNumber;
            this.AccomodatedPets = new Pet[RoomNumber];
            this.roomIndex = RoomNumber / 2+1;
        }

        public int RoomNumber
        {
            get { return this.roomNumber; }
            set
            {
                if (value % 2 == 0||value<0||value>101)
                {
                    throw new ArgumentException("Invalid Operation!");
                }
                this.roomNumber = value;
            }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
