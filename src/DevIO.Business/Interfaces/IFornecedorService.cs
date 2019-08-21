using DevIO.Business.Models;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IFornecedorService : IDisposable
    {
        Task Add(Fornecedor fornecedor);

        Task Update(Fornecedor fornecedor);

        Task Excluir(Guid id);

        Task UpdateAdress(Endereco endereco);
    }
}
