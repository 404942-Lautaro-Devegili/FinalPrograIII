using FinalProg.DTOs;
using FinalProg.Models;
using FinalProg.Repository;

namespace FinalProg.Services.Impl
{
    public class SucursalService : ISucursalService
    {
        private readonly ISucursalRepository _sucursalRepository;
        public SucursalService(ISucursalRepository sucursalRepository)
        {
            _sucursalRepository = sucursalRepository;
        }
        public async Task<List<GetConfiguracionDTO>> GetConfiguraciones()
        {
            return await _sucursalRepository.GetConfiguraciones();
        }

        public async Task<List<GetSucursalDTO>> GetSucursales()
        {
            return await _sucursalRepository.GetSucursales();
        }

        public async Task<GetSucursalDTO> GetSucursalFiltrada()
        {
            return await _sucursalRepository.GetSucursalFiltrada();
        }

        public async Task<bool> UpdateSucursal(UpdateSucursalDTO sucursal)
        {
            Sucursal s = new Sucursal
            {
                Id = sucursal.Id,
                Nombre = sucursal.Nombre,
                Ciudad = sucursal.Ciudad,
                IdTipo = sucursal.IdTipo,
                IdProvincia = sucursal.IdProvincia,
                Telefono = sucursal.Telefono,
                NombreTitular = sucursal.NombreTitular,
                ApellidoTitular = sucursal.ApellidoTitular,
                FechaAlta = sucursal.FechaAlta
            };
            return await _sucursalRepository.UpdateSucursal(s);
        }
    }
}
