using Infrastructure.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;


namespace Application.Commands.User.Create
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {

        private readonly DevFreelaDbContext _dbContext;

        public CreateUserCommandHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {

            var user = new User(request.FullName, request.Email, request.BirthDate);

            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();

            return user.Id;
        }
    }
}
