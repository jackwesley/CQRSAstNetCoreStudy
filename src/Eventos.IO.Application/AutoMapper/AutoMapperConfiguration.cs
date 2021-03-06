﻿using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace Eventos.IO.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
            {
                ps.AddProfile(new DomainToViewModelMappingPofile());
                ps.AddProfile(new ViewModelToDomainMappingProfile());
            });
        }
    }
}
