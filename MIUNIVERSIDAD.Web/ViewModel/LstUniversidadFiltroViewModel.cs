using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIUNIVERSIDAD.Web.Models;

namespace MIUNIVERSIDAD.Web.ViewModel
{
    public class LstUniversidadFiltroViewModel
    {
        public String Nombre { get; set; }
        public List<Universidad> ListUniversidadFiltro { get; set; }

        public LstUniversidadFiltroViewModel()
        {

        }

        public void CargarDatos(String Nombre)
        {
            MiUniversidadEntities context = new MiUniversidadEntities();
            var query = context.Universidad.AsQueryable();
            this.Nombre = Nombre;
            if (!String.IsNullOrEmpty(Nombre))
                query = query.Where(x => x.nombreuniversidad.Contains(Nombre));

            ListUniversidadFiltro = query.Where(x => x.estado == "ACT").ToList();

        }
    }
}