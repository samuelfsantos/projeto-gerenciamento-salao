using System;
using System.Collections.Generic;

namespace SFS.Salao.Domain.Entities
{
    public class Cliente
    {
        public Cliente()
        {
            ClienteId = Guid.NewGuid();
            Telefones = new List<Telefone>();
            Enderecos = new List<Endereco>();
        }

        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Sexo { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}