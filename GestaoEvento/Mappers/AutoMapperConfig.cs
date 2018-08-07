using AutoMapper;

namespace GestaoEvento.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x => x.AddProfile<DomainToViewModelMappingProfile>());
        }
    }
}
