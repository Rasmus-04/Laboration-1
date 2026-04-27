using System;
using System.Collections.Generic;
using System.Text;

namespace Laboration_1
{
    public class Medlem
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; }

        public Medlem(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
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
