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
    public class PostRepository
    {
        public IEnumerable<Post> GetFriendsPosts(int id)
        {
            Command cmd = new Command("StP_GetFriendsPosts", true);
            cmd.AddParameter("UserID", id);

            return AccessLocator.Instance.Connection.ExecuteReader(cmd, p => p.ToPost());
        }

        public IEnumerable<Post> GetPostsFromUser(int id)
        {
            Command cmd = new Command("StP_GetPostsFromUser", true);
            cmd.AddParameter("UserID", id);

            return AccessLocator.Instance.Connection.ExecuteReader(cmd, p => p.ToPost());
        }

        public Post InsertPost(Post entity)
        {
            Command cmd = new Command("StP_InsertPost", true);
            cmd.AddParameter("UserID", entity.UserID);
            cmd.AddParameter("Content", entity.Content);

            object res = AccessLocator.Instance.Connection.ExecuteScalar(cmd);

            if(res == null)
            {
                entity.ID = (int)res;
                return entity;
            }
            return null;
        }
    }
}
