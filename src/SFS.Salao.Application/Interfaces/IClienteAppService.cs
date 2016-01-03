using System;
using System.Collections.Generic;
using SFS.Salao.Application.ViewModels;

namespace SFS.Salao.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel);
        ClienteViewModel ObterPorId(Guid id);
        ClienteViewModel ObterPorCPF(string cpf);
        ClienteViewModel ObterPorEmail(string email);
        IEnumerable<ClienteViewModel> ObterTodos();
        ClienteViewModel Atualizar(ClienteViewModel clienteViewModel);
        void Remover(Guid id);
    }
}