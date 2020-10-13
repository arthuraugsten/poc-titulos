using Microsoft.AspNetCore.Mvc;

namespace Api.Soap.Controllers
{
    [Route("api/[controller]")]
    public class RemessaController : ControllerBase
    {
        // recebe um formato do layout 4.3 e converte para a classe que a Infra espera do 4.3
        [HttpPost("/43")]
        public IActionResult Post(int t)
            => Ok();

        // recebe um formato do layout 4.4 e converte para a classe que a Infra espera do 4.4
        [HttpPost("/44")]
        public IActionResult Post(string t)
            => Ok();
    }
}