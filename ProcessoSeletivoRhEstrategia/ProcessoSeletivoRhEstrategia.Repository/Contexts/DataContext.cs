using Microsoft.EntityFrameworkCore;
using ProcessoSeletivo.Presentation.Model;
using ProcessoSeletivoRhEstrategia.Repository.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessoSeletivoRhEstrategia.Repository.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
        }
        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.Entity<Pessoa>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<Pessoa>().HasIndex(u => u.Cpf).IsUnique();

        }
    }
}
