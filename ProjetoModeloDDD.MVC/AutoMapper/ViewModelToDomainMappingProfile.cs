using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile() : base("ViewModelToDomainMappings")
        {
            CreateMap<Customer, CustomerViewModel>();
            CreateMap<Product, ProductViewModel>();
        }
    }
}