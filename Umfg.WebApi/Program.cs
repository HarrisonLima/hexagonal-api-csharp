using Microsoft.EntityFrameworkCore;
using SimpleInjector;
using System.Configuration;
using Umfg.IoC;
using Umfg.Repositorio.Classes;

namespace Umfg.WebApi
{
    public class Program
    {
        private static Container _container = new Container();

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSimpleInjector(_container, options =>
            {
                options.AddAspNetCore().AddControllerActivation();
            });

            builder.Services.AddDbContext<MySqlDataBaseContext>(options
                => options.UseMySQL(@"Server=127.0.0.1;Port=3306;User Id=root;Password=root;Database=umfgdb"),
                ServiceLifetime.Singleton);

            Installer.Dependency(ref _container);

            var app = builder.Build();

            app.Services.UseSimpleInjector(_container);
            _container.Verify();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}