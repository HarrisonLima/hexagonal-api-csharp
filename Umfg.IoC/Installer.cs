using SimpleInjector;
using Umfg.Aplicacao.Servicos;
using Umfg.Dominio.Interfaces;
using Umfg.Repositorio.Classes;

namespace Umfg.IoC
{
    public static class Installer
    {
        public static void Dependency(ref Container container)
        {
            container.Register<IProdutoRepositorio, ProdutoRepositorio>(Lifestyle.Singleton);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Singleton);
            container.Register<IProdutoServico, ProdutoServico>(Lifestyle.Singleton);

            container.Register<IClienteServico, ClienteServico>(Lifestyle.Singleton);
            container.Register<IClienteRepositorio, ClienteRepositorio>(Lifestyle.Singleton);
        }
    }
}
