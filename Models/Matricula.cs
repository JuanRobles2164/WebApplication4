using System;

namespace WebApplication4.Models
{
    public class Matricula
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; } = "ACTIVA";

        public Matricula create_instance(Matricula e)
        {
            return e;
        }
        public void delete_instance(Matricula e)
        {

        }
        public Matricula edit_instance(Matricula e)
        {
            return e;
        }

    }
}
