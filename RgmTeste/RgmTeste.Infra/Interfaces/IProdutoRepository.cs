using RgmTeste.Infra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RgmTeste.Infra.Interfaces
{
    public interface IProdutoRepository
    {
        Task<Produto>Add(Produto produto);
        Task<List<Produto>>Get();
        Task<Produto>Update(Produto produto);
    }
}
