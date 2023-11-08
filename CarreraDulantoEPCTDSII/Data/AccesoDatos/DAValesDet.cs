using CarreraDulantoEPCTDSII.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CarreraDulantoEPCTDSII.Data.AccesoDatos
{
    public class DAValesDet
    {
        public IEnumerable<ValesDetCarrera> GetValesDet()
        {
            var Listado = new List<ValesDetCarrera>();
            using (var db = new ApplicationDbContext())
            {
                Listado = db.ValesDet.Include(item => item.ValesCab).Include(item => item.Articulo).ToList();
            }
            return Listado;
        }

        public int InsertValesDet(ValesDetCarrera Entidad)
        {
            var resultado = 0;
            using (var db = new ApplicationDbContext())
            {
                db.Add(Entidad);
                db.SaveChanges();
                resultado = Entidad.IdValesDet;
            }
            return resultado;
        }

        public ValesDetCarrera DetailValesDet(int id)
        {
            var resultado = new ValesDetCarrera();
            using (var db = new ApplicationDbContext())
            {
                resultado = db.ValesDet.Where(item => item.IdValesDet == id).FirstOrDefault();
            }
            return resultado;
        }

        public int EditValesDet(ValesDetCarrera Entidad)
        {
            var resultado = 0;
            using (var db = new ApplicationDbContext())
            {
                db.ValesDet.Attach(Entidad);
                db.Entry(Entidad).State = EntityState.Modified;
                db.SaveChanges();
                resultado = Entidad.IdValesDet;
            }
            return resultado;
        }

        public int DeleteValesDet(int id)
        {
            var resultado = 0;
            using (var db = new ApplicationDbContext())
            {
                var valesDet = db.ValesDet.Find(id);

                if (valesDet != null)
                {
                    db.ValesDet.Remove(valesDet);
                    db.SaveChanges();
                    resultado = valesDet.IdValesDet;
                }
            }
            return resultado;
        }
    }
}
