using System;

namespace Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        // making the foreign key optional is the only change you need to do, that way EF picks it up to be optional
        public Guid? AuthorId { get; set; }
    }
}
