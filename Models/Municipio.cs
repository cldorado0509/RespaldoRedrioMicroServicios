using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMVA.REDRIO.Models
{
     /// <summary>
    /// Modelo de  municipio, incluyendo su nombre, código y la referencia a un departamento al que pertenece.
    /// </summary>
    [Table("MUNICIPIOS")]
    public class Municipio
    {
        [Key]
        [Column("ID_MUNI")]
        public int IdMunicipio { get; set; }

        [Required]
        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("CODIGO")]
        public string? Codigo { get; set; }

        [Required]
        [Column("ID_DEPTO")]
        public int Id_Departamento {get; set;}

         public Departamento? Departamento { get; set; }
    }
}
