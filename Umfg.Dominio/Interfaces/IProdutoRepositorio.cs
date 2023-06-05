using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.Dominio.Entidades;

namespace Umfg.Dominio.Interfaces
{
    public interface IProdutoRepositorio
    {
        void Adicionar(Produto produto);
        void Remover(Produto produto);
        List<Produto> ObterTodos();
    }
}
