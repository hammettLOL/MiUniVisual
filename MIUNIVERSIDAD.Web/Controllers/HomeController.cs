using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MIUNIVERSIDAD.Web.ViewModel;
using MIUNIVERSIDAD.Web.Models;

namespace SEGURIDAD.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            DashboardViewModel objViewModel = new DashboardViewModel();
            objViewModel.CargarDatos();
            return View(objViewModel);
        }
        
        public ActionResult Login()
        {
            LoginViewModel objViewModel = new LoginViewModel();
            return View(objViewModel);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel objViewModel)
        {
            MiUniversidadEntities context = new MiUniversidadEntities();
           
            Usuario objUsuario = context.Usuario.FirstOrDefault(x =>
                x.nombre == objViewModel.nombre&&
                x.password == objViewModel.password);

            if (objUsuario == null)
            {
                TempData["MensajeLogin"] = "Usuario y/o contraseña incorrectos";
                TempData["Tipo"] = "ERROR";
                return View(objViewModel);
            }

            Session["objUsuario"] = objUsuario;
          
                return RedirectToAction("Dashboard", "Home");
            
           //return RedirectToAction("Dashboard", "Home"); 
        }
      
        public ActionResult CerrarSesion()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
        public ActionResult Layout()
        {
            Session.Clear();
            return RedirectToAction("Layout");
        }
    }
}