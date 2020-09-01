using AutoMapper;
using WebProject.Template.Domain.Models;
using WebProject.Template.Resources;

namespace WebProject.Template.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
        }
    }
}