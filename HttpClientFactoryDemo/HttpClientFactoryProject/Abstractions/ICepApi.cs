using HttpClientFactoryProject.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HttpClientFactoryProject.Abstractions
{
    public interface ICepApi
    {
        [Get("/ws/{cep}/json")]
        Task<IEnumerable<CepModel>> GetCep(string cep);
    }
}
