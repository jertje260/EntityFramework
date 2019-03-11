using System;
using System.Collections.Generic;

namespace Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public Guid AuthorId { get; set; }
        public List<LibraryBook> LibraryBooks { get; set; }
    }
}
