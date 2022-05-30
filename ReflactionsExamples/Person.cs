using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflactionsExamples
{
    public class Person : IEat, IDrink
    {
        public string Name { get; }
        private int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine("Person Eat");
        }

        public void Drink()
        {
            Console.WriteLine("Person Drink");
        }
        //public Person(string name, int age) => Name = name;

        public void Print ()
        {
            Console.WriteLine("Print Person");
        }
    }
}
