using AutoMapper;
namespace CopaDeFilmes.AutoMapper
{
    public class AutoMapperConfig
    {
       
            public static MapperConfiguration RegisterMappings()
            {
                return new MapperConfiguration(config =>
                {
                    config.AddProfile(new DomainToViewModelProfile());
                    config.AddProfile(new ViewModelToDomainProfile());

                });

            }
        
    }


}
