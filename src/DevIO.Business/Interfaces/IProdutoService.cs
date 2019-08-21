using DevIO.Business.Models;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Add(Produto produto);

        Task Update(Produto produto);

        Task Excluir(Guid id);        
    }
}
