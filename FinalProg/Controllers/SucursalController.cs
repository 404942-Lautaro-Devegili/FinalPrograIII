using FinalProg.DTOs;
using FinalProg.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SucursalController : ControllerBase
    {
        private readonly ISucursalService _sucursalService;

        public SucursalController(ISucursalService sucursalService)
        {
            _sucursalService = sucursalService;
        }

        [HttpGet("configuraciones")]
        public async Task<IActionResult> GetConfiguraciones()
        {
            try
            {
                return Ok(await _sucursalService.GetConfiguraciones());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPut("sucursal")]
        public async Task<IActionResult> UpdateSucursal(UpdateSucursalDTO sucursal)
        {
            try
            {
                await _sucursalService.UpdateSucursal(sucursal);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("sucursales")]
        public async Task<IActionResult> GetSucursales()
        {
            try
            {
                return Ok(await _sucursalService.GetSucursales());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
        [HttpGet("sucursalFiltrada")]
        public async Task<IActionResult> GetSucursalFiltrada()
        {
            try
            {
                return Ok(await _sucursalService.GetSucursalFiltrada());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}

