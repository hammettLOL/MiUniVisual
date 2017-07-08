using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIUNIVERSIDAD.Web.Models;
using System.Web.Mvc;

namespace MIUNIVERSIDAD.Web.ViewModel
{
    public class LoginViewModel
    {
        public String nombre { get; set; }
        public String password { get; set; }
        public Int32 idusuario { get; set; }
        public LoginViewModel()
        {

        }
        [HttpPost]
        public Int32 Tipo_Trabajador(String nombre, String Password)
        {
            MiUniversidadEntities context = new MiUniversidadEntities();

            var query = context.Usuario.FirstOrDefault(x =>
                 x.nombre == nombre &&
                 x.password == password);
            return query.idusuario;
        }
    }
}