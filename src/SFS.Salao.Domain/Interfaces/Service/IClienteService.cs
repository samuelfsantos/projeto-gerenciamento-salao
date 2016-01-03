using System;
using System.Collections.Generic;
using SFS.Salao.Domain.Entities;

namespace SFS.Salao.Domain.Interfaces.Service
{
    public interface IClienteService : IDisposable
    {
        Cliente ObterPorCPF(string cpf);
        Cliente ObterPorEmail(string email);
        Cliente Adicionar(Cliente cliente);
        Cliente ObterPorId(Guid id);
        IEnumerable<Cliente> ObterTodos();
        Cliente Atualizar(Cliente cliente);
        void Remover(Guid id);
    }
}