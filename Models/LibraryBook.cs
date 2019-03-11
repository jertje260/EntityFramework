using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class LibraryBook
    {
        public Library Library { get; set; }
        public Guid LibraryId { get; set; }
        public Book Book { get; set; }
        public Guid BookId { get; set; }
    }
}
