namespace NHibernateExample.Models {
    internal class Client {
        public virtual int ID { get;set; }
        public virtual string FirstName { get;set; }
        public virtual string LastName { get;set; }
        public virtual string Email { get;set; }
        public virtual IList<Borrow> Borrows { get; set; } = new List<Borrow>();
    }
}
