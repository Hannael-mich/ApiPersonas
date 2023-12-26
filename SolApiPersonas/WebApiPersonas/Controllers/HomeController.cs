using DBPersonas.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace WebApiPersonas.Controllers
{
    public class HomeController : Controller
    {
        //MVC El cliente
        public ActionResult Index()
        {
            List<Personas> ls = new List<Personas>();
            using (HttpClient clienteHttp = new HttpClient())
            {
                clienteHttp.BaseAddress = new Uri("http://localhost:54882/");
                var request = clienteHttp.GetAsync("api/Values").Result;

                if (request.IsSuccessStatusCode)
                {
                    string resultado = request.Content.ReadAsStringAsync().Result;

                    ls = JsonConvert.DeserializeObject<List<Personas>>(resultado);

                    return View(ls);
                }
                else
                {
                    TempData["error"] = "Error de comunicacion con el Api";
                    return View(new List<Personas>());
                }
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Personas p)
        {
            using (HttpClient cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("http://localhost:54882/");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //cuando se utiliza https
                var respuesta = cliente.PostAsJsonAsync("api/Values",p).Result;

                if (respuesta.IsSuccessStatusCode)
                {
                    TempData["msj"] = "Se agrego";
                    return RedirectToAction("Index");
                }
            }

            return View();
        }

        public ActionResult Edit(int id)
        {
            Personas p = new Personas();
            using (HttpClient clienteHttp = new HttpClient())
            {
                clienteHttp.BaseAddress = new Uri("http://localhost:54882/");
                var request = clienteHttp.GetAsync("api/Values/"+id).Result;

                if (request.IsSuccessStatusCode)
                {
                    string resultado = request.Content.ReadAsStringAsync().Result;

                    p = JsonConvert.DeserializeObject<Personas>(resultado);

                    return View(p);
                }
                else
                {
                    TempData["error"] = "Error de comunicacion con el Api";
                    return View(new Personas());
                }
            }
        }

        [HttpPost]
        public ActionResult Edit(Personas p)
        {
            using (HttpClient cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("http://localhost:54882/");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //cuando se utiliza https
                var respuesta = cliente.PutAsJsonAsync("api/Values", p).Result;

                if (respuesta.IsSuccessStatusCode)
                {
                    TempData["msj"] = "Se edito";
                    return RedirectToAction("Index");
                }
            }

            return View();
        }

        public ActionResult BucadorR(string texto)
        {
            List<Personas> lista = new List<Personas>();
            using (HttpClient cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("http://localhost:54882/");
                var respuesta = cliente.PostAsJsonAsync($"api/Values?texto={texto}", texto).Result;
                if (respuesta.IsSuccessStatusCode)
                {
                    string resultado = respuesta.Content.ReadAsStringAsync().Result;
                    lista = JsonConvert.DeserializeObject<List<Personas>>(resultado);
                    return View("Index", lista);
                }
                else
                {
                    TempData["error"] = "Error de comunicacion con la api";
                    return RedirectToAction("Index");
                }
            }
        }
    }
}
