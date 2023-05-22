using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    public class Person
    {
        //Field
        public int money;

        //Default Constructor
        public Person()
        {

        }

        //Custom Constructor
        public Person(string name, int age, bool isMarried, string hairColor)
        {
            Name = name;
            Age = age;
            IsMarried = isMarried;
            HairColor = hairColor;            
        }

        //Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }
        public string HairColor { get; set; }
        

        //Method in class (non static)
        public void Greet()
        {
            Console.WriteLine($"Hello! My name is {Name} and I am {Age} years old.");
        }
    }
}
