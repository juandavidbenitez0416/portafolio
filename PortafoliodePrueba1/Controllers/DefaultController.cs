using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortafoliodePrueba1.Controllers
{
    public class DefaultController : Controller
    {
        private TablaDato tabladato = new TablaDato();
        
        public int Index()
        {
            return tabladato.Conteo();
        }
    }
}