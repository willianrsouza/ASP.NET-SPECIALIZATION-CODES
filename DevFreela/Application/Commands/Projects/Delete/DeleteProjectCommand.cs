
using MediatR;

namespace Application.Commands.Projects.Delete
{
    public class DeleteProjectCommand : IRequest<Unit>
    {
        public DeleteProjectCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
