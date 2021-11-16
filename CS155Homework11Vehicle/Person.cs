using System;
using System.Collections.Generic;
using System.Text;

namespace CS155Homework11Vehicle
{
    public class Person
    {
        private String name;
        public Person() { }
        public Person(string theName) { name = theName; }
        public Person(Person obj) 
        {
            this.name = obj.name;
        }
        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }
        public override string ToString() { return "Person is: " + name; }
        public override bool Equals(Object obj) { return (this.name.Equals(((Person)obj).name)); }
    }
}
