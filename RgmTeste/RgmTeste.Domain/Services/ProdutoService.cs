using AutoMapper;
using RgmTeste.Domain.DTOs;
using RgmTeste.Domain.Interfaces;
using RgmTeste.Infra.Entities;
using RgmTeste.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RgmTeste.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;
        public ProdutoService(IMapper mapper,IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }
        public async Task<List<ProdutoDto>> Get()
        {

            var list = await _produtoRepository.Get();

            return _mapper.Map<List<ProdutoDto>>(list);
        }
        public async Task<ProdutoDto> Add(ProdutoDto produto)
        {
            var NewProduto = _mapper.Map<Produto>(produto);
            var result = await _produtoRepository.Add(NewProduto);

            return _mapper.Map<ProdutoDto>(result);
        }
        public async Task<ProdutoDto> Update(ProdutoDto produto)
        {
            var updateProduto = _mapper.Map<Produto>(produto);
            var result = await _produtoRepository.Update(updateProduto);

            return _mapper.Map<ProdutoDto>(result);
        }
    }
}
