using System.ComponentModel.DataAnnotations;

namespace CarreraDulantoEPCTDSII.Models.Entidades
{
    public class ValesCabCarrera
    {
        [Key]
        [Display(Name = "ID")]
        public int IdvalesCab { get; set; }

        [Required]
        [Display(Name ="Proveedor")]
        [MaxLength(100)]
        public string Proveedor { get; set; }

        [Required]
        [Display(Name ="Feha de Registro")]
        public DateTime FechaRegistro { get; set; }

        public virtual ICollection<ValesDetCarrera> ValesDet { get; set; }
    }
}
