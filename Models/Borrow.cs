namespace NHibernateExample.Models {
    internal class Borrow {
        public virtual int ID { get; set; }
        public virtual Client Client { get; set; }
        public virtual Book Book { get; set; }
        public virtual DateTime BorrowDate { get; set; }
        public virtual DateTime ReturnDate { get; set; }

        public virtual bool IsReturned() {
            return ReturnDate != DateTime.MinValue;
        }
    }
}
