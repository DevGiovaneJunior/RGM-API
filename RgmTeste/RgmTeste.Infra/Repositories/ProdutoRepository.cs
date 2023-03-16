using RgmTeste.Infra.Context;
using RgmTeste.Infra.Entities;
using RgmTeste.Infra.Interfaces;

namespace RgmTeste.Infra.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        public ApplicationDbContext _context;
        public ProdutoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Produto> Add(Produto produto)
        {
            _context.Add(produto);
            await _context.SaveChangesAsync();

            return produto;
        }

        public async Task<List<Produto>> Get()
        {
            var produtos = _context.Produto.ToList();
            return produtos;
        }
        public async Task<Produto> Update(Produto produto)
        {
            _context.Update(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

    }
}
