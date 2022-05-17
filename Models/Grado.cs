namespace WebApplication4.Models
{
    public class Grado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Cupo { get; set; }
        public int EstudiantesAsignados { get; set; } = 0;
        public int CupoDisponible { get; } = 0;
        public int CuposReservados { get; } = 0;

        public Grado create_instance(Grado e)
        {
            return e;
        }
        public void delete_instance(Grado e)
        {

        }
        public Grado edit_instance(Grado e)
        {
            return e;
        }
    }
}
