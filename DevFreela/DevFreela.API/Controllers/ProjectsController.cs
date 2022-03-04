using Application.Commands.CreateComment;
using Application.Commands.CreateProject;
using Application.Commands.Projects.Delete;
using Application.Commands.Projects.StartProject;
using Application.Commands.Projects.Update;
using Application.InputModels;
using Application.Services.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Threading.Tasks;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {

        private readonly IProjectService _projectService;
        private readonly IMediator _mediator;

        public ProjectsController(IProjectService projectService, IMediator mediator)
        {
            _projectService = projectService;
            _mediator = mediator;
        }


        /* api/project?query= */
        [HttpGet]
        public IActionResult Get(string query)
        {

            var projects = _projectService.GetAll(query);

            return Ok(projects);
        }


        /* api/project/{id} */
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var project = _projectService.GetById(id);

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProjectCommand command)
        {
            if (command.Title.Length > 50)
            {
                return BadRequest();
            }

            // var id = _projectService.Create(inputModel);

            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }


        /* api/project/{id} */
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateProjectCommand command)
        {
            if (command.Description.Length > 200)
            {
                return BadRequest();
            }

            await _mediator.Send(command);

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteProjectCommand(id);

            await _mediator.Send(command);

            return NoContent();
        }


        [HttpPost("{id}/comments")]

        public async Task<IActionResult> PostComment(int id, [FromBody] CreateCommentCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }


        [HttpPut("{id}/start")]
        public async Task<IActionResult> PutStart(int id, [FromBody] StartProjectCommand command)
        {

            await _mediator.Send(command);

            return NoContent();
        }


        [HttpPut("{id}/finish")]
        public IActionResult PutFinish(int id)
        {
            _projectService.Finish(id);

            return NoContent();
        }


        [HttpGet("{id}/status-project")]
        public IActionResult GetStatusProject(int id)
        {
            _projectService.Status(id);

            return Ok();
        }
    }
}