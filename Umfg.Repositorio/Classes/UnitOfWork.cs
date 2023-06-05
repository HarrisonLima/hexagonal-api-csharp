using Umfg.Dominio.Interfaces;

namespace Umfg.Repositorio.Classes
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly MySqlDataBaseContext _mySqlDataBaseContext;

        public IProdutoRepositorio ProdutoRepositorio { get; private set; }
        public IClienteRepositorio ClienteRepositorio { get; private set; }

        public UnitOfWork(
            MySqlDataBaseContext mySqlDataBaseContext,
            IProdutoRepositorio produtoRepositorio,
            IClienteRepositorio clienteRepositorio)
        {
            _mySqlDataBaseContext = mySqlDataBaseContext;
            ProdutoRepositorio = produtoRepositorio;
            ClienteRepositorio = clienteRepositorio;
        }

        public void SaveChanges()
        {
            _mySqlDataBaseContext.SaveChanges();
        }
    }
}
