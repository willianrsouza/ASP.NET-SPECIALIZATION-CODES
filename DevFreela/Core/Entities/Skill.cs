using System;

namespace Core.Entities
{
    public class Skill
    {
        public Skill(int id, String description)
        {
            Id = id;
            Description = description;
            CreatedAt = DateTime.Now;
        }

        public int Id { get; private set; }
        public String Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
