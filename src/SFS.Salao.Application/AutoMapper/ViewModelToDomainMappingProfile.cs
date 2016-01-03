using AutoMapper;
using SFS.Salao.Application.ViewModels;
using SFS.Salao.Domain.Entities;

namespace SFS.Salao.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ClienteEnderecoViewModel, Cliente>();
            Mapper.CreateMap<ClienteEnderecoViewModel, Endereco>();
            Mapper.CreateMap<EnderecoViewModel, Cliente>();
        }
    }
}