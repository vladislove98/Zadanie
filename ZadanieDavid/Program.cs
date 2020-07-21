using System;
using System.Reflection.Metadata;
using System.IO;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Linq;
using System.Collections.Generic;
using System.Dynamic;

namespace ZadanieDavid
{
    class Program
    {
       
        static void Main(string[] args)
        {

            Console.WriteLine("Enter PersonId");
            int id = Convert.ToInt32(Console.ReadLine());

            var person = GetPerson(id);
            var adres = GetAdres(id);

            

            Console.WriteLine(person.Name +" "+ person.Surname +" "+ adres.Country);
            

            Console.ReadLine();
        }

        public static Person GetPerson(int PersonId)
        {
            var persons = ProcessCSV("Persons.csv");
            

            foreach (Person person in persons)
            {
                if (person.PersonId == PersonId)
                    return person;
            }

            return null;

        }

        public static Adres GetAdres(int PersonID)
        {
            var adress = AdressCSV("Adress.csv");

            foreach (Adres adres in adress)
            {
                if (adres.PersonId == PersonID)
                    return adres;

            }
            return null;

        }

        private static List<Person> ProcessCSV(string path)
        {
            return File.ReadAllLines(path)
                 .Skip(1)
                 .Where(row => row.Length > 0)
                 .Select(Person.ParseRow).ToList();

        }

        private static List<Adres> AdressCSV(string path)
        {
            return File.ReadAllLines(path)
                .Skip(1)
                .Where(row => row.Length > 0)
                .Select(Adres.ParseRow).ToList();
        }


    }
}


