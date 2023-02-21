using System.ComponentModel.DataAnnotations;

namespace TePrestoApi.Models
{
    public class Ocupaciones
    {
        [Key]
        public int OcupacionId { get; set; }

        public string? Descripcion { get; set; }

        public string? Sueldo { get; set; }
        
    }
}
