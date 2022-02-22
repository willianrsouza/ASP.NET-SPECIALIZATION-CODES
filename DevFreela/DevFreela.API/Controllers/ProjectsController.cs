using Application.InputModels;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {

        private readonly IProjectService _projectService;
        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
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
        public IActionResult Post([FromBody] NewProjectInputModel inputModel)
        {
            if (inputModel.Title.Length > 50)
            {
                return BadRequest();
            }

            var id = _projectService.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }


        /* api/project/{id} */
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectInputModel inputModel)
        {
            if (inputModel.Description.Length > 200)
            {
                return BadRequest();
            }

            _projectService.Update(inputModel);

            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _projectService.Delete(id);

            return Ok();
        }


        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateCommentInputModel inputModel)
        {
            _projectService.CreateComment(inputModel);

            return NoContent();
        }


        [HttpPut("{id}/start")]
        public IActionResult PutStart(int id)
        {
            _projectService.Start(id);

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