using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.Dominio.Entidades;

namespace Umfg.Dominio.Interfaces
{
    public interface IProdutoServico
    {
        Produto Gravar(Produto produto);
        Produto ObterProdutoPorCodigoBarra(string codigoBarra);
        List<Produto> ObterTodos();
        void RemoverPorCodigoBarra(string codigoBarra);
    }
}