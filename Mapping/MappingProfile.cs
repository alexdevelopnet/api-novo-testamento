 
using api_novo_testamento.Dtos;
using ApiNovoTestamento.Models;
using AutoMapper;

namespace api_novo_testamento.Mapping
{
    public class MappingProfle : Profile
    {
        public MappingProfle()
        {
            CreateMap<Apostolo, ApostoloResponse>();
            CreateMap<ApostoloRequest, Apostolo>();
        }
    }
}