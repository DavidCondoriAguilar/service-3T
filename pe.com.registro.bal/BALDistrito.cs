using pe.com.registro.bo;
using pe.com.registro.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.registro.bal
{
    public class BALDistrito
    {

        DALDistrito dal = new DALDistrito();


        public List<BODistrito> MostrarDistrito()
        {
            return dal.MostrarDistritos();
        }

        public bool RegistrarDistrito(BODistrito bc)
        {
            return dal.RegistrarDistrito(bc);
        }
        public bool ActualizarDistrito(BODistrito bc)
        {
            return dal.ActualizarDistrito(bc);
        }
        public bool EliminarDistrito(int codigodistrito)
        {
            return dal.EliminarDistrito(codigodistrito);
        }

    }
}
