﻿using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        /* api/project?query= */

        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }

        /* api/project/{id} */

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreatedProjectModel createdProject)
        {
            if (createdProject.Title.Length > 50)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetById), new { id = createdProject.Id }, createdProject);
        }

        /* api/project/{id} */

        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 200)
            {
                return BadRequest();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            return Ok();
        }

    }
}