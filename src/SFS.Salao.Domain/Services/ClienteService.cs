using System;
using System.Collections.Generic;
using SFS.Salao.Domain.Entities;
using SFS.Salao.Domain.Interfaces.Repository;
using SFS.Salao.Domain.Interfaces.Service;

namespace SFS.Salao.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente ObterPorCPF(string cpf)
        {
            return _clienteRepository.ObterPorCPF(cpf);
        }

        public Cliente ObterPorEmail(string email)
        {
            return _clienteRepository.ObterPorEmail(email);
        }

        public Cliente Adicionar(Cliente cliente)
        {
            return _clienteRepository.Adicionar(cliente);
        }

        public Cliente ObterPorId(Guid id)
        {
            return _clienteRepository.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public Cliente Atualizar(Cliente cliente)
        {
            return _clienteRepository.Atualizar(cliente);
        }

        public void Remover(Guid id)
        {
            _clienteRepository.Remover(id);
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}