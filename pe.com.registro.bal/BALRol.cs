using pe.com.registro.bo;
using pe.com.registro.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.registro.bal
{
    public class BALRol
    {
        DALRol dal = new DALRol();


        public List<BORol> MostrarRol()
        {
            return dal.MostrarRoles();
        }

        public bool RegistrarRoll(BORol bc)
        {
            return dal.RegistrarRol(bc);
        }
        public bool ActualizarRol(BORol bc)
        {
            return dal.ActualizarRol(bc);
        }
        public bool EliminarRol(int codigodistrito)
        {
            return dal.EliminarRol(codigodistrito);
        }

    }
}
