using EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using WebApplication.Models;

namespace WebApplication
{
    public class GestionaleContext:DbContext
    {
        public DbSet<Ordine> Ordini { get; set; }
        public DbSet<Cliente> Clienti { get; set; }
        public GestionaleContext(DbContextOptions<GestionaleContext> options)
            : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Persist Security Info = False; 
        //                            Integrated Security = true; 
        //                            Initial Catalog = Gestionale; 
        //                            Server = .\SQLEXPRESS");
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration<Ordine>(new OrdineConfiguration());
        //    modelBuilder.ApplyConfiguration<Cliente>(new ClienteConfiguration());
        //}
    }
}
