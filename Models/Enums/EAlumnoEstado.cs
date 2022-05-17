using System.ComponentModel;

namespace WebApplication4.Models.Enums
{
    public enum EAlumnoEstado
    {
        [Description("Matriculado")]
        Matriculado = 1,
        [Description("Expulsado")]
        Expulsado = 2,
        [Description("Egresado")]
        Egresado = 3
    }
}
