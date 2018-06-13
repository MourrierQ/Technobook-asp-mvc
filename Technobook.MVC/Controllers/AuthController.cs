using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Technobook.Model.Client.Models;
using Technobook.Model.Client.Services;
using Technobook.MVC.Infrastructure.Forms;
using Technobook.MVC.Infrastructure.Session;

namespace Technobook.MVC.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterForm form)
        {
            if (ModelState.IsValid)
            {
                User u = new User(0, form.FirstName, form.LastName, form.Email, form.Password);
                if (ClientServicesLocator.Instance.Users.Register(u) != 0)
                {
                    return RedirectToAction("Login");
                }
            }

            return RedirectToAction("Index", "Home");
        }

        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginForm form)
        {
            if (ModelState.IsValid)
            {
                User u = new User(form.Email, form.Password);
                User res = ClientServicesLocator.Instance.Users.Login(u);
                if (res != null)
                {
                    SessionManager.User = res;
                    return RedirectToAction("Index", "User", new { area="Profile"});
                }
            }

            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}