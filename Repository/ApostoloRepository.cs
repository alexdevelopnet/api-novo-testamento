 
using api_novo_testamento.Dtos;
using api_novo_testamento.Repository.Interface;

namespace api_novo_testamento.Repository
{
    public class ApostoloRepository : IApostoloRepository
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApostoloResponse>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApostoloResponse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ApostoloResponse> Post(ApostoloRequest requet)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, ApostoloRequest request)
        {
            throw new NotImplementedException();
        }
    }
}