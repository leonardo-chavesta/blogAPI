using Application.Dtos.Perfiles;
using Application.Services.Abstractions;
using AutoMapper;
using Infraestructure.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations
{
    public class PerfilService : IPerfilService
    {
        private readonly IMapper _mapper;
        private readonly IPerfilRepository _perfilRepository;

        public PerfilService(IMapper mapper, IPerfilRepository perfilRepository)
        {
            _mapper = mapper;
            _perfilRepository = perfilRepository;
        }

        public async Task<PerfilDto?> Buscar(int id)
        {
            var response = await _perfilRepository.Buscar(id);

            return _mapper.Map<PerfilDto?>(response);
        }

        public async Task<IList<PerfilDto>> ListaPerfil()
        {
            var response = await _perfilRepository.ListaPerfil();

            return _mapper.Map<IList<PerfilDto>>(response);
        }
    }
}
