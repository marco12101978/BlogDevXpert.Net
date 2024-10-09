﻿using AutoMapper;
using Blog.Api.ViewModels;
using Blog.Business.Models;

namespace Blog.Api.Configuration
{

    public static class AutoMapperConfig
    {
        public static WebApplicationBuilder AddAutoMapperConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return builder;
        }
    }

    public class AutomapperConfiguration : Profile
    {
        public AutomapperConfiguration()
        {
            CreateMap<Autor, AutorViewModel>().ReverseMap();
            CreateMap<Postagem, PostagemViewModel>().ReverseMap();
            CreateMap<Comentario, ComentarioViewModel>().ReverseMap();
        }
    }
}
