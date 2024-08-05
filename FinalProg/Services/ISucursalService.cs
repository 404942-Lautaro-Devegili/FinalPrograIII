using FinalProg.DTOs;
using FinalProg.Models;

namespace FinalProg.Services
{
    public interface ISucursalService
    {
        Task<List<GetConfiguracionDTO>> GetConfiguraciones();
        Task<bool> UpdateSucursal(UpdateSucursalDTO sucursal);
        Task<List<GetSucursalDTO>> GetSucursales();
        Task<GetSucursalDTO> GetSucursalFiltrada();
    }
}
