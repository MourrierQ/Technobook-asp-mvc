using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technobook.Model.Global.Models;

namespace Technobook.Model.Global.Mappers
{
    public static class DBMappers
    {
        public static User ToUser(this IDataRecord data)
        {
            return new User
            {
                ID = (int)data["ID"],
                FirstName = data["FirstName"].ToString(),
                LastName = data["LastName"].ToString(),
                Email = data["Email"].ToString()
            };
        }

        public static Relation ToRelation(this IDataRecord data)
        {
            return new Relation
            {
                UserID = (int)data["UserID"],
                FriendID = (int)data["FriendID"]
            };
        }

        public static Post ToPost(this IDataRecord data)
        {
            return new Post()
            {
                ID = (int)data["ID"],
                UserID = (int)data["UserID"],
                Content = data["Content"].ToString(),
                PostDate = (DateTime)data["PostDate"]
            };
        }
    }
}
