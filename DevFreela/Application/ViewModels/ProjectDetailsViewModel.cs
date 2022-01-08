using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public ProjectDetailsViewModel(int id, string title, string description, decimal totalCoust, DateTime? startAt, DateTime? finishedAt)
        {
            Id = id;
            Title = title;
            Description = description;
            TotalCoust = totalCoust;
            StartAt = startAt;
            FinishedAt = finishedAt;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal TotalCoust { get; private set; }
        public DateTime? StartAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
    }
}
