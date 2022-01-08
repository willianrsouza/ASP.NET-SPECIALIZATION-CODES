using Application.InputModels;
using Application.ViewModels;

namespace Application.Services.Interfaces
{
    public interface IUserService
    {
        UserViewModel GetById(int id);

        int Create(NewUserInputModel inputModel);

        void Update(UpdateUserInputModel inputModel);
    }
}
