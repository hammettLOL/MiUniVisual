using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIUNIVERSIDAD.Web.Models;

namespace MIUNIVERSIDAD.Web.ViewModel
{
    public class DashboardViewModel
    {
        public int NroUniversidades { get; set; }

        public DashboardViewModel()
        {

        }

        public void CargarDatos()
        {
           
            MiUniversidadEntities context = new MiUniversidadEntities();
            NroUniversidades = context.Universidad.Count();

        }
    }
}