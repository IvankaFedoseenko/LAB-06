namespace LAB_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            Person Alice = new Person("Alice");
            Person Bob = new Person("Bob");

            Person.Relate(Alice, Bob);

            //Zadanie 2
            Animal dog = new Animal("Ben", "dog");
            Alice.AdoptAPet(dog);

            //Zadanie 3
            Apperance apperance = new Apperance("blue", "blond", "has no freckles");
            Person person = new Person("Kate", apperance);


        }
    }
}
