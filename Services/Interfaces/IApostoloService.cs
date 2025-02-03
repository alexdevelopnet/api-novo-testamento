
using api_novo_testamento.Dtos;

namespace api_novo_testamento.Interfaces
{
    public interface IApostoloService
    {
        Task<IEnumerable<ApostoloResponse>> GetAll();
        Task<ApostoloResponse> GetById(int id);
        Task Add(ApostoloRequest apostoloRequest);
        Task Update(int id, ApostoloRequest apostoloRequest);
        Task Delete(int id);
    }
}