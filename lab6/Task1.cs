using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Task1
    {
        public static void Run()
        {
            Human builder = new Builder("John", "Peterson", 23, 3);
            Human sailor = new Sailor("Ben", "Wick", 43, 25);
            Human pilot = new Pilot("Andrew", "Amber", 67, 249);
            List<Human> list = new List<Human> { builder, sailor, pilot };
            foreach(Human person in list)
            {
                person.ShowInfo();
            }
        }
    }

    class Human
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int age { get; set; }

        public Human()
        {
            this.first_name = "None";
            this.last_name = "None";
            this.age = 0;
        }

        public Human(string first_name, string last_name, int age)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
        }

        public virtual void ShowInfo()
        {
            //Show pesron's information
            Console.WriteLine($"Person's initials: {this.first_name} {this.last_name}");
            Console.WriteLine($"Person's age: {this.age}");
        }
    }

    class Builder : Human
    {
        public int number_of_projects_held;
        public Builder()
        {
            this.first_name = "None";
            this.last_name = "None";
            this.age = 0;
            this.number_of_projects_held = 0;
        }

        public Builder(string first_name, string last_name, int age, int projects_num)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
            this.number_of_projects_held = projects_num;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Person's ocupation: builder");
            Console.WriteLine($"Number of projects held: {this.number_of_projects_held}");
        }
    }

    class Sailor : Human
    {
        public int number_of_visited_ships;
        public Sailor()
        {
            this.first_name = "None";
            this.last_name = "None";
            this.age = 0;
            this.number_of_visited_ships = 0;
        }

        public Sailor(string first_name, string last_name, int age, int ships_num)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
            this.number_of_visited_ships = ships_num;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Person's ocupation: sailor");
            Console.WriteLine($"Number of ships visited: {this.number_of_visited_ships}");
        }
    }

    class Pilot : Human
    {
        public int number_of_races;
        public Pilot()
        {
            this.first_name = "None";
            this.last_name = "None";
            this.age = 0;
            this.number_of_races = 0;
        }

        public Pilot(string first_name, string last_name, int age, int races_num)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
            this.number_of_races = races_num;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Person's ocupation: pilot");
            Console.WriteLine($"Number of finished races: {this.number_of_races}");
        }
    }
}