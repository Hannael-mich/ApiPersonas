using DBPersonas;
using DBPersonas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace WebApiPersonas.Controllers
{
    public class ValuesController : ApiController
    {
        //Servicio API

        BPersonas bus = new BPersonas();

        // GET api/values Obtener Informacion
        [HttpGet]
        public List<Personas>Obtener()
        {
            List<Personas> ls = bus.Obtener();
            return ls;
        }

        // GET api/values/5 Obtener Informacion
        public Personas Get(int id)
        {
            Personas p = bus.ObtenerPorId(id);
            return p;
        }

        // POST api/values Agregar 
        public void Post(Personas p)
        {
            bus.Agregar(p);
        }

        // PUT api/values/5 Editar 
        public void Put(Personas p)
        {
            bus.Editar(p);
        }

        // DELETE api/values/5 Borrar
        public void Delete(int id)
        {
            bus.Borrar(id);
        }

        public List<Personas> Post(string texto)
        {
            List<Personas> p = bus.Buscador(texto);
            return p;
        }
    }
}
