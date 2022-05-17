namespace WebApplication4.Models
{
    public class Aspirante
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public bool? ApruebaEvaluacion { get; set; } = null;

        public Aspirante create_instance(Aspirante e)
        {
            return e;
        }
        public void delete_instance(Aspirante e)
        {

        }
        public Aspirante edit_instance(Aspirante e)
        {
            return e;
        }
        public void prematricular(Aspirante e)
        {

        }
        public void rechazar(Aspirante e)
        {

        }
    }
}
