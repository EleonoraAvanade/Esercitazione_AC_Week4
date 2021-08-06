using CoreLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(k => k.ID);
            builder.Property(p => p.Nome).IsRequired();
            builder.Property(c => c.Cognome).IsRequired();
            builder.Property(h => h.CodiceCliente).IsRequired();
            builder.HasMany(o => o.Ordini).WithOne(l => l.cliente);
        }
    }
}
