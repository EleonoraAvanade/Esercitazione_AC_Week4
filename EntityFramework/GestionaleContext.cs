using CoreLayer.Models;
using EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFramework
{
    public class GestionaleContext:DbContext
    {
        public DbSet<Ordine> Ordini { get; set; }
        public DbSet<Cliente> Clienti { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Persist Security Info = False; 
                                    Integrated Security = true; 
                                    Initial Catalog = Gestionale; 
                                    Server = .\SQLEXPRESS");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Ordine>(new OrdineConfiguration());
            modelBuilder.ApplyConfiguration<Cliente>(new ClienteConfiguration());
        }
    }
}
