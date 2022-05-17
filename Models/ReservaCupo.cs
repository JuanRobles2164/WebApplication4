using System;

namespace WebApplication4.Models
{
    public class ReservaCupo
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; } = "ACTIVA";

        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }

        public int AspiranteId { get; set; }
        public Aspirante Aspirante { get; set; }

        public ReservaCupo create_instance(ReservaCupo e)
        {
            return e;
        }
        public void delete_instance(ReservaCupo e)
        {

        }
        public ReservaCupo edit_instance(ReservaCupo e)
        {
            return e;
        }
    }
}
