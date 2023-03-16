using AutoMapper;
using RgmTeste.Domain.DTOs;
using RgmTeste.Infra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RgmTeste.Domain.Mappers
{
    public class DomainToDtoMapper : Profile
    {
        public DomainToDtoMapper()
        {
            CreateMap<Produto, ProdutoDto>().ReverseMap();
        }
    }
}
