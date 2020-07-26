using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoApp.Dominio.Entidades;

namespace TodoApp.Infra.Contexts.Mapeamentos
{
    public class TarefaBDMapeamento : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> montar)
        {
            montar.ToTable("Tarefa");
            montar.Property(x => x.Id);
            montar.Property(x => x.Usuario).HasMaxLength(120).HasColumnType("varchar(120)");
            montar.Property(x => x.Titulo).HasMaxLength(160).HasColumnType("varchar(160)");
            montar.Property(x => x.Feito).HasColumnType("bit");
            montar.HasIndex(i => i.Usuario);
        }
    }
}
