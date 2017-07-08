using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MIUNIVERSIDAD.Web.ViewModel;
using MIUNIVERSIDAD.Web.Models;

namespace SEGURIDAD.Web.Controllers
{
    public class RegionController : Controller
    {
        
        public ActionResult LstUniversidadFiltro(String Nombre)
        {
            LstUniversidadFiltroViewModel objViewModel = new LstUniversidadFiltroViewModel();
            objViewModel.CargarDatos(Nombre);
            return View(objViewModel);
        }

        public ActionResult AddEditUniversidad(int? iduniversidad)
        {
            AddEditUniversidadViewModel objViewModel = new AddEditUniversidadViewModel();
            objViewModel.CargarDatos(iduniversidad);
            return View(objViewModel);
        }


        /*public ActionResult DeleteUniversidad(int? iduniversidad)
        {
            DeleteUniversidadViewModel objViewModel = new DeleteUniversidadViewModel();
            objViewModel.CargarDatos(iduniversidad);
            return View(objViewModel);
        }*/

        [HttpPost]
        public ActionResult AddEditUniversidad(AddEditUniversidadViewModel objViewModel)
        {
            MiUniversidadEntities context = new MiUniversidadEntities();
            Universidad objUniversidad = new Universidad();
            try
            {
                if (objViewModel.iduniversidad.HasValue)
                {
                    objUniversidad = context.Universidad.FirstOrDefault(x => x.iduniversidad ==
                                                                objViewModel.iduniversidad);
                }
                else
                {
                    objUniversidad.estado = "ACT";
                    context.Universidad.Add(objUniversidad);
                }

                objUniversidad.nombreuniversidad = objViewModel.nombreuniversidad;
                objUniversidad.nombrecomercial = objViewModel.nombrecomercial;
                objUniversidad.tipouniversidad = objViewModel.tipouniversidad;
                objUniversidad.ruc = objViewModel.ruc;
                objUniversidad.direccion = objViewModel.direccion;
                objUniversidad.localizacion = objViewModel.localizacion;
                context.SaveChanges();
                return RedirectToAction("LstUniversidadFiltro");
                // return RedirectToAction("LstUniversidad");
            }
            catch (Exception e)
            {
                TempData["MensajeError"] = "No se llenaron los campos correctamente " + e.Message.ToList();
                TempData["Tipo"] = "ERROR";
                return View(objViewModel);
                //return RedirectToAction("LstUniversidadFiltro");
            }
        }
        /* [HttpPost]
         public ActionResult DeleteUniversidad(DeleteUniversidadViewModel objViewModel)
         {

              //return RedirectToAction("DeleteUnivesidad");
             return RedirectToAction("LstUniversidad");
         }

         /* [HttpPost]
          public ActionResult DeleteUniversidad(DeleteUniversidadViewModel objViewModel)
          {
              MiUniversidadEntities context = new MiUniversidadEntities();
              Universidad objTrabajador = new Universidad();

              if (objViewModel.iduniversidad.HasValue)
              {
                  objTrabajador = context.Universidad.FirstOrDefault(x => x.iduniversidad ==
                                                              objViewModel.iduniversidad);
              }

              objTrabajador.estado = "INA";
              context.SaveChanges();
              return RedirectToAction("LstUniversidad");
          }*/
        //[Authorize]
        public ActionResult DeleteUniversidad(int? iduniversidad)
        {
            DeleteUniversidadViewModel objViewModel = new DeleteUniversidadViewModel();
            try
            {
                // objViewModel.(docenteid);
                //MiUniversidadEntities context = new MiUniversidadEntities();
                //Universidad objTrabajador = new Universidad();
                //if (objViewModel.iduniversidad.HasValue)
                //{
                //    objTrabajador = context.Universidad.FirstOrDefault(x => x.iduniversidad ==
                //                                                objViewModel.iduniversidad);
                //}
                objViewModel.CargarDatos(iduniversidad);
                //objTrabajador.estado = "INA";
                //context.SaveChanges();
                //TempData["Mensaje"] = "La universidad se se eliminó satisfactoriamente";

                 return RedirectToAction("LstUniversidadFiltro");
                //return RedirectToAction("LstUniversidad");
            }
            catch (Exception e)
            {
                TempData["MensajeError"] = "Error! " + e.Message.ToList();
               return RedirectToAction("LstUniversidadFiltro");
                //return RedirectToAction("LstUniversidad");
            }

        }

    }
}