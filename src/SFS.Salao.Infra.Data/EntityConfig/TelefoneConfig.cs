using System.Data.Entity.ModelConfiguration;
using SFS.Salao.Domain.Entities;

namespace SFS.Salao.Infra.Data.EntityConfig
{
    public class TelefoneConfig : EntityTypeConfiguration<Telefone>
    {
        public TelefoneConfig()
        {
            HasKey(t => t.TelefoneId);

            Property(t => t.DDD)
                .IsRequired()
                .HasMaxLength(3);

            Property(t => t.Numero)
                .IsRequired()
                .HasMaxLength(9);

            Property(t => t.Tipo)
                .IsRequired();

            HasRequired(t => t.Cliente)
                .WithMany(c => c.Telefones)
                .HasForeignKey(t => t.ClienteId);

            ToTable("Telefones");
        }
    }
}