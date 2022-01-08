using Application.InputModels;
using Application.Services.Interfaces;
using Application.ViewModels;
using Core.Entities;
using Infrastructure.Persistence;
using System.Linq;

namespace Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private DevFreelaDbContext _devFreelaDbContext;

        public UserService(DevFreelaDbContext devFreelaDbContext)
        {
            _devFreelaDbContext = devFreelaDbContext;
        }

        public int Create(NewUserInputModel inputModel)
        {
            var user = new User(inputModel.FullName, inputModel.Email, inputModel.BirthDate);
            _devFreelaDbContext.Users.Add(user);

            return user.Id;
        }

        public UserViewModel GetById(int id)
        {
            var user = _devFreelaDbContext.Users.SingleOrDefault(u => u.Id == id);

            var UserViewModel = new UserViewModel(user.FullName, user.Email, user.Active);

            return UserViewModel;
        }

        public void Update(UpdateUserInputModel inputModel)
        {
            var user = _devFreelaDbContext.Users.SingleOrDefault(u => u.Id == inputModel.Id);

            user.Update(inputModel.Email);

        }
    }
}
