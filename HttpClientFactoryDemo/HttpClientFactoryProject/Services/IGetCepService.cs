using HttpClientFactoryProject.Models;
using System.Threading.Tasks;

namespace HttpClientFactoryProject.Services
{
    public interface IGetCepService
    {
        Task<CepModel> GetCep(int id);

    }
}
