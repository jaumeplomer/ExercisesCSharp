using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> gent = StringGent();

            foreach (string persona in gent)
            {
                Console.WriteLine($"Hola {persona}");
            }

            Console.ReadLine();

            List<PersonModel> gentObjecte = ObjecteGent();

            foreach (PersonModel persona in gentObjecte)
            {
                Console.WriteLine($"Hola {persona.FirstName} {persona.LastName}");
            }

            Console.ReadLine();
        }
        private static List<PersonModel> ObjecteGent()
        {
            List<PersonModel> treu = new List<PersonModel>();

            treu.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            treu.Add(new PersonModel { FirstName = "Bill", LastName = "McCoy" });
            treu.Add(new PersonModel { FirstName = "Mary", LastName = "Jones" });
            treu.Add(new PersonModel { FirstName = "Sue", LastName = "Smith" });

            return treu;
        }
        private static List<String> StringGent()
        {
            List<String> treu = new List<string>();
            
            treu.Add("John");
            treu.Add("Mary");
            treu.Add("Sue");
            treu.Add("Greg");
            treu.Add("Yolanda");
            treu.Add("Jose");
            treu.Add("Bill");

            return treu;
        }
    }
}
