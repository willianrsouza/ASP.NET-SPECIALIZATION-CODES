using MediatR;


namespace Application.Commands.Projects.FinishProject
{
    public class FinishProjectCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
