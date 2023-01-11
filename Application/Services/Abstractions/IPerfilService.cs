using Application.Dtos.Perfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Abstractions
{
    public interface IPerfilService
    {
        Task<PerfilDto?> Buscar(int id);
        Task<IList<PerfilDto>> ListaPerfil();
    }
}
