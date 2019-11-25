using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class LibraryBook
    {
        public Library Library { get; set; }
        public int LibraryId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
    }
}
