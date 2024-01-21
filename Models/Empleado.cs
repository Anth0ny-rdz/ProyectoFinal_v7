using System.Net.Mail;

namespace ProyectoFinal_.Models
{
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public string? NombreEmpleado { get; set; }
        public string? CargoEmpleado { get; set; }
        public int EdadEmpleado { get; set; }
        public decimal SueldoEmpleado { get; set; }
        public int SedeID { get; set; }
        public Sede? sede { get; set; }


    }
}
