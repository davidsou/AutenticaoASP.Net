using AutenticaoASP.Net.Models;
using AutenticaoASP.Net.Utils;
using AutenticaoASP.Net.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace AutenticaoASP.Net.Controllers
{
    public class PerfilController : Controller
    {
        private UsuariosContext db = new UsuariosContext(); 
        // GET: Perfil
        [Authorize]
        public ActionResult AlterarSenha()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult AlterarSenha(AlterarSenhaViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            var identity = User.Identity as ClaimsIdentity;
            var login = identity.Claims.FirstOrDefault(c => c.Type == "Login").Value;

            var usuario = db.Usuarios.FirstOrDefault(u => u.Login == login);

            if (Hash.GerarHash(viewModel.SenhaAtual)!=usuario.Senha)


            {
                ModelState.AddModelError("SenhaAtual", "Senha incorreta");
                return View();
            }
            usuario.Senha = Hash.GerarHash(viewModel.NovaSenha);
            db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();


            return RedirectToAction("Index", "Painel");
        }
    }
}