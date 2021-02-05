using System;

namespace ConsoleApp12
{
    class Sam
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public Sam(int id, string name, string surname, int age, string position, int experience)
        {
            this.ID = id;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Position = position;
            this.Experience = experience;
        }
        public void ShowInf()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Experience: {Experience}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ID = ");
            var ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name = ");
            string Name = Convert.ToString(Console.ReadLine());
            Console.Write("Surname = ");
            string Surname = Convert.ToString(Console.ReadLine());
            Console.Write("Age = ");
            var Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Position = ");
            string Position = Convert.ToString(Console.ReadLine());
            Console.Write("Experience = ");
            var Experience = Convert.ToInt32(Console.ReadLine());
            Sam sam = new Sam(ID, Name, Surname, Age, Position, Experience);
            sam.ShowInf();
        }
    }
}