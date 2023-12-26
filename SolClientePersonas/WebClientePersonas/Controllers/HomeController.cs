using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using WebClientePersonas.ServiceReference1;

namespace WebClientePersonas.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            try
            {
                using (WebServicePersonasSoapClient ws = new WebServicePersonasSoapClient())
                {
                    EntRespuesta r = ws.Obtener();
                    if (r.Error)
                    {
                        throw new Exception(r.Mensaje);
                    }
                    List<persona> ls = r.ListaPersonas.ToList();
                    return View(ls);
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View(new List<persona>());
            }
            
                
        }
        public ActionResult Agregar()
        {
            return View();
        }
        public ActionResult AgregarBD(persona p)
        {
            try
            {
                using (WebServicePersonasSoapClient ws = new WebServicePersonasSoapClient())
                {
                    EntRespuesta r = ws.Agregar(p);
                    if (r.Error)
                    {
                        throw new Exception(r.Mensaje);
                    }
                    TempData["ok"] = "Se agrego el registro";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("Agregar");
            }
        }
    }
}