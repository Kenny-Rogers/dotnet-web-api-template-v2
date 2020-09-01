using AutoMapper;
using WebProject.Template.Domain.Models;
using WebProject.Template.Resources;

namespace WebProject.Template.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
        
    }
}