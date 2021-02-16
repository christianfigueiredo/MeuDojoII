using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeuDojo.Controllers
{
    public class RecepcaoController : Controller
    {
        // GET: Recepcao
        public ActionResult PreCadastro()
        {
            return View();
        }
        public ActionResult Cliente()
        {
            return View();
        }
        public ActionResult MapaDeCliente()
        {
            return View();
        }
        public ActionResult AgendaDeTurma()
        {
            return View();
        }
        public ActionResult AgendaDeServico()
        {
            return View();
        }
        public ActionResult AulaExperimental()
        {
            return View();
        }
    }
}