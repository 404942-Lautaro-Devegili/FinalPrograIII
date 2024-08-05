using FinalProg.DTOs;
using FinalProg.Models;

namespace FinalProg.Repository
{
    public interface ISucursalRepository
    {
        Task<List<GetConfiguracionDTO>> GetConfiguraciones();
        Task<bool> UpdateSucursal(Sucursal sucursal);
        Task<List<GetSucursalDTO>> GetSucursales();
        Task<GetSucursalDTO> GetSucursalFiltrada();
    }
}
