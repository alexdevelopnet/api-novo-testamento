
using api_novo_testamento.Dtos;
using api_novo_testamento.Interfaces;
using api_novo_testamento.Repository.Interface;
using ApiNovoTestamento.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;

namespace api_novo_testamento.Services
{
    public class ApostoloService : IApostoloService
    {
        private readonly IRepository<Apostolo> _repository;
        private readonly IMapper _mapper;
        public ApostoloService(IRepository<Apostolo> repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<ApostoloResponse>> GetAll()
        {
            var apostolos = await _repository.GetAll();
            return _mapper.Map<IEnumerable<ApostoloResponse>>(apostolos);
        }
        public async Task<ApostoloResponse> GetById(int id)
        {
            var apostolo = await _repository.GetById(id);
            return _mapper.Map<ApostoloResponse>(apostolo);
        }

        public async Task Add(ApostoloRequest requet)
        {
            var apostolo = _mapper.Map<Apostolo>(requet);
            await _repository.Add(apostolo);
        }

        public async Task Update(int id, ApostoloRequest request)
        {
            var apostolo = await _repository.GetById(id);
            await _repository.Update(apostolo);
            if (apostolo == null)
            {
                //lançar uma exception   
                return;
            }
            _mapper.Map(request, apostolo);
        }
        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }

    }
}