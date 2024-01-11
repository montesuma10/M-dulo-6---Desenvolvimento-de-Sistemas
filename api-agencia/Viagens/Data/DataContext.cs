using Viagens.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;

namespace Viagens.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Viagem> Viagens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Viagem>().HasData(
                new Viagem
                {
                    Id = 1,
                    Nome = "Ricardo",
                    CPF = "02688974532",
                    Destino = "Paris",
                    Valor = 899.99M,
                    Data_ida = new DateTime(2022, 5, 2), 
                    Data_volta = new DateTime(2022, 5, 10) 
                },
                new Viagem
                {
                    Id = 2,
                    Nome = "José",
                    CPF = "02688978652",
                    Destino = "Londres",
                    Valor = 999.99M,
                    Data_ida = new DateTime(2023, 6, 6), 
                    Data_volta = new DateTime(2023, 6, 12) 
                },
                new Viagem
                {
                    Id = 3,
                    Nome = "Henrique",
                    CPF = "02688975421",
                    Destino = "Lisboa",
                    Valor = 699.99M,
                    Data_ida = new DateTime(2023, 12, 10), 
                    Data_volta = new DateTime(2023, 12, 20) 
                }
            );
        }
    }
}

