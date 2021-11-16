using System;
using System.Collections.Generic;
using System.Text;

namespace CS155Homework11Vehicle
{
    public class Truck : Vehicle
    {
        //classs called Truck that is derived from Vehicle and has the additional following properties: the load capacity in tons(double), and towing capacity in pounds(int).
        private double loadcapacity_in_tons;
        private int towingcapacity_in_lbs;

        //constructors
        public Truck() { }

        public Truck(double loadcapacity, int towingcapacity)
        {
            loadcapacity_in_tons = loadcapacity;
            towingcapacity_in_lbs = towingcapacity;
        }

        public Truck(int mfr, int numCyl, Person ownr, double loadcapacity, int towingcapacity) : base (mfr, numCyl, ownr)
        {
            loadcapacity_in_tons = loadcapacity;
            towingcapacity_in_lbs = towingcapacity;
        }

        public double LoadCapacity { get => loadcapacity_in_tons; set => loadcapacity_in_tons = value; }
        public int TowingCapacity { get => towingcapacity_in_lbs; set => towingcapacity_in_lbs = value; }

        public override string ToString()
        {
            return "Truck with a load capacity of: " + loadcapacity_in_tons + " tons and Tow capacity of: " + towingcapacity_in_lbs + " lbs";
        }
    }
}