﻿using AutoMapper;
using BlogApp.Entities.Concrete;
using BlogApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Services.AutoMapper.Profiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleAddDto, Article>()
                .ForMember(dest => dest.CreatedDate, option => option.MapFrom(x => DateTime.Now));
            CreateMap<ArticleUpdateDto, Article>()
                .ForMember(dest => dest.ModifiedDate, option => option.MapFrom(x => DateTime.Now));
        }
    }
}
