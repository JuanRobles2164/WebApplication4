namespace WebApplication4.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool AsigCursoActiva { get; set; }
        public string Estado { get; set; }

        public Estudiante create_instance(Estudiante e)
        {
            return e;
        }
        public void delete_instance(Estudiante e)
        {

        }
        public Estudiante edit_instance(Estudiante e)
        {
            return e;
        }
        public bool asignarCurso(Estudiante e)
        {
            return true;
        }
        public bool Egresar(Estudiante e)
        {
            return true;
        }
        public bool Expulsar(Estudiante e)
        {
            return true;
        }
        
    }
}
