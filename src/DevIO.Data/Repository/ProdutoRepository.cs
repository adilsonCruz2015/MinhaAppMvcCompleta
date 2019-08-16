using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using DevIO.Data.Context;

namespace DevIO.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MeuDbContext context) :base(context) {  }

        public async Task<Produto> GetFirstFornecedor(Guid id)
        {
            return await Db.Produtos.AsNoTracking()
                .Include(f => f.Fornecedor)
                .FirstOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<IEnumerable<Produto>> GetFornecedores()
        {
            return await Db.Produtos.AsNoTracking()
                .Include(f => f.Fornecedor)
                .OrderBy(p => p.Nome).ToListAsync();
        }        

        public async Task<IEnumerable<Produto>> GetFornecedor(Guid fornecedorId)
        {
            return await Find(p => p.FornecedorId.Equals(fornecedorId));
        }
    }
}
