using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Person   
    {
        public string Name { get; private set; }    // Name of the person
        public int rides { get; protected set; }    // amount of rides for the whole time

        public int Age { get; protected set; }      // Age of the person

        //public int AgePropertie
        //{
        //    get { return Age; }
        //    set
        //    {
        //        if(Age > 100 || Age < 18)
        //        {
        //            throw new ArgumentOutOfRangeException();
        //        }
        //        else
        //        {
        //            Age = value;
        //        }
        //    }
        //}

        public Person()     // default constructor
        {

        }
        public Person(string _name) // constructor with parametrs
        {
            Name = _name;
        }

        public abstract void AmountOfRides();   // abstracrt method which we will need to override
    }
}
