using System;
namespace Employees
{
    interface IClub
    {
        //Properties
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

        //Methods
        string Fullname();
    }
    class Program
    {
        class Worker : IClub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Rate { get; set; }
            public int Hours { get; set; }

            public Worker()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
                Rate = 0;
                Hours = 0;
            }
            public Worker(int id, string firstName, string lastName, double rate, int hours)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Rate = rate;
                Hours = hours;
            }

            public string Fullname()
            {
                return FirstName + " " + LastName;
            }
            public double Pay()
            {
                if (Hours > 40)
                    return 40 * Rate + (1.5 * ((Hours - 40) * Rate));
                else
                    return Rate * Hours;
            }
        }
        static void Main(string[] args)
        {
            // Worker object created using parameterized constructor
            Worker fred = new Worker(10, "Fred", "Flintstone", 50, 60);
            Console.WriteLine(fred.Fullname());
            Console.WriteLine(fred.Pay());

            //Worker object created using the default constructor
            //values are assigned using properties
            Worker barney = new Worker();
            barney.Id = 20;
            barney.FirstName = "Barney";
            barney.LastName = "Rubble";
            barney.Rate = 40;
            barney.Hours = 75;
            Console.WriteLine(barney.Fullname());
            Console.WriteLine(barney.Pay());
            Console.ReadLine();

        }
    }
}