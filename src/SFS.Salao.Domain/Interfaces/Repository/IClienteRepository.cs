using SFS.Salao.Domain.Entities;

namespace SFS.Salao.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorCPF(string cpf);
        Cliente ObterPorEmail(string email);
    }
}