using Application.InputModels;
using Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Application.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjectViewModel> GetAll(string query);
        ProjectDetailsViewModel GetById(int id);
        String Status(int id);
    }
}
