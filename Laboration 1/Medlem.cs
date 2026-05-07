using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Linq;


namespace Laboration_1
{
    public class Medlem
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; }

        public Medlem(int age, string name, string email)
        {
            Name = name;
            Email = email;
            Age = age;
            IsActive = true;
            CreatedDate = DateTime.Now;
        }

        public void Deactivate()
        {
            IsActive = false;
        }

        public override string ToString()
        {
            return $"{Name} ({(IsActive ? "Active" : "Inactive")})";
        }
    }
}

