using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using TiDev.Bussines.Personas;
using TiDev.Entity.Personas;

namespace WebService
{
    /// <summary>
    /// Descripción breve de WsPersonas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WsPersonas : System.Web.Services.WebService
    {
        BusPersonas comando = new BusPersonas();

        [WebMethod]
        public List<EntPersona> Obtener()
        {
            List<EntPersona> ls = new List<EntPersona>();
            ls = comando.Obtener();
            return ls;
        }

        [WebMethod]
        public EntPersona ObtenerId(int id)
        {
            EntPersona persona = new EntPersona();
            persona = comando.Obtener(id);
            return persona;
        }

        [WebMethod]
        public List<EntPersona> ObtenerNombre(String nombre)
        {
            List<EntPersona> persona = new List<EntPersona>();
            persona = comando.Obtener(nombre);
            return persona;
        }

        [WebMethod]
        public void Create(EntPersona p)
        {
            comando.Create(p);
        }

        [WebMethod]
        public void Edit(EntPersona p)
        {
            comando.Edit(p);
        }

        [WebMethod]
        public void Delete(EntPersona p)
        {
            comando.Delete(p);
        }

    }
}
