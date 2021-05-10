using HttpClientFactoryProject.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Threading.Tasks;

namespace HttpClientFactoryProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CepController : Controller
    {
        [HttpGet("GetCep{cep}")]
        public async Task<ActionResult> GetCepId(string cep)
        {
            var api = RestService
                .For<ICepApi>("https://viacep.com.br/");
            return Ok(await api.GetCep(cep));
        }
    }
}
