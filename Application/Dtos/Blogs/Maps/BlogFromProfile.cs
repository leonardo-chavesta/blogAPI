using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Blogs.Maps
{
    public class BlogFromProfile : Profile
    {
        public BlogFromProfile() 
        {
            CreateMap<Blog, BlogFormDto>().ReverseMap();
        }    
    }
}
