using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedsPrøve
{
    public class Member
    {
        private int _id;
        private string _name;
        private string _address;
        private DateTime _birthDate;
        private int _phoneNumber;
        private string _email;

        public List<Dog> MyDogs { get; private set; }

        public Member()
        {
            MyDogs = new List<Dog>();
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Address { get => _address; set => _address = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        public int PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Email { get => _email; set => _email = value; }

        public StringBuilder PrintAllMyDogs()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Dog d in MyDogs)
            {
                sb.Append($"{d.ToString()}{"".PadRight(5)}");
            }
            return sb;
        }
        public void RegisterDog(Dog dog)
        {
            MyDogs.Add(dog);
        }

        public int CalculateAge()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            return age;
        }

        public int CalculateMemberFee(int age, Dog dog)
        {
            int fee = 1000;
            if (age >= 65 || MyDogs.Count >= 2)
            {
                fee = 500;
            }
            else if (MyDogs.Count > 5)
            {
                fee = 2500;
            }
            return fee;
        }


        public override string ToString()
        {
            return $"ID: {Id}{"".PadRight(22)}" + $"Name: {Name}"
                + $"\nAddress: {Address}{"".PadRight(11)}" + $"Birth Date:{BirthDate}"
                + $"\nPhone Number: {PhoneNumber}{"".PadRight(5)}" + $"Email: {Email}"
                + $"\nMy Dog: {PrintAllMyDogs()}\n\n";
        }
    }
}
