namespace ProyectoFinal_.Models
{
    public class Sede
    {
        public int SedeID { get; set; }
        public string? NombreCiudad {  get; set; }
        public List<Empleado>? Empleados { get; set; }

    }
}
