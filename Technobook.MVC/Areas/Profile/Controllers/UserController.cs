using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Technobook.Model.Client.Models;
using Technobook.Model.Client.Services;
using Technobook.MVC.Areas.Profile.Models.Forms;
using Technobook.MVC.Infrastructure.Attributes;
using Technobook.MVC.Infrastructure.Session;

namespace Technobook.MVC.Areas.Profile.Controllers
{
    [AuthRequired]
    public class UserController : Controller
    {
        // GET: Profile/User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UpdateProfile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateProfile(UpdateUserForm form)
        {
            if (ModelState.IsValid)
            {
                User UpdatedUser = new User(
                        SessionManager.User.ID, 
                        form.FirstName ?? SessionManager.User.FirstName, 
                        form.LastName ?? SessionManager.User.LastName, 
                        form.Email ?? SessionManager.User.Email, ""
                    );

                User NewUser = ClientServicesLocator.Instance.Users.UpdateUser(UpdatedUser);

                if(NewUser != null)
                {
                    SessionManager.User = NewUser;
                }

                return RedirectToAction("Index");
            }
            return RedirectToAction("UpdateProfile");
        }

        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(SearchUserForm form)
        {
            if (ModelState.IsValid)
            {
               
                    return RedirectToAction("UsersList", new { FirstName = form.FirstName, LastName = form.LastName});
              
            }
            return View();
        }

        public ActionResult UsersList(string FirstName, string LastName)
        {
            IEnumerable<User> Users = ClientServicesLocator.Instance.Users.GetUsersByName(FirstName, LastName);
            List<User> users = new List<User>();

            if (Users != null)
            {
                foreach (User u in Users)
                    users.Add(u);
                return View("UsersList", users);
            }
            return View(users);
        }

        public ActionResult GetFriendRequests()
        {
            IEnumerable<User> requests = ClientServicesLocator.Instance.Users.GetPendingRequests(SessionManager.User.ID);
            List<User> users = new List<User>();
            if(requests != null)
            {
                foreach (User u in requests)
                {
                    users.Add(u);
                }
                return View(users);
            }
            return RedirectToAction("Index");
        }

        public ActionResult SendFriendRequest(int id)
        {
            try
            {
                ClientServicesLocator.Instance.Relations.SendFriendRequest(new Relation(SessionManager.User.ID, id));
                return RedirectToAction("Search");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }
        }
    }
}