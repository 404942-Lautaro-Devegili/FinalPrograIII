namespace FinalProg.Models
{
    public class Provincia
    {
        public Provincia()
        {
            Sucursales = new HashSet<Sucursal>();
        }
        public Guid? Id { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<Sucursal> Sucursales { get; set; }

    }
}
