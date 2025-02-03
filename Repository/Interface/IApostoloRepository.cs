
using api_novo_testamento.Dtos;

namespace api_novo_testamento.Repository.Interface
{
    public interface IApostoloRepository
    {
        Task<IEnumerable<ApostoloResponse>> GetAll();
        Task<IEnumerable<ApostoloResponse>> Get(int id);
        Task<ApostoloResponse> Post(ApostoloRequest requet);
        Task Update(int id, ApostoloRequest request);
        Task Delete(int id);
    }
}