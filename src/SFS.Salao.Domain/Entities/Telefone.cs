using System;

namespace SFS.Salao.Domain.Entities
{
    public class Telefone
    {
        public Telefone()
        {
            TelefoneId = Guid.NewGuid();
        }

        public Guid TelefoneId { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }
        public int Tipo { get; set; }
        public Guid ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}