using AutoMapper;
using IdentityServerAspNetIdentity.Dto;
using IdentityServerAspNetIdentity.Models;

namespace IdentityServerAspNetIdentity.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, ApplicationUser>();
        }
    }
}
