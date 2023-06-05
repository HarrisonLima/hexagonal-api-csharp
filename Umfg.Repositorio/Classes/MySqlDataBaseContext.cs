using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.Repositorio.Mapeamento;

namespace Umfg.Repositorio.Classes
{
    public sealed class MySqlDataBaseContext : DbContext
    {
        public MySqlDataBaseContext()
        {
            AplicarMigrations();
        }

        public MySqlDataBaseContext(DbContextOptions<MySqlDataBaseContext> options)
            :base(options)
        {
            AplicarMigrations();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MapeamentoProduto());
            modelBuilder.ApplyConfiguration(new MapeamentoCliente());


            base.OnModelCreating(modelBuilder);
        }

        private void AplicarMigrations()
        {
            if (Database.GetPendingMigrations().Any())
                Database.Migrate();
        }
    }
}