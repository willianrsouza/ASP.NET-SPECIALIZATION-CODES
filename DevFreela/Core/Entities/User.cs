using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, DateTime birthDate)
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            CreatedAt = DateTime.Now;
            Active = true;

            Skills = new List<UserSkill>();
            OwnedProject = new List<Project>();
            FreelanceProject = new List<Project>();
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; private set; }
        public List<UserSkill> Skills { get; private set; }
        public List<Project> OwnedProject { get; private set; }
        public List<Project> FreelanceProject { get; private set; }

        public void Update(string email)
        {
            Email = email;
        }
    }
}
