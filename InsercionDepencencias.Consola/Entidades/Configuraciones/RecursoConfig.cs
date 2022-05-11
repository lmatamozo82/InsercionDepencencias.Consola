using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsercionDepencencias.Consola.Entidades.Configuraciones
{
    public class RecursoConfig : IEntityTypeConfiguration<Recurso>
    {
        public void Configure(EntityTypeBuilder<Recurso> builder)
        {
            builder.Property(x => x.Denominacion).HasMaxLength(50).IsRequired();
        }
    }
}
