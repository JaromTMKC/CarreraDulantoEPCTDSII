using CarreraDulantoEPCTDSII.Models.Entidades;

namespace CarreraDulantoEPCTDSII.Data.AccesoDatos
{
    public class DAArticulo
    {
        public IEnumerable<ArticuloCarrera> GetArticulo()
        {
            var ListadoArticulo = new List<ArticuloCarrera>();
            using (var db = new ApplicationDbContext())
            {
                ListadoArticulo = db.Articulo.ToList();
            }
            return ListadoArticulo;
        }
    }
}
