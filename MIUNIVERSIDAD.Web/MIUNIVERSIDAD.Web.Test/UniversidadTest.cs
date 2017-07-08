using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIUNIVERSIDAD.Web.ViewModel;
using MIUNIVERSIDAD.Web.Models;
namespace MIUNIVERSIDAD.Web.MIUNIVERSIDAD.Web.Test
{
    [TestFixture]
    public class UniversidadTest
    {
        /*[Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }
        //RegionController
        [Test]
        public void CargarDatosTest()
        {
            // TODO: Add your test code here
            AddEditUniversidadViewModel objViewModel = new AddEditUniversidadViewModel();
            objViewModel.CargarDatos(null);
            Assert.False(objViewModel.valor);
            
        }
        [Test]
        public void UniversidadExisteTest()
        {
            // TODO: Add your test code here
            AddEditUniversidadViewModel objViewModel = new AddEditUniversidadViewModel();
            Assert.True(objViewModel.UniversidadExiste("universidad peruana de ciencias aplicadas"));

        }
        [Test]
        public void UniversidadExisteAlternativoTest()
        {
            // TODO: Add your test code here
            AddEditUniversidadViewModel objViewModel = new AddEditUniversidadViewModel();
            Assert.False(objViewModel.UniversidadExiste("melany"));

        }
        [Test]
        public void RegistrarUniversidadTest()
        {
            LstUniversidadFiltroViewModel lista = new LstUniversidadFiltroViewModel();
            lista.CargarDatos("");
            int IdUniversidad = lista.ListUniversidadFiltro[lista.ListUniversidadFiltro.Count - 1].iduniversidad + 1;
            Universidad objUniversidad = new Universidad();

            objUniversidad.iduniversidad = IdUniversidad;
            objUniversidad.nombreuniversidad = "universidad prueba";
            objUniversidad.nombrecomercial = "up";
            objUniversidad.tipouniversidad = "Estatal";
            objUniversidad.ruc = "15457";
            objUniversidad.direccion ="Av. Lugar";
            objUniversidad.localizacion = "Rural";
            objUniversidad.estado = "ACT";
         
            AddEditUniversidadViewModel objViewModel = new AddEditUniversidadViewModel();
            objViewModel.RegistrarUniversidad(objUniversidad);
            Assert.True(!"0".Equals(objUniversidad.nombreuniversidad));
        }

        [Test]
        public void ModificarUniversidadTest()
        {
            LstUniversidadFiltroViewModel lista = new LstUniversidadFiltroViewModel();
            Universidad objUniversidad = new Universidad();
            lista.CargarDatos("");
            int IdUniversidad = lista.ListUniversidadFiltro[lista.ListUniversidadFiltro.Count - 1].iduniversidad;
            objUniversidad.iduniversidad = IdUniversidad;
            objUniversidad.nombreuniversidad = "universidad Prueba";
            objUniversidad.nombrecomercial = "up";
            objUniversidad.tipouniversidad = "Estatal";
            objUniversidad.ruc = "15457";
            objUniversidad.direccion = "Av. Lugar";
            objUniversidad.localizacion = "Rural";
            objUniversidad.estado = "ACT";

            AddEditUniversidadViewModel objViewModel = new AddEditUniversidadViewModel();
            objViewModel.ModificarUniversidad(objUniversidad);
            Assert.True(objUniversidad.nombreuniversidad.Equals("universidad Prueba"));
        }
        [Test]
        public void EliminarDocente()
        {
            LstUniversidadFiltroViewModel lista = new LstUniversidadFiltroViewModel();
            lista.CargarDatos("");
            int IdUniversidad = lista.ListUniversidadFiltro[lista.ListUniversidadFiltro.Count - 1].iduniversidad;
            Universidad objUniversidad = new Universidad();
            objUniversidad.iduniversidad = IdUniversidad;
            DeleteUniversidadViewModel objViewModel = new DeleteUniversidadViewModel();
            objViewModel.CargarDatos(objUniversidad.iduniversidad);
            Assert.True(true);
        }*/
    }
}
