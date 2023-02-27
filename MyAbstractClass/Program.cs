using System;
using System.Xml.Linq;

namespace Animals
{
    abstract class Weapons
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am a Weapon";
        }
    }

    class Program
    {
        class Sword : Weapons
        {
            // override the abstract property
            public override string Name { get; set; }
            public string Type { get; set; }

            public string Color { get; set; }

            public string Owner { get; set; }

            public Sword()
            {
                Name = string.Empty;
                Type = string.Empty;
                Color = string.Empty;
                Owner = string.Empty;

            }
            public Sword(string name, string type, string color, string owner)
            {
                Name = name;
                Type = type;
                Color = color;
                Owner = owner;
            }
            // override the abstract method
            public override string Describe()
            {
                return "I am a " + Type + "\nMy name is " + Name + "\nI am " + Color + "\nI am wielded by " + Owner;
            }

        }
        static void Main(string[] args)
        { 
            Sword Excalibur = new Sword();
            Excalibur.Name = "Excalibur";
            Excalibur.Type = "Sword";
            Excalibur.Color = "Silver";
            Excalibur.Owner = "Arthur";
            Console.WriteLine(Excalibur.whatAmI());
            Console.WriteLine(Excalibur.Describe());
            Console.Read();
        }
    }
}
