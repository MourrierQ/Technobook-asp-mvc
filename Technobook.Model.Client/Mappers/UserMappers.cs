using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Technobook.Model.Client.Models;
using G = Technobook.Model.Global.Models;

namespace Technobook.Model.Client.Mappers
{
    public static class UserMappers
    {
        public static C.User ToClient(this G.User u)
        {
            return new C.User(u.ID, u.FirstName, u.LastName, u.Email, "");
        }

        public static G.User ToGlobal(this C.User u)
        {
            return new G.User
            {
                ID = u.ID,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                Password = u.Password
            };
        }
    }
}
