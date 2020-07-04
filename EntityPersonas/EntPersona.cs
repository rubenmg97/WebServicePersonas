using System;
using System.Collections.Generic;
using System.Text;

namespace TiDev.Entity.Personas
{
    public class EntPersona
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Paterno { get; set; }
        public String Materno { get; set; }
        public Boolean Sexo { get; set; }
        public DateTime Nacimiento { get; set; }
        public DateTime Alta { get; set; }
        public int Edad { get; set; }

        private String nombreCompleto;
        public String NombreCompleto
        {
            get
            {
                nombreCompleto = Nombre + " " + Paterno + " " + Materno;
                return nombreCompleto;
            }
        }

    }
}
