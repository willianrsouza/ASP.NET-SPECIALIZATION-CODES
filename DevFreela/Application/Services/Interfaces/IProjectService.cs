using Application.InputModels;
using Application.ViewModels;
using System.Collections.Generic;

namespace Application.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjectViewModel> GetAll(string query);
        ProjectDetailsViewModel GetById(int id);
        int Create(NewProjectInputModel inputModel);
        void Update(UpdateProjectInputModel inputModel);
        void Delete(int Id);
        void Start(int Id);
        void Finish(int Id);
    }
}
