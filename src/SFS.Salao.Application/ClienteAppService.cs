using System;
using System.Collections.Generic;
using AutoMapper;
using SFS.Salao.Application.Interfaces;
using SFS.Salao.Application.ViewModels;
using SFS.Salao.Domain.Entities;
using SFS.Salao.Domain.Interfaces.Service;

namespace SFS.Salao.Application
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            var cliente = Mapper.Map<ClienteEnderecoViewModel, Cliente>(clienteEnderecoViewModel);
            var endereco = Mapper.Map<ClienteEnderecoViewModel, Endereco>(clienteEnderecoViewModel);
            cliente.Enderecos.Add(endereco);
            _clienteService.Adicionar(cliente);

            return clienteEnderecoViewModel;
        }

        public ClienteViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteService.ObterPorId(id));
        }

        public ClienteViewModel ObterPorCPF(string cpf)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteService.ObterPorCPF(cpf));
        }

        public ClienteViewModel ObterPorEmail(string email)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteService.ObterPorEmail(email));
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteService.ObterTodos());
        }

        public ClienteViewModel Atualizar(ClienteViewModel clienteViewModel)
        {
            _clienteService.Atualizar(Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel));
            return clienteViewModel;
        }

        public void Remover(Guid id)
        {
            _clienteService.Remover(id);
        }

        public void Dispose()
        {
            _clienteService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}