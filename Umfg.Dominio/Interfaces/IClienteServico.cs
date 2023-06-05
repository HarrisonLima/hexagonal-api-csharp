using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.Dominio.Entidades;

namespace Umfg.Dominio.Interfaces
{
    public interface IClienteServico
    {
        Cliente Gravar(Cliente cliente);
        Cliente ObterClientePorDocumento(string documento);
        List<Cliente> ObterTodos();
        void RemoverPorDocumento(string documento);
    }
}
