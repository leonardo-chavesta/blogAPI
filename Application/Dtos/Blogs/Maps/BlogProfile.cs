using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Blogs.Maps
{
    public class BlogProfile : Profile
    {
        public BlogProfile() 
        {
            CreateMap<Blog, BlogDto>();
        }
    }
}
