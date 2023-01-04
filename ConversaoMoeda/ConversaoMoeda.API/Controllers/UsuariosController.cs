using ConversaoMoeda.API.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConversaoMoeda.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UsuariosController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpPost("{idUsuario}/conversao")]
        public async Task<IActionResult> Post(int idUsuario, [FromBody] ConversaoMoedaDto dto)
        {
            try
            {
                // Gerar a taxa de conversão
                // Converter o valor para o destino
                // Registrar no banco de dados a transação
                // Devolver a resposta
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("{idUsuario}")]
        public async Task<IActionResult> Get(int idUsuario)
        {
            // Consulto o histórico de conversões no banco de dados
            // Devolvo essa lista
            return Ok();
        }
    }
}
