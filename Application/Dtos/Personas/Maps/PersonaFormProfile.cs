using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Personas.Maps
{
    public  class PersonaFormProfile : Profile
    {
        public PersonaFormProfile() 
        {
            CreateMap<Persona, PersonaFormDto>().ReverseMap();

        }
    }
}
