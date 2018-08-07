using AutoMapper;

namespace IdentidadeAcesso.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x => x.AddProfile<DomainToViewModelMappingProfile>());
        }
    }
}
