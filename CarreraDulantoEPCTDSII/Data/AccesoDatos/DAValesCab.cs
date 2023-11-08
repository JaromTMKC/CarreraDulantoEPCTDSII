using CarreraDulantoEPCTDSII.Models.Entidades;

namespace CarreraDulantoEPCTDSII.Data.AccesoDatos
{
    public class DAValesCab
    {
        public IEnumerable<ValesCabCarrera> GetValesCab()
        {
            var ListadoValesCab = new List<ValesCabCarrera>();
            using (var db = new ApplicationDbContext())
            {
                ListadoValesCab = db.ValesCab.ToList();
            }
            return ListadoValesCab;
        }
    }
}
