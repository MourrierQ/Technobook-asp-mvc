using Patterns.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technobook.Model.Client.Services
{
    public class ClientServicesLocator:LocatorBase
    {
        private static ClientServicesLocator _Instance;

        public static ClientServicesLocator Instance
        {
            get { return _Instance ?? (_Instance = new ClientServicesLocator()); }
        }

        public ClientServicesLocator()
        {
            Container.Register<UserServices>();
            Container.Register<RelationServices>();
            Container.Register<PostServices>();
        }

        public UserServices Users
        {
            get
            {
                return Container.GetInstance<UserServices>();
            }
        }

        public RelationServices Relations
        {
            get
            {
                return Container.GetInstance<RelationServices>();
            }
        }

        public PostServices Posts
        {
            get
            {
                return Container.GetInstance<PostServices>();
            }
        }
    }
}
