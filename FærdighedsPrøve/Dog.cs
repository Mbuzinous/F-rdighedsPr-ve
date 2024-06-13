using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedsPrøve
{
    public class Dog
    {
        private int _id;
        private string _name;
        private string _race;
        private DateTime _yearOfBirth;

        public Dog()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Race { get => _race; set => _race = value; }
        public DateTime YearOfBirth { get => _yearOfBirth; set => _yearOfBirth = value; }
        public override string ToString()
        {
            return $"ID: {Id}{"".PadRight(22)}" + $"Name: {Name}"
                + $"\nRace: {Race}{"".PadRight(11)}" + $"Year Of Birth:{YearOfBirth}\n\n";
        }
    }
}
