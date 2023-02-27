using System;
namespace Employees
{
    interface IEmployee
    {
        //Properties
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

        //Methods
        string Fullname();
        double Pay();

    }
    class Program
    {
        class Employee : IEmployee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Employee()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
            }
            public Employee(int id, string firstName, string lastName)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
            }
            public string Fullname()
            {
                return FirstName + " " + LastName;
            }
            public virtual double Pay()
            {
                double salary;
                Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
                salary = double.Parse(Console.ReadLine());
                return salary;
            }

        }
        sealed class Executive
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Executive()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
            }
            public Executive(int id, string firstName, string lastName)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
            }
            public string Fullname()
            {
                return FirstName + " " + LastName;
            }
            public double ExecutivePay(double pay)
            {
                //Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
                //pay = double.Parse(Console.ReadLine());
                
                //Console.WriteLine(pay);
                return pay;
            }

            class Worker : Employee
            {
                public double Rate { get; set; }
                public int Hours { get; set; }

                public Worker() : base()
                {
                    Rate = 0;
                    Hours = 0;
                }
                public Worker(int id, string firstName, string lastName, double rate, int hours)
                    : base(id, firstName, lastName)
                {
                    Rate = rate;
                    Hours = hours;
                }

                sealed public override double Pay()
                {
                    if (Hours > 40)
                        return 40 * Rate + (1.5 * ((Hours - 40) * Rate));
                    else
                        return Rate * Hours;
                }
            }

            static void Main(string[] args)
            {
                
                //Employee george = new Employee(5, "George", "Jetson");
                //george.Pay();

              
                Worker fred = new Worker(10, "Fred", "Flintstone", 50, 60);
                Console.WriteLine(fred.Fullname());
                Console.WriteLine(fred.Pay());

               
                Worker barney = new Worker();
                barney.Id = 20;
                barney.FirstName = "Barney";
                barney.LastName = "Rubble";
                barney.Rate = 40;
                barney.Hours = 75;
                Console.WriteLine(barney.Fullname());
                Console.WriteLine(barney.Pay());
                Console.ReadLine();

                Console.WriteLine("Executives");
                Console.WriteLine("_____________");
                Executive bill =  new Executive();
                bill.Id= 30;
                bill.FirstName = "Billy";
                bill.LastName = "Bob";
                Console.WriteLine(bill.Fullname());
                Console.WriteLine(bill.ExecutivePay(3000));
                Console.Read();
            }
        }
    }
}
