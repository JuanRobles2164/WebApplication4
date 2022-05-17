namespace WebApplication4.Models
{
    public class Acudiente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }


        public Acudiente create_instance(Acudiente e)
        {
            return e;
        }
        public void delete_instance(Acudiente e)
        {

        }
        public Acudiente edit_instance(Acudiente e)
        {
            return e;
        }
    }
}
