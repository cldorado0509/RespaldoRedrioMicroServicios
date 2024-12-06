using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMVA.REDRIO.Models
{
     /// <summary>
    /// modelo de departamento dentro del sistema, con un nombre, código y fechas de creación y actualización.
    /// </summary>
    [Table("DEPARTAMENTOS")]
    public class Departamento
    {
        [Key]
        [Column("ID_DEPTO")]
        public int IdDepartamento { get; set; }

        [Required]
        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("CODIGO")]
        public string? Codigo { get; set; }

        [Column("FECHA_CREACION")]
        public DateTime? Fecha_creacion { get; internal set; }

        [Column("FECHA_ACTUALIZACION")]
        public DateTime? Fecha_actualizacion { get; internal set; }
    }
}
