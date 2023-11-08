using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarreraDulantoEPCTDSII.Models.Entidades
{
    public class ValesDetCarrera
    {
        [Key]
        [Display(Name ="ID")]
        public int IdValesDet { get; set; }

        [Required]
        [Display(Name ="Cantidad")]
        public float Cantidad { get; set; }

        [Required]
        [Display(Name = "Precio")]
        public float Precio { get; set; }

        [Required]
        [Display(Name ="Total")]
        public float Total { get; set; }

        public int IdvalesCab {  get; set; }
        [ForeignKey("IdvalesCab")]
        public virtual ValesCabCarrera ValesCab { get; set; }

        public int IdArticulo {  get; set; }
        [ForeignKey("IdArticulo")]
        public virtual ArticuloCarrera Articulo {  get; set; }
    }
}
