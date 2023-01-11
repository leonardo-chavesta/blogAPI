
using AutoMapper;
using Domain;

namespace Application.Dtos.Perfiles.Maps
{
    public class PerfilProfile : Profile
    {
        public PerfilProfile() 
        {
            CreateMap<Perfil, PerfilDto>();
        }
        
    }
}
