using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(int id, string title, DateTime createdAt)
        {
            this.id = id;
            Title = title;
            CreatedAt = createdAt;
        }

        public int id { get; private set; }
        public string Title { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
