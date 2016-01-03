using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using SFS.Salao.Domain.Entities;

namespace SFS.Salao.Infra.Data.EntityConfig
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute {IsUnique = true}));

            Property(c => c.DataNascimento)
                .IsRequired();

            Property(c => c.Sexo)
                .IsRequired();

            Property(c => c.Ativo)
                .IsRequired();

            ToTable("Clientes");
        }
    }
}