using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIUNIVERSIDAD.Web.Models;
using System.ComponentModel.DataAnnotations;
namespace MIUNIVERSIDAD.Web.ViewModel
{
    public class AddEditUniversidadViewModel
    {
        public Universidad objUniversidad { get; set; }
        public int? iduniversidad { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "No se han llenado los campos de manera correcta")]
        public String nombreuniversidad { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "No se han llenado los campos de manera correcta")]
        public String nombrecomercial { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "No se han llenado los campos de manera correcta")]
        public String tipouniversidad { get; set; }
        [DataType(DataType.PostalCode)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "No se han llenado los campos de manera correcta")]
        public String ruc { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "No se han llenado los campos de manera correcta")]
        public String direccion { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "No se han llenado los campos de manera correcta")]
        public String localizacion { get; set; }

        public String estado { get; set; }
        public bool valor { get; set; }
        public AddEditUniversidadViewModel()
        {
        }

        public void CargarDatos(int? iduniversidad)
        {
            this.iduniversidad = iduniversidad;
            this.valor = false;
            if (iduniversidad.HasValue)
            {
                MiUniversidadEntities context = new MiUniversidadEntities();
                Universidad objUniversidad = context.Universidad.FirstOrDefault(x =>
                                    x.iduniversidad == iduniversidad);
                this.nombreuniversidad = objUniversidad.nombreuniversidad;
                this.nombrecomercial = objUniversidad.nombrecomercial;
                this.tipouniversidad = objUniversidad.tipouniversidad;
                this.ruc = objUniversidad.ruc;
                this.direccion = objUniversidad.direccion;
                this.localizacion = objUniversidad.localizacion;
                this.valor = true;
                //Estado = objTrabajador.Estado;
            }
        }
        public bool UniversidadExiste(string _nombres)
        {
            MiUniversidadEntities context = new MiUniversidadEntities();
            Universidad objUniversidad = context.Universidad.FirstOrDefault(x => x.nombreuniversidad == _nombres);
            if (objUniversidad != null) return true;
            return false;
        }
        public void RegistrarUniversidad(Universidad objUniversidad)
        {
            MiUniversidadEntities context = new MiUniversidadEntities();
            objUniversidad.estado = "ACT";
            context.Universidad.Add(objUniversidad);
            context.SaveChanges();
        }
        public void ModificarUniversidad(Universidad _objUniversidad)
        {
            MiUniversidadEntities context = new MiUniversidadEntities();
            Universidad objUniversidad = context.Universidad.FirstOrDefault(x => x.iduniversidad == _objUniversidad.iduniversidad);

            objUniversidad.nombreuniversidad = _objUniversidad.nombreuniversidad;
            objUniversidad.nombrecomercial = _objUniversidad.nombrecomercial;
            objUniversidad.tipouniversidad = _objUniversidad.tipouniversidad;
            objUniversidad.ruc = _objUniversidad.ruc;
            objUniversidad.direccion = _objUniversidad.direccion;
            objUniversidad.localizacion = _objUniversidad.localizacion;
            context.SaveChanges();

        }
    }
}