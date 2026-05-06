using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Linq;


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

    public class MedlemService
    {
        private List<Medlem> medlemmar = new List<Medlem>();

        public void AddMedlem(int id, string name, string email)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty");

            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email cannot be empty");

            medlemmar.Add(new Medlem(id, name, email));
        }

        public List<Medlem> GetAll()
        {
            return medlemmar;
        }

        public List<Medlem> GetActiveMembers()
        {
            return medlemmar.Where(m => m.IsActive).ToList();
        }

        public List<Medlem> GetSortedByName()
        {
            return medlemmar.OrderBy(m => m.Name).ToList();
        }

        public void DeactivateMember(int id)
        {
            var medlem = medlemmar.FirstOrDefault(m => m.Id == id);

            if (medlem == null)
                throw new Exception("Medlem finns inte");

            medlem.Deactivate();
        }

        public Medlem GetById(int id)
        {
            var medlem = medlemmar.FirstOrDefault(m => m.Id == id);

            if (medlem == null)
                throw new Exception("Medlem finns inte");

            return medlem;
        }
    }
}

