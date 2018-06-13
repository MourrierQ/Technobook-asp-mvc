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
    public class RelationRepository
    {
        

        public int SendFriendRequest(Relation entity)
        {
            Command cmd = new Command("StP_SendFriendRequest", true);
            cmd.AddParameter("UserID", entity.UserID);
            cmd.AddParameter("FriendID", entity.FriendID);

            return (int)AccessLocator.Instance.Connection.ExecuteScalar(cmd);
        }

        public void AnswerFriendRequest(Relation entity)
        {
            Command cmd = new Command("StP_AnswerFriendRequest", true);
            cmd.AddParameter("UserID", entity.UserID);
            cmd.AddParameter("FriendID", entity.FriendID);
            cmd.AddParameter("Answer", entity.Accepted);
            

            AccessLocator.Instance.Connection.ExecuteScalar(cmd);
        }
    }
}
