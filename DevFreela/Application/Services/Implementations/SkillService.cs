using Application.Services.Interfaces;
using Application.ViewModels;
using Infrastructure.Persistence;
using System.Collections.Generic;
using System.Linq;


namespace Application.Services.Implementations
{
    public class SkillService : ISkillService
    {

        private readonly DevFreelaDbContext _dbContext;

        public SkillService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<SkillViewModel> GetAll()
        {
            var skills = _dbContext.Skills;

            var skillsViewModel = skills
                .Select(s => new SkillViewModel(s.Id, s.Description))
                .ToList();

            return skillsViewModel;
        }
    }
}
