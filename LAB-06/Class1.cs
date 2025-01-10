using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06
{
    //Zadanie 1
    internal class Person
    {
        public string Name { get; set; }
        public Person Partner { get; set; }
        //Zadanie 2
        public Animal Pet { get; set; }

        //Zadanie 3
        public Apperance Apperance { get; set; }

        public Person(string name) => Name = name;
        public static void Relate(Person p1, Person p2)
        {
            p1.Partner = p2;
            p2.Partner = p1;
        }

        //Zadanie 2
        public void AdoptAPet(Animal pet)
        {
            Console.WriteLine($"{this.Name}'s pet named {pet.Name}");
        }

        //Zadanie 3
        public Person(string name, Apperance apperance)
        {
            Name = name;
            Apperance = apperance;
        }
    }
}
