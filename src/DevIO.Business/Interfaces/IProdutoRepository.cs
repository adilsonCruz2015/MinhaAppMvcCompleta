using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> GetFornecedor(Guid fornecedorId);

        Task<IEnumerable<Produto>> GetFornecedores();

        Task<Produto> GetFirstFornecedor(Guid id);
    }
}
