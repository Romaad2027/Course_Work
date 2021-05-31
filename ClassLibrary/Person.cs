using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public int rides { get; protected set; }

        public int Age { get; protected set; }

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

        public Person()
        {

        }
        public Person(string _name)
        {
            Name = _name;
        }

        public abstract void AmountOfRides();
    }
}
