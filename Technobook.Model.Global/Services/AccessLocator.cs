using ADOToolbox;
using Patterns.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technobook.Model.Global.Services
{
    public class AccessLocator:LocatorBase
    {
        private const string CONN_STR = "Data Source=localhost;Initial Catalog=Technobook;Integrated Security=True";
        private const string PROVIDER = "System.Data.SqlClient";

        private static AccessLocator _Instance;

        public static AccessLocator Instance
        {
            get { return _Instance ?? (_Instance = new AccessLocator()); }
        }

        public AccessLocator()
        {
            Container.Register<Connection>(CONN_STR, PROVIDER);
        }

        public Connection Connection
        {
            get
            {
                return Container.GetInstance<Connection>();
            }
        }

    }
}
