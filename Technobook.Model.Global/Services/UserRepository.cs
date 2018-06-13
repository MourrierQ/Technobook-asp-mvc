using ADOToolbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technobook.Model.Global.Mappers;
using Technobook.Model.Global.Models;

namespace Technobook.Model.Global.Services
{
    public class UserRepository
    {


        public int Register(User entity)
        {
            Command cmd = new Command("StP_Register", true);
            cmd.AddParameter("FirstName", entity.FirstName);
            cmd.AddParameter("LastName", entity.LastName);
            cmd.AddParameter("Email", entity.Email);
            cmd.AddParameter("Password", entity.Password);

            return (int)AccessLocator.Instance.Connection.ExecuteScalar(cmd);
        }

        public User Login(User entity)
        {
            Command cmd = new Command("StP_Login", true);
            cmd.AddParameter("Email", entity.Email);
            cmd.AddParameter("Password", entity.Password);
            User res = AccessLocator.Instance.Connection.ExecuteReader(cmd, u => u.ToUser()).SingleOrDefault();
 
            return res;
        }

        public IEnumerable<User> GetUsersbyName(string FirstName, string LastName)
        {
            Command cmd = new Command("StP_SearchUserByName", true);
            cmd.AddParameter("FirstName", FirstName);
            cmd.AddParameter("LastName", LastName);

            return AccessLocator.Instance.Connection.ExecuteReader(cmd, u => u.ToUser());
        }

        public IEnumerable<User> GetPendingRequests(int id)
        {
            Command cmd = new Command("StP_GetFriendRequests", true);
            cmd.AddParameter("UserID", id);

            return AccessLocator.Instance.Connection.ExecuteReader(cmd, u => u.ToUser());
        }

        public IEnumerable<User> GetFriends(int id)
        {
            Command cmd = new Command("StP_GetFriends", true);
            cmd.AddParameter("UserID", id);

            return AccessLocator.Instance.Connection.ExecuteReader(cmd, u => u.ToUser());
        }

        public User UpdateUser(User entity)
        {
            Command cmd = new Command("StP_UpdateUser", true);
            cmd.AddParameter("ID", entity.ID);
            cmd.AddParameter("FirstName", entity.FirstName);
            cmd.AddParameter("LastName", entity.LastName);
            cmd.AddParameter("Email", entity.Email);

            return AccessLocator.Instance.Connection.ExecuteReader(cmd, u => u.ToUser()).SingleOrDefault();
        }
        
    }
}
