using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIO.Business.Intefaces
{
    public interface IProdutoRepository
    {
        Task<Produto> ObterProdutoFornecedor(Guid id);
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
    }
}