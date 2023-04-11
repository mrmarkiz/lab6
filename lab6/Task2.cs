using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Task2
    {
        public static void Run()
        {
            ForeignPassport pass1 = new ForeignPassport("Ukraine", "Ivan Petrenko", "0120012285", "20320232167", new string[] { "Poland", "Germany" });
            ForeignPassport pass2 = new ForeignPassport("United Kingdom", "James Brown", "932405822", "3049347623", new string[] { "French", "Iceland" });
            List<Passport> list = new List<Passport> { pass1, pass2 };
            foreach (Passport passport in list)
                passport.ShowInfo();
        }
    }

    class Passport
    {
        public string register_country { get; set; }
        public string initials { get; set; }
        public string passport_code { get; set; }

        public Passport()
        {
            this.register_country = "None";
            this.initials = "None";
            this.passport_code = "None";
        }

        public Passport(string country, string initials, string code)
        {
            this.register_country = country;
            this.initials = initials;
            this.passport_code = code;
        }

        public virtual void ShowInfo()
        {
            //show passport information
            Console.WriteLine($"Passport's registration country: {this.register_country}");
            Console.WriteLine($"Passport's initials: {this.initials}");
            Console.WriteLine($"Passport's code: {this.passport_code}");
        }
    }

    class ForeignPassport: Passport
    {
        public string foreign_passport_code { get; set; }
        public string[] visa_countries { get; set; }

        public ForeignPassport() : base()
        {
            this.foreign_passport_code = "None";
            this.visa_countries = new string[0];
        }

        public ForeignPassport(string country, string initials, string code, string foreign_code, string[] visas) : base(country, initials, code)
        {
            this.foreign_passport_code = foreign_code;
            this.visa_countries = new string[visas.Length];
            for (int i = 0; i < this.visa_countries.Length; i++)
                this.visa_countries[i] = visas[i];
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Foreign passport's code: {this.foreign_passport_code}");
            Console.WriteLine("List of countries has visa to:");
            foreach (string visa in this.visa_countries)
                Console.WriteLine(visa);
            Console.WriteLine();
        }
    }
}
