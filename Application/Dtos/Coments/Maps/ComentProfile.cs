using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Coments.Maps
{
    public class ComentProfile : Profile
    {
        public ComentProfile() 
        {
            CreateMap<Coment, ComentsDto>();
        }
    }
}
