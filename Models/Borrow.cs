using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateExample.Models {
    internal class Borrow {
        public int ID { get; set; }
        public string ClientID { get; set; }
        public string BookID { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public bool IsReturned() {
            return ReturnDate != DateTime.MinValue;
        }
    }
}
