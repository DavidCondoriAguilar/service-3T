using pe.com.registro.bal;
using pe.com.registro.bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace pe.com.registro.ws
{
    /// <summary>
    /// Descripción breve de RegistroWebServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class RegistroWebServices : System.Web.Services.WebService
    {

        BALDistrito baldist = new BALDistrito();
        BALEmpleado balemp = new BALEmpleado();
        BALRol balrol = new BALRol();



        [WebMethod]
        public List<BOEmpleado> MostrarEmpleado()
        {
            List<BOEmpleado> categorias = balemp.MostrarEmpleado().ToList();
            return categorias;
        }

        [WebMethod]
        public List<BOEmpleado> MostrarEmpleadoActivo()
        {
            List<BOEmpleado> categorias = balemp.MostrarEmpleadoActivo().ToList();
            return categorias;
        }

        [WebMethod]
        public bool RegistrarEmpleado( BOEmpleado bc )
        {
            return balemp.RegistrarEmpleado(bc);
        }

        [WebMethod]
        public bool ActualizarEmpleado(BOEmpleado bc)
        {
            return balemp.ActualizarEmpleado(bc);
        }

        [WebMethod]
        public bool EliminarEmpleado(BOEmpleado bc)
        {
            return balemp.EliminarEmpleado(bc);
        }

        [WebMethod]
        public List<BODistrito> MostrarDistrito()
        {
            List<BODistrito> categorias = baldist.MostrarDistrito().ToList();
            return categorias;
        }

        [WebMethod]
        public bool RegistrarDistrito(BODistrito bc)
        {
            return baldist.RegistrarDistrito(bc);
        }

        [WebMethod]
        public bool ActualizarDistrito(BODistrito bc)
        {
            return baldist.ActualizarDistrito(bc);
        }

        [WebMethod]
        public bool EliminarDistrito(int codigodistrito)
        {
            return baldist.EliminarDistrito(codigodistrito);
        }

        [WebMethod]
        public List<BORol> MostrarRol()
        {
            List<BORol> categorias = balrol.MostrarRol().ToList();
            return categorias;
        }

        [WebMethod]
        public bool RegistrarRol(BORol bc)
        {
            return balrol.RegistrarRoll(bc);
        }

        [WebMethod]
        public bool ActualizarRol(BORol bc)
        {
            return balrol.ActualizarRol(bc);
        }

        [WebMethod]
        public bool EliminarRol(int codigodistrito)
        {
            return balrol.EliminarRol(codigodistrito);
        }
    }
}
