using Microsoft.AspNetCore.Mvc;
using PruebaP5.Models;
using System.Reflection;

namespace PruebaP5.Controllers
{
    public class PagoController : Controller
    {
        public static List<Pago> pagoList = new List<Pago>();
        public IActionResult Index()
        {
         

            return View(pagoList);
        }

        
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pago pag)
        {
            try
            {
                pagoList.Add(pag);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


       /* public async Task<IActionResult> Details(int cuit)
        {
           

            //var pagos=  pagoList.Single(a => a.Cuit == cuit);
            var pagos2 = pagoList.Single(a => a.Cuit == cuit);
            return View(pagos2);
        }*/
    }
}
