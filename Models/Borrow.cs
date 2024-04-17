using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateExample.Models {
    internal class Borrow {
        public virtual int ID { get; set; }
        public virtual string ClientID { get; set; }
        public virtual string BookID { get; set; }
        public virtual DateTime BorrowDate { get; set; }
        public virtual DateTime ReturnDate { get; set; }

        public virtual bool IsReturned() {
            return ReturnDate != DateTime.MinValue;
        }
    }
}
