using DevIO.Business.Models;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Intefaces
{
    public interface IEnderecoRepository
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}