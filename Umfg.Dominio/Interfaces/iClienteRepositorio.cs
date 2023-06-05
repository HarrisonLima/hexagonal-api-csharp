using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.Dominio.Entidades;

namespace Umfg.Dominio.Interfaces
{
    public interface IClienteRepositorio
    {
        void Adicionar(Cliente cliente);
        void Remover(Cliente cliente);
        List<Cliente> ObterTodos();
    }
}
