using Application.Dtos.Perfiles;
using Application.Dtos.Personas;
using Application.Services.Abstractions;
using AutoMapper;
using Domain;
using Infraestructure.Repositories.Abstractions;
using Infraestructure.Repositories.Implementacions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations
{
    public class PersonaService  : IPersonaService
    {
        private readonly IMapper _mapper;
        private readonly IPersonaRepository _personaRepository;
        public PersonaService(IMapper mapper, IPersonaRepository personaRepository)
        {
            _mapper = mapper;
            _personaRepository = personaRepository;
        }

        public async Task<PersonaDto> BuscarPersona(int id)
        {
            var response = await _personaRepository.BusCarPersona(id);
            return _mapper.Map<PersonaDto>(response);

        }

        public async Task<PersonaDto> CrearPersona(PersonaFormDto entity)
        {
            var dto = _mapper.Map<Persona>(entity);
            var response = await _personaRepository.CrearPersona(dto);

            return _mapper.Map<PersonaDto>(response);
        }

        public async Task<PersonaDto> EliminarPersona(int id)
        {
            var response = await _personaRepository.EliminarPersona(id);

            return _mapper.Map<PersonaDto>(response);
        }

        public async Task<IList<PersonaDto>> ListarPersona()
        {
            var response = await _personaRepository.ListarPersona();

            return _mapper.Map<IList<PersonaDto>>(response);
        }
    }
}
