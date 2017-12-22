using System.Collections.Generic;

namespace _6.Raw_Data
{
    public class Car
    {
        private string model;
        private Engine engine;
        private List<Tyre> tyres;
        private Cargo cargo;
        public Car(string model, Engine engine, List<Tyre> tyres, Cargo cargo)
        {
            this.model = model;
            this.engine = engine;
            this.tyres = tyres;
            this.cargo = cargo;
        }
        public string Model
        {
            get { return this.model; }
        }
        public Cargo Cargo
        {
            get { return this.cargo; }
        }
        public Engine Engine
        {
            get { return this.engine; }
        }
        public List<Tyre> Tyres
        {             
            get { return this.tyres; }
        }
    }
}
