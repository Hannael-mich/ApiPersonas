using DBPersonas.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DBPersonas
{
    public class BPersonas
    {
        Generacion23Entities db = new Generacion23Entities();

        public List<Personas> Obtener()
        {
            List<Personas> ls = db.Personas.ToList();
            db.Dispose();
            return ls;
        }

        public Personas ObtenerPorId(int id)
        {
            Personas p = db.Personas.Find(id);//Busqueda con llave primaria
            db.Dispose();
            return p;
        }

        public void Agregar(Personas p)
        {
            p.FechaAlta = DateTime.Now;
            db.Personas.Add(p);
            db.SaveChanges();
            db.Dispose();
        }

        public void Editar(Personas p)
        {
            Personas per = db.Personas.Find(p.Id);
            p.FechaAlta = per.FechaAlta;
            db.Personas.AddOrUpdate(p);
            db.SaveChanges();
            db.Dispose();
        }

        public void Borrar(int id)
        {
            Personas p = db.Personas.Find(id);//Busqueda con llave primaria
            db.Personas.Remove(p);
            db.SaveChanges();
            db.Dispose();
        }

        public List<Personas> Buscador(string texto)
        {
            List<Personas> ls = db.Personas.Where(x => x.Nombre == texto || x.Paterno == texto || x.Materno == texto).ToList();
            //List<Personas> ls = db.Personas.ToList(texto);
            db.Dispose();
            return ls;
        }
    }
}