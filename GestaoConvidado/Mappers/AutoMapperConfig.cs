﻿using AutoMapper;

namespace GestaoConvidado.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x => x.AddProfile<DomainToViewModelMappingProfile>());
        }
    }
}
