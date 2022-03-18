using Microsoft.AspNetCore.Mvc;
using TesteAPI.Model;
using TesteAPI.Validacoes.Interfaces;

namespace TesteAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SenhaController : ControllerBase
    {
        private IValidarSenha validarSenha;
        
        public SenhaController(IValidarSenha validarSenha)
        {
            this.validarSenha = validarSenha;            
        }

        [HttpPost()]
        public IActionResult Post([FromBody] Senha senha)
        {           
            if (senha == null) return BadRequest();
            return Content(this.validarSenha.ChamarMetodosValidacao(senha));
        }
        
    }
}
