using Application.ViewModels;
using System.Collections.Generic;

namespace Application.Services.Interfaces
{
    public interface ISkillService
    {
        List<SkillViewModel> GetAll();


    }
}
