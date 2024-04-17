using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateExample.Models {
    internal class Book {
        public virtual int ID { get; set; }
        public virtual string ISBN { get; set; }
        public virtual string Title { get; set; }
        public virtual string Author { get; set; }
    }
}
