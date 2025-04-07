using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Curso_ASP.NET.Models;

namespace Curso_ASP.NET.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Account/Register
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Lógica para registrar al usuario
                // Por ejemplo, guardar el usuario en la base de datos

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        // GET: Account/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Lógica para autenticar al usuario
                // Por ejemplo, verificar las credenciales del usuario

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}