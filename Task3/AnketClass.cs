using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class AnketObject
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Birthday { get; set; }
        public Guid Id { get; set; }
        public AnketObject()
        {

        }

        public AnketObject(string name, string surname,string email,string phone, string birthday)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

