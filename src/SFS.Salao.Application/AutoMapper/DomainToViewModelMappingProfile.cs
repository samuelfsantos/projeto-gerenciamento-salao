using AutoMapper;
using SFS.Salao.Application.ViewModels;
using SFS.Salao.Domain.Entities;

namespace SFS.Salao.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Cliente, ClienteEnderecoViewModel>();
            Mapper.CreateMap<Endereco, ClienteEnderecoViewModel>();
            Mapper.CreateMap<Cliente, EnderecoViewModel>();
        }
    }
}