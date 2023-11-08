using System.ComponentModel.DataAnnotations;

namespace CarreraDulantoEPCTDSII.Models.Entidades
{
    public class ArticuloCarrera
    {
        [Key]
        [Display(Name = "ID")]
        public int IdArticulo { get; set; }

        [Required]
        [Display(Name ="Nombre")]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [Display(Name ="UM")]
        [MaxLength(15)]
        public string UM { get; set; }

        [Required]
        [Display(Name ="Precio")]
        public float Precio { get; set; }

        public virtual ICollection<ValesDetCarrera> ValesDet {  get; set; }
    }
}
