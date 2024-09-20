using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Propietarios
    {
        [Key] public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Animal { get; set; }
        public bool Activo { get; set; }

        [NotMapped] public Mascotas? _Animal { get; set; }
    }
}