using Microsoft.AspNetCore.Mvc;
using Umfg.Dominio.Entidades;
using Umfg.Dominio.Interfaces;

namespace Umfg.WebApi.Controllers
{
    [ApiController]
    [Route("api/v2/cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteServico _servico;

        public ClienteController(IClienteServico servico)
        {
            _servico = servico;
        }

        [HttpGet]
        public IActionResult ObterTodos() => Ok(_servico.ObterTodos());

        [HttpPost]
        public IActionResult Gravar([FromBody] Cliente cliente)
        {
            try
            {
                return Ok(_servico.Gravar(cliente));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}