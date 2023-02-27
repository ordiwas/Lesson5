using System;
using System.Xml.Linq;

namespace Animals
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }

    class Program
    {
        class Cat : Animal
        {
            // override the abstract property
            public override string Name { get; set; }
            public string Type { get; set; }

            public string Color { get; set; }

            public string Sound { get; set; }

            public Cat()
            {
                Name = string.Empty;
                Type = string.Empty;
                Color = string.Empty;
                Sound = string.Empty;

            }
            public Cat(string name, string type, string color, string sound)
            {
                Name = name;
                Type = type;
                Color = color;
                Sound = sound;
            }
            // override the abstract method
            public override string Describe()
            {
                return "I am a " + Type + "\nMy name is " + Name + "\nI am " + Color + "\nI like to " + Sound;
            }

        }
        static void Main(string[] args)
        {
            // Create Horse object 
            Cat Whiskers = new Cat();
            Whiskers.Name = "Whiskers";
            Whiskers.Type = "Cat";
            Whiskers.Color = "White";
            Whiskers.Sound = "Meow";
            Console.WriteLine(Whiskers.whatAmI());
            Console.WriteLine(Whiskers.Describe());
            Console.Read();
        }
    }
}