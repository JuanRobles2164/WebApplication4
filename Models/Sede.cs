namespace WebApplication4.Models
{
    public class Sede
    {
        public int Id { get; set; }
        public int JornadaId { get; set; }
        public string Nombre { get; set; }

        public Sede create_instance(Sede e)
        {
            return e;
        }
        public void delete_instance(Sede e)
        {

        }
        public Sede edit_instance(Sede e)
        {
            return e;
        }
    }
}
