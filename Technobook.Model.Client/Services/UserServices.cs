using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technobook.Model.Client.Mappers;
using Technobook.Model.Client.Models;
using Technobook.Model.Global.Services;

namespace Technobook.Model.Client.Services
{
    public class UserServices
    {
        public int Register(User entity)
        {
           return GlobalServicesLocator.Instance.Users.Register(entity.ToGlobal());
        }

        public User Login(User entity)
        {
            return GlobalServicesLocator.Instance.Users.Login(entity.ToGlobal()).ToClient();
        }

        public IEnumerable<User> GetUsersByName(string FirstName, string LastName)
        {
            return GlobalServicesLocator.Instance.Users.GetUsersbyName(FirstName, LastName).Select(u => u.ToClient());
        }

        public IEnumerable<User> GetPendingRequests(int id)
        {
            return GlobalServicesLocator.Instance.Users.GetPendingRequests(id).Select(r => r.ToClient());
        }


        public IEnumerable<User> GetFriends(int id)
        {
            return GlobalServicesLocator.Instance.Users.GetFriends(id).Select(u => u.ToClient());
        }

        public User UpdateUser(User entity)
        {
            return GlobalServicesLocator.Instance.Users.UpdateUser(entity.ToGlobal()).ToClient();
        }
    }
}
