using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnacapsulationApp
{
    class Person
    {
        private string name;
        private int age;
        public void PrintValues()
        { Console.WriteLine($"Name  = {name} Age = {age}"); }

        //Constructors
        public Person() { }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //Setters and Getters Methods
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;

        }
        public void SetAge(int myAge)
        {
            age = myAge;
        }
        public int GetAge()
        {
            return age ;

        }

    }
}
