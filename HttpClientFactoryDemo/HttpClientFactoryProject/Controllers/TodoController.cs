using HttpClientFactoryProject.Abstractions;
using HttpClientFactoryProject.Services;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Threading.Tasks;

namespace HttpClientFactoryProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        //Injetar o servico de Todo
        private readonly ITodoService _toDoService;
        public TodoController(ITodoService toDoService)
        {
            _toDoService = toDoService;
        }

        [HttpGet("GetTodo/{id}")]
        public async Task<ActionResult> GetTodo(int id)
        {
            return Ok(await _toDoService.GetTodo(id));
        }

        [HttpGet("GetTodos")]
        public async Task<ActionResult> GetTodos()
        {
            var api = RestService
                .For<ITodoApi>("https://jsonplaceholder.typicode.com/");
            return Ok(await api.GetTodos());
        }

        [HttpGet("GetCep/{cep}")]
        public async Task<ActionResult> GetApi(string cep)
        {
            return Ok(await _toDoService.GetCep(cep));
        }

        [HttpGet("GetWhatEver")]
        public async Task<ActionResult> GetWhatever()
        {
            var api = RestService
                .For<IWhateverApi>("https://jsonplaceholder.typicode.com/");
            return Ok(await api.Get());
        }
    }
}