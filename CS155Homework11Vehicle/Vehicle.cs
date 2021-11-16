using System;
using System.Collections.Generic;
using System.Text;

namespace CS155Homework11Vehicle
{
    public class Vehicle
    {
        //Manufracturer name(enum), number of Cyclinders in the engine(int), and the owner(Person, see below).
        private enum manufacturer_name
        {
            Ford,
            GM,
            Tesla,
            BMW
        }

        private int numCylinders;
        private Person owner;
        private string manufacturer;
        public Vehicle() { }
        public Vehicle(int mfgr, int numCyl, Person own)
        {
            SetManufacturer(mfgr);
            numCylinders = numCyl;
            owner = own;
        }

        public string GetManufacturer(int mfgr)
        {
            switch (mfgr)
            {
                case (int)manufacturer_name.Ford:
                    return "Ford";

                case (int)manufacturer_name.GM:
                    return "GM";

                case (int)manufacturer_name.Tesla:
                    return "Tesla";

                case (int)manufacturer_name.BMW:
                    return "BMW";

                default:
                    return "Unknown";
            }
        }

        public void SetManufacturer(int mfgr)
        {
            switch (mfgr)
            {
                case (int)manufacturer_name.Ford:
                    manufacturer = "Ford";
                    break;

                case (int)manufacturer_name.GM:
                    manufacturer = "GM";
                    break;

                case (int)manufacturer_name.Tesla:
                    manufacturer = "Tesla";
                    break;

                case (int)manufacturer_name.BMW:
                    manufacturer = "BMW";
                    break;

                default:
                    manufacturer = "Unknown";
                    break;
            }
        
        
        
        }

        public int NumCylinders { get => numCylinders; set => numCylinders = value; }
        public Person getPerson()
        {
            return owner;
        }
        public void setPerson(Person p)
        {
            this.owner.SetName(p.GetName());

        }
    }
}
