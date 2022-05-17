namespace WebApplication4.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public int SedeId { get; set; }
        public Sede Sede { get; set; }
        public int GradoId { get; set; }
        public Grado Grado { get; set; }
        public string Descripcion { get; set; }
        public int Cupo { get; set; }
        public int EstudAsignados { get; set; }
        public int CupoDisponible { get; set; } = 0;

        public Curso create_instance(Curso e)
        {
            return e;
        }
        public void delete_instance(Curso e)
        {

        }
        public Curso edit_instance(Curso e)
        {
            return e;
        }
    }
}
