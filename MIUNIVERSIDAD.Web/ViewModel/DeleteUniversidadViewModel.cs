using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIUNIVERSIDAD.Web.Models;

namespace MIUNIVERSIDAD.Web.ViewModel
{
    public class DeleteUniversidadViewModel
    {
        public int? iduniversidad { get; set; }

        public String Estado { get; set; }
        //public List<Trabajador> LstTrabajadorACT{ get; set; }
        public DeleteUniversidadViewModel()
        {
        }

        public void CargarDatos(int? iduniversidad)
        {
            this.iduniversidad = iduniversidad;

            if (iduniversidad.HasValue)
            {
                MiUniversidadEntities context = new MiUniversidadEntities();
                Universidad objUniversidad = context.Universidad.FirstOrDefault(x =>
                                    x.iduniversidad == iduniversidad);

                //Estado = objUniversidad.estado;
                objUniversidad.estado="INA";
                context.SaveChanges();
            }
        }
    }
}