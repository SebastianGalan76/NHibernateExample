namespace NHibernateExample.Models {
    internal class Book {
        public virtual int ID { get; set; }
        public virtual string? ISBN { get; set; }
        public virtual string? Title { get; set; }
        public virtual string? Author { get; set; }
        public virtual IList<Borrow> Borrows { get; set; } = new List<Borrow>();
    }
}
