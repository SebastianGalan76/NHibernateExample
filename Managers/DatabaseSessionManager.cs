using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateExample.Managers {
    internal class DatabaseSessionManager {
        private static ISessionFactory mSessionFactory;

        public static ISessionFactory SessionFactory {
            get {
                if(mSessionFactory == null) {
                    var configuration = new Configuration();
                    configuration.Configure();
                    mSessionFactory = configuration.BuildSessionFactory();
                }
                return mSessionFactory;
            }
        }

        public static ISession OpenSession() {
            return SessionFactory.OpenSession();
        }
    }
}
