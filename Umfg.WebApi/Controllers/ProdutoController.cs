using Microsoft.AspNetCore.Mvc;
using Umfg.Dominio.Entidades;
using Umfg.Dominio.Interfaces;

namespace Umfg.WebApi.Controllers
{
    [ApiController]
    [Route("api/v2/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoServico _servico;

        public ProdutoController(IProdutoServico servico)
        {
            _servico = servico;
        }

        [HttpGet]
        public IActionResult ObterTodos() => Ok(_servico.ObterTodos());

        [HttpPost]
        public IActionResult Gravar([FromBody] Produto produto)
        {
            try
            {
                return Ok(_servico.Gravar(produto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}