using System;
using System.Data.Entity;
using System.Linq;
using Dapper;
using SFS.Salao.Domain.Entities;
using SFS.Salao.Domain.Interfaces.Repository;

namespace SFS.Salao.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public Cliente ObterPorCPF(string cpf)
        {
            return Buscar(c => c.CPF == cpf).FirstOrDefault();
        }

        public Cliente ObterPorEmail(string email)
        {
            //return Db.Clientes.FirstOrDefault(c => c.Email == email);
            return Buscar(c => c.Email == email).FirstOrDefault();
        }

        public override Cliente Atualizar(Cliente cliente)
        {
            var entry = Db.Entry(cliente);
            DbSet.Attach(cliente);
            entry.State = EntityState.Modified;
            entry.Property(c => c.Email).IsModified = false;
            SaveChanges();

            return cliente;
        }

        public override Cliente ObterPorId(Guid id)
        {
            var sql = @"SELECT * FROM Clientes c " +
                      "INNER JOIN Enderecos e " +
                      "ON c.ClienteId = e.ClienteId " +
                      "WHERE c.ClienteId = @sid";

            using (var cn = Db.Database.Connection)
            {
                cn.Open();
                var cliente = cn.Query<Cliente, Endereco, Cliente>(sql,
                    (c, e) =>
                    {
                        c.Enderecos.Add(e);
                        return c;
                    }, new {sid = id}, splitOn: "ClienteId, EnderecoId");

                return cliente.FirstOrDefault();
            }
        }
    }
}