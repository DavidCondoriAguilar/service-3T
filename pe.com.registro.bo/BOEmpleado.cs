using System;

namespace pe.com.registro.bo
{
    public class BOEmpleado
    {
        //public int codigo { get; set; }
        //public string nombres { get; set; }
        //public string dni { get; set; }
        public string codigoempleado { get; set; }
        public string nombreempleado { get; set; }
        public string apellidopempleado { get; set; }
        public string apellidomempleado { get; set; }
        public string documentoempleado { get; set; }
        public DateTime fechaempleado { get; set; }
        public string direccionempleado { get; set; }
        public string telefonoempleado { get; set; }
        public string celularempleado { get; set; }
        public string correoempleado { get; set; }
        public string sexoempleado { get; set; }
        public string usuarioempleado { get; set; }
        public string claveempleado { get; set; }
        public int estadoempleado { get; set; }
        public int codigorol { get; set; }
        public int codigodistrito { get; set; }
        public BODistrito distrito { get; set; }
        public BORol rol { get; set; }

        public BOEmpleado()
        {

        }

    }


}
