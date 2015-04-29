using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Chat
{
    /// <summary>
    /// Descripción breve de ServicioChat
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioChat : System.Web.Services.WebService
    {

        [WebMethod]
        public string chatiar(string Mensaje)
        {
            switch (Mensaje)
            {
                case "Hola bb":  return"Hola mucho gusto";
                case "De donde eres": return "de Estados Unidos";
                case "Como estas": return "Muy buena";
                case "Como te llamas": return "Kimberly";
                case "Tienes cel": return "Si pero no se lo doy a cualquiera";
                case "Tienes web cam": return "No tengo";
                case "Quieres mostrarme": return "Que te muestre que ??";
                case "Que buscas realmente": return "Busco dinero y no es interes";
                case "Osea ke te gusta experimentar cosas nuevas": return "No jamas haga experimentos";
                case "Que tal si empezamos a subir la temperatura": return "No gracias ";
                case "Hasta donde quieres llegar": return "AQuiero llegar algun dia a Japon";
                case "Cuantos años tienes": return "15";
                case "Que te gusta hacer": return "No mucho";
                case "Y lo...": return "LUEGO QUE??";
                case "Ahorita llego a tu casa": return "Por que me estas acosando";
                default: return "Favor de Contestar";
                    
            }
        }
    }
}
