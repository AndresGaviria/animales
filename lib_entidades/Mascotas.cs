using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Mascotas
    {
        [Key] public int Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }
    }
}