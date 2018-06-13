using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Technobook.Model.Client.Models;

namespace Technobook.MVC.Infrastructure.Session
{
    public static class SessionManager
    {
        public static User User
        {
            get
            {
                return (User)HttpContext.Current.Session["User"];
            }

            set
            {
                HttpContext.Current.Session["User"] = value;
            }
        }
    }
}