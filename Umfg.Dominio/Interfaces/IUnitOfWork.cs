using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Dominio.Interfaces
{
    public interface IUnitOfWork
    {
        IProdutoRepositorio ProdutoRepositorio { get; }
        IClienteRepositorio ClienteRepositorio { get; }

        void SaveChanges();
    }
}