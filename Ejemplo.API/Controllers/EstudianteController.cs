using Ejemplo.Application.Commands;
using Ejemplo.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ejemplo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EstudianteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get-students")]
        public async Task<IActionResult> Get()
        {
            var estudiantes = await _mediator.Send(new ConsultarEstudiantesQuery());
            return Ok(estudiantes);
        }

        [HttpGet("get-student-by-id")]
        public async Task<IActionResult> GetById([FromQuery] ConsultarEstudiantePorIdQuery query)
        {
            var estudiantes = await _mediator.Send(query);
            return Ok(estudiantes);
        }

        [HttpPost("insert-student")]
        public async Task<IActionResult> Post([FromBody]InsertarEstudianteCommand command)
        {
            var estudiantes = await _mediator.Send(command);
            return Ok(estudiantes);
        }

        [HttpPut("update-student")]
        public async Task<IActionResult> Put([FromBody] ActualizarEstudianteCommand command)
        {
            var estudiantes = await _mediator.Send(command);
            return Ok(estudiantes);
        }

        [HttpDelete("delete-student")]
        public async Task<IActionResult> Delete([FromQuery] EliminarEstudianteCommand command)
        {
            var estudiantes = await _mediator.Send(command);
            return Ok(estudiantes);
        }
    }
}
