using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mapChallenge.Controllers
{
    public class MapController : Controller
    {
        public ActionResult Mapa()
        {
            ViewBag.Locais = new Business.Local().ListarTodos();
            return View();
        }

        public ActionResult Registrados()
        {
            ViewBag.Locais = new Business.Local().ListarTodos();
            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public void CriarLocal()
        {
            try
            {
                var local = new Business.Local();
                local.nomeLocal = Request["txtNome"];
                local.logradouro = Request["txtRua"];
                local.cidade = Request["txtCidade"];
                local.estado = Request["txtEstado"];
                string testeLat = Request["txtLatitude"];
                string testeLon = Request["txtLongitude"];
                local.latitude = Request["txtLatitude"];
                local.longitude = Request["txtLongitude"];
                local.Salvar();

                Response.Redirect("/mapa/registrados");
                TempData["contaCriada"] = "Conta criada com sucesso! Agora você já pode fazer seu login abaixo.";
            }
            catch (Exception erro)
            {
                TempData["contaNaoCriada"] = "A conta não pode ser criada (" + erro.Message + ")!";
            }
        }
    }
}