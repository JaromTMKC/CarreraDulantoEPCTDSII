using CarreraDulantoEPCTDSII.Data.AccesoDatos;
using CarreraDulantoEPCTDSII.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CarreraDulantoEPCTDSII.Controllers
{
    public class ValesDetCarreraController : Controller
    {
        public string Estado(float total)
        {
            string estado = "";
            if (total > 5000)
            {
                estado = "Por Aprobación";
            }
            else
            {
                estado = "Aprobado";
            }
            return estado;
        }
        public IActionResult ListadoVCarrera()
        {
            var Listado = new DAValesDet();
            var model = Listado.GetValesDet();
            return View(model);
        }

        public IActionResult Create()
        {
            var LCab = new DAValesCab();
            ViewBag.LCab = LCab.GetValesCab();

            var LArticulo = new DAArticulo();
            ViewBag.LArticulo = LArticulo.GetArticulo();

            return View();
        }

        [HttpPost]
        public IActionResult Create(ValesDetCarrera Entity)
        {
            Entity.IdValesDet = 0;
            Entity.Total = (Entity.Cantidad * Entity.Precio);

            var InsertValesDet = new DAValesDet();
            var model = InsertValesDet.InsertValesDet(Entity);

            if (model > 0)
            {
                return RedirectToAction("ListadoVCarrera");
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Detail(int id)
        {
            var LCab = new DAValesCab();
            ViewBag.LCab = LCab.GetValesCab();

            var LArticulo = new DAArticulo();
            ViewBag.LArticulo = LArticulo.GetArticulo();

            var DetailValesDet = new DAValesDet();
            var model = DetailValesDet.DetailValesDet(id);

            if (model != null)
            {
                return View(model);
            }
            else
            {
                return RedirectToAction("ListadoVCarrera");
            }
        }

        public IActionResult Edit(int id)
        {
            var ValesDet = new DAValesDet().DetailValesDet(id);

            if (ValesDet == null)
            {
                return RedirectToAction("ListadoVCarrera");
            }

            var LCab = new DAValesCab();
            ViewBag.LCab = LCab.GetValesCab();

            var LArticulo = new DAArticulo();
            ViewBag.LArticulo = LArticulo.GetArticulo();

            return View(ValesDet);
        }

        [HttpPost]
        public IActionResult Edit(ValesDetCarrera Entity)
        {

            Entity.Total = (Entity.Cantidad * Entity.Precio);

            var EditValesDet = new DAValesDet();
            var model = EditValesDet.EditValesDet(Entity);

            if (model > 0)
            {
                return RedirectToAction("ListadoVCarrera");
            }
            else
            {
                return View(model);
            }

        }

        public IActionResult Delete(int id)
        {
            var ValesDet = new DAValesDet().DetailValesDet(id);

            if (ValesDet == null)
            {
                return RedirectToAction("ListadoVCarrera");
            }

            return View(ValesDet);
        }


        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            var resultado = new DAValesDet().DeleteValesDet(id);

            if (resultado > 0)
            {
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false });
            }
        }
    }
}
