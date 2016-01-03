using Ninject;

namespace SFS.Salao.Infra.CrossCutting.IoC
{
    public class Container
    {
        public StandardKernel GetModule()
        {
            return new StandardKernel(new Modulo());
        }
    }
}