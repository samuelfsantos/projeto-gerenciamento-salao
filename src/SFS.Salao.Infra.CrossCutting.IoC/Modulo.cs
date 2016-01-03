using Ninject.Modules;
using SFS.Salao.Application;
using SFS.Salao.Application.Interfaces;
using SFS.Salao.Domain.Interfaces.Repository;
using SFS.Salao.Domain.Interfaces.Service;
using SFS.Salao.Domain.Services;
using SFS.Salao.Infra.Data.Repository;

namespace SFS.Salao.Infra.CrossCutting.IoC
{
    public class Modulo : NinjectModule
    {
        public override void Load()
        {
            // App
            Bind<IClienteAppService>().To<ClienteAppService>();

            // Domain
            Bind<IClienteService>().To<ClienteService>();

            // Data
            Bind<IClienteRepository>().To<ClienteRepository>();
        }
    }
}