using System.Data.Entity.ModelConfiguration;
using SFS.Salao.Domain.Entities;

namespace SFS.Salao.Infra.Data.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(e => e.EnderecoId);

            Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(150);

            Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.CEP)
                .IsRequired()
                .HasMaxLength(8);

            Property(e => e.Complemento)
                .HasMaxLength(100);

            HasRequired(e => e.Cliente)
                .WithMany(c => c.Enderecos)
                .HasForeignKey(e => e.ClienteId);

            ToTable("Enderecos");
        }
    }
}