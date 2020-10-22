using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TextFilesChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\jplom\source\repos\StandardDataSet.csv";

            List<Person> people = new List<Person>();

            List<string> lines = File.ReadAllLines(filePath).ToList();
            
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Person newPerson = new Person();

                newPerson.FirstName = entries[0];
                newPerson.LastName = entries[1];
                newPerson.Age = entries[2];
                newPerson.IsAlive = entries[3];

                
                people.Add(newPerson);
            }

            foreach (var person in people)
            {
                if (person.IsAlive.StartsWith("0"))
                {
                    person.IsAlive = "dead";
                }
                else
                {
                    person.IsAlive = "alive";
                }
                Console.WriteLine($"{ person.FirstName} {person.LastName} is {person.Age} and is {person.IsAlive}");
                if (person.IsAlive.StartsWith("dead"))
                {
                    person.IsAlive = "0";
                }
                else
                {
                    person.IsAlive = "1";
                }
            }
            Console.WriteLine("Do you want to add a person? (Y/N)");
            string ans = Console.ReadLine();
            ans = ans.ToUpper();
            if (ans == "Y")
            {
                Console.WriteLine("Type the first name, last name, age and if the person is dead(0) or alive(1)");
                string name = Console.ReadLine();
                string lastname = Console.ReadLine();
                string age = Console.ReadLine();
                string dead = Console.ReadLine();

                people.Add(new Person { FirstName = name, LastName = lastname, Age = age, IsAlive = dead });

                List<string> output = new List<string>();

                foreach (var person in people)
                {
                    output.Add($"{ person.FirstName},{person.LastName},{person.Age},{person.IsAlive}");
                }

                File.WriteAllLines(filePath, output);
            }
            else
            {
                Console.WriteLine("Okay, good bye!");
            }
            Console.ReadLine();
        }
    }
}
