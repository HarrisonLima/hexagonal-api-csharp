using Microsoft.EntityFrameworkCore;
using Umfg.Dominio.Entidades;
using Umfg.Dominio.Interfaces;

namespace Umfg.Repositorio.Classes
{
    public sealed class ClienteRepositorio : IClienteRepositorio
    {
        private readonly MySqlDataBaseContext _dataBaseContext;

        private DbSet<Cliente> Clientes => _dataBaseContext.Set<Cliente>();

        public ClienteRepositorio(MySqlDataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public void Adicionar(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public List<Cliente> ObterTodos()
        {
            return Clientes.ToList();
        }

        public void Remover(Cliente cliente)
        {
            Clientes.Remove(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            _dataBaseContext.Entry(cliente).State = EntityState.Modified;
            _dataBaseContext.SaveChanges();
        }

        
    }
}
