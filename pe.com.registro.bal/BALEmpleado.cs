using pe.com.registro.bo;
using pe.com.registro.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.registro.bal
{
    public class BALEmpleado
    {


        DALEmpleado dal = new DALEmpleado();


        public List<BOEmpleado> MostrarEmpleadoActivo()
        {
            return dal.MostrarEmpleadoActivo();
        }
        public List<BOEmpleado> MostrarEmpleado()
        {
            return dal.MostrarEmpleados();
        }
        public bool RegistrarEmpleado(BOEmpleado bc)
        {
            return dal.RegistrarEmpleado(bc);
        }
        public bool ActualizarEmpleado(BOEmpleado bc)
        {
            return dal.ActualizarEmpleado(bc);
        }
        public bool EliminarEmpleado(BOEmpleado bc)
        {
            return dal.EliminarEmpleado(bc);
        }
    }
}
