using System.ComponentModel;

namespace WebApplication4.Models.Enums
{
    public enum EAspiranteEstado
    {
        [Description("Preinscrito")]
        Preinscrito = 1,
        [Description("Prematriculado")]
        Prematriculado = 2,
        [Description("Matriculado")]
        Matriculado = 3
    }
}
