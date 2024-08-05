using FinalProg.Context;
using FinalProg.DTOs;
using FinalProg.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProg.Repository.Impl
{
    public class SucursalRepository : ISucursalRepository
    {
        private readonly SucursalesContext _context;
        public SucursalRepository(SucursalesContext context)
        {
            _context = context;
        }
        public async Task<List<GetConfiguracionDTO>> GetConfiguraciones()
        {
            return await _context.Configuraciones
                .Select(c => new GetConfiguracionDTO
                {
                    Id = c.Id,
                    Nombre = c.Nombre,
                    Valor = c.Valor
                })
                .ToListAsync();
        }

        public async Task<List<GetSucursalDTO>> GetSucursales()
        {
            return await _context.Sucursales
                .Include(s => s.Provincia)
                .Include(s => s.TipoSucursal)
                .Select(s => new GetSucursalDTO
                {
                    Id = s.Id,
                    Nombre = s.Nombre,
                    Ciudad = s.Ciudad,
                    IdTipo = s.TipoSucursal.Id,
                    TipoSucursalNombre = s.TipoSucursal.Nombre,
                    IdProvincia = s.Provincia.Id,
                    ProvinciaNombre = s.Provincia.Nombre,
                    Telefono = s.Telefono,
                    NombreTitular = s.NombreTitular,
                    ApellidoTitular = s.ApellidoTitular,
                    FechaAlta = s.FechaAlta
                })
                .ToListAsync();
        }

        public async Task<GetSucursalDTO> GetSucursalFiltrada()
        {
            var sucur = await _context.Sucursales
                .Where(s => s.Provincia.Nombre != "Buenos Aires")
                .OrderByDescending(s => s.FechaAlta)
                .Select(s => new GetSucursalDTO
                {
                    Id = s.Id,
                    Nombre = s.Nombre,
                    Ciudad = s.Ciudad,
                    IdTipo = s.TipoSucursal.Id,
                    TipoSucursalNombre = s.TipoSucursal.Nombre,
                    IdProvincia = s.Provincia.Id,
                    ProvinciaNombre = s.Provincia.Nombre,
                    Telefono = s.Telefono,
                    NombreTitular = s.NombreTitular,
                    ApellidoTitular = s.ApellidoTitular,
                    FechaAlta = s.FechaAlta
                })
                .FirstOrDefaultAsync();
            if (sucur == null)
            {
                throw new Exception("No se encontró la sucursal");
            }
            return sucur;
        }

        public async Task<bool> UpdateSucursal(Sucursal sucursal)
        {
            try
            {
                _context.Sucursales.Update(sucursal);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar la sucursal: {ex.Message}");
                return false;
            }
        }
    }
}
