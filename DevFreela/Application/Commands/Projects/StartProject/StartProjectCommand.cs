using MediatR;

namespace Application.Commands.Projects.StartProject
{
    public class StartProjectCommand : IRequest<Unit>
    {

        public int Id { get; set; }

    }
}
