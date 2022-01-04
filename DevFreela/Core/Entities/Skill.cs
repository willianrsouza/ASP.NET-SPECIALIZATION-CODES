using System;

namespace Core.Entities
{
    public class Skill
    {
        public Skill(String description)
        {
            Description = description;
            CreatedAt = DateTime.Now;
        }

        public String Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
