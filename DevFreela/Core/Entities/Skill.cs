using System;

namespace Core.Entities
{
    public class Skill
    {
        public Skill(int description)
        {
            Description = description;
            CreatedAt = DateTime.Now;
        }

        public int Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
