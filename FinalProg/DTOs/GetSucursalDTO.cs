using FinalProg.Models;

namespace FinalProg.DTOs
{
    public class GetSucursalDTO
    {

        public Guid? Id { get; set; }
        public string? Nombre { get; set; }
        public string? Ciudad { get; set; }
        public Guid? IdTipo { get; set; }
        public string? TipoSucursalNombre { get; set; }
        public Guid? IdProvincia { get; set; }
        public string? ProvinciaNombre { get; set; }
        public string? Telefono { get; set; }
        public string? NombreTitular { get; set; }
        public string? ApellidoTitular { get; set; }
        public DateTime? FechaAlta { get; set; }
    }
}
