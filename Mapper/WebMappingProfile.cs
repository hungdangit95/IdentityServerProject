using AutoMapper;

namespace IdentityServerAspNetIdentity.Mapper
{
    public static class WebMappingProfile 
    {
        public static MapperConfiguration InitializeAutoMapper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());  //mapping between Web and Business layer objects
            });
            return config;
        }
    }
}
