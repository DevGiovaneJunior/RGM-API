using RgmTeste.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RgmTeste.Domain.Interfaces
{
    public interface IProdutoService
    {
        Task<List<ProdutoDto>> Get();
        Task<ProdutoDto> Add(ProdutoDto produto);
        Task<ProdutoDto> Update(ProdutoDto produto);
    }
}
