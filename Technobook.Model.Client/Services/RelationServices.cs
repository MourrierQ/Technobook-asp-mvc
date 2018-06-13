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
    public class RelationServices
    {
    
        public int SendFriendRequest(Relation entity)
        {
            return GlobalServicesLocator.Instance.Relations.SendFriendRequest(entity.ToGlobal());
        }

        public void AnswerFriendRequest(Relation entity)
        {
             GlobalServicesLocator.Instance.Relations.AnswerFriendRequest(entity.ToGlobal());
        }
    }
}
