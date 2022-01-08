using Core.Entities;
using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {

        public DevFreelaDbContext()
        {
            Projects = new List<Project>()
            {
                new Project("Projeto: 1 .NET Core", "Descrição: 1", 1, 2, 10000),
                new Project("Projeto: 2 .NET Core", "Descrição: 2", 1, 2, 20000),
                new Project("Projeto: 3 .NET Core", "Descrição: 3", 1, 2, 30000)
            };

            Users = new List<User>()
            {
                new User("Willian", "Willian@gmail.com", new DateTime(2000,29, 8)),
                new User("Felipe", "Felipe@gmail.com", new DateTime(1990,26, 8)),
                new User("Leonardo", "Leonardo@gmail.com", new DateTime(1998,25, 8)),
            };

            Skills = new List<Skill>()
            {
                new Skill(".NET"),
                new Skill("C#"),
                new Skill("SQL"),
            };
        }


        public List<Project> Projects { get; set; }

        public List<User> Users { get; set; }

        public List<Skill> Skills { get; set; }

        public List<ProjectComment> ProjectComments { get; set; }
    }
}
