namespace FinalProg.Models
{
    public class Sucursal
    {
        public Guid? Id { get; set; }
        public string? Nombre { get; set; }
        public string? Ciudad { get; set; }
        public Guid? IdTipo { get; set; }
        public Guid? IdProvincia { get; set; }
        public string? Telefono { get; set; }
        public string? NombreTitular { get; set; }
        public string? ApellidoTitular { get; set; }
        public DateTime? FechaAlta { get; set; }

        public virtual TipoSucursal? TipoSucursal { get; set; } = null;
        public virtual Provincia? Provincia { get; set; } = null;
    }
}
