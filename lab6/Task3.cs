using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Task3
    {
        public static void Run()
        {
            Animal tiger = new Tiger(20, 200), crocodile = new Crocodile(15, 250), kangaroo = new Kangaroo(10, 150);
            List<Animal> animal_list = new List<Animal> { tiger, crocodile, kangaroo };
            foreach (Animal animal in animal_list)
                animal.ShowInfo();
        }
    }

    class Animal
    {
        public int max_age { get; set; }
        public int max_weight { get; set; }

        public Animal()
        {
            this.max_age = 0;
            this.max_weight = 0;
        }

        public Animal(int max_age, int max_weight)
        {
            this.max_age = max_age;
            this.max_weight = max_weight;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Max age: {this.max_age}");
            Console.WriteLine($"Max weight(kg): {this.max_weight}");
        }

        public virtual string Move()
        {
            //move type
            return "";
        }
    }

    class Tiger : Animal
    {
        public Tiger() : base() { }
        public Tiger(int max_age, int max_weight) : base(max_age, max_weight) { }

        public override string Move()
        {
            return ("'Swimms'");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Its tiger");
            base.ShowInfo();
            Console.WriteLine($"Moving type: {this.Move()}");
        }
    }

    class Crocodile : Animal
    {
        public Crocodile() : base() { }
        public Crocodile(int max_age, int max_weight) : base(max_age, max_weight) { }

        public override string Move()
        {
            return ("'Sneaks'");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Its crocodile");
            base.ShowInfo();
            Console.WriteLine($"Moving type: {this.Move()}");
        }
    }

    class Kangaroo : Animal
    {
        public Kangaroo() : base() { }
        public Kangaroo(int max_age, int max_weight) : base(max_age, max_weight) { }

        public override string Move()
        {
            return ("'Jumps'");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Its kangaroo");
            base.ShowInfo();
            Console.WriteLine($"Moving type: {this.Move()}");
        }
    }
}