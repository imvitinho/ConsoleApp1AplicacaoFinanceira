using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1AplicacaoFinanceira.Entities
{
    internal class AplicacaoFinanceiraDbContext : DbContext
    {

        public DbSet<AplicacaoFinanceira> AplicacaoFinanceiraS { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DBAplicacaoFinanceiraEF;Trusted_Connection=True;");
        }
    }
}
