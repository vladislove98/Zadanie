using System;
using System.Collections.Generic;
using System.Text;

namespace ZadanieDavid
{
    class Adres
    {
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Number { get; set; }
        public int PersonId { get; set; }

        internal static Adres ParseRow(string row)
        {
            var columns = row.Split(';');
            return new Adres()
            {
                AddressId = int.Parse(columns[0]),
                Country = columns[1],
                City = columns[2],
                Number = int.Parse(columns[3]),
                PersonId = int.Parse(columns[4]),

            };
        }

    }
}
