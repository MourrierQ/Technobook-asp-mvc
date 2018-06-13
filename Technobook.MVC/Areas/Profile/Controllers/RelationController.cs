using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Technobook.Model.Client.Models;
using Technobook.Model.Client.Services;
using Technobook.MVC.Infrastructure.Attributes;
using Technobook.MVC.Infrastructure.Session;

namespace Technobook.MVC.Areas.Profile.Controllers
{
    public class RelationController : Controller
    {
        // GET: Profile/Relation
        [AuthRequired]
        public ActionResult GetPendingRequestsCount()
        {
            ViewBag.Count = ClientServicesLocator.Instance.Users.GetPendingRequests(SessionManager.User.ID).Count().ToString();
            return PartialView();
        }

        public ActionResult AnswerRequest(int UserID, bool Answer)
        {
            ClientServicesLocator.Instance.Relations.AnswerFriendRequest(new Relation(UserID, SessionManager.User.ID, Answer));
            return RedirectToAction("GetFriendRequests", "User");
        }
    }
}