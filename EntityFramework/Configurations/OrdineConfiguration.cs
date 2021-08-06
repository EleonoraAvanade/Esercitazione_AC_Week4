using CoreLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Configurations
{
    public class OrdineConfiguration : IEntityTypeConfiguration<Ordine>
    {
        public void Configure(EntityTypeBuilder<Ordine> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(dO => dO.DataOrdine).IsRequired();
            builder.Property(d => d.CodiceOrdine).IsRequired();
            builder.Property(c => c.CodiceProdotto).IsRequired();
            builder.Property(i => i.Importo).IsRequired();
            builder.HasOne(l => l.cliente).WithMany(o => o.Ordini);
        }
    }
}
