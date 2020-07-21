using System;
using System.Collections.Generic;
using System.Text;

namespace ZadanieDavid
{
    public class Person
    {
       public int PersonId { get; set; }
       public string Name { get; set; }
       public string Surname { get; set; }
       public int Age { get; set; }

       internal static Person ParseRow(string row)
        {
            var columns = row.Split(';');
            return new Person()
            {
                PersonId = int.Parse(columns[0]),
                Name = columns[1],
                Surname = columns[2],
                Age = int.Parse(columns[3]),

            };
        }


    }
}
