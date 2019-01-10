using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() : base("DomainToViewModelMappings")
        {
            CreateMap<CustomerViewModel, Customer>();
            CreateMap<ProductViewModel, Product>();
        }
    }
}