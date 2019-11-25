using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class LibraryBook
    {
        public virtual Library Library { get; set; }
        public int LibraryId { get; set; }
        public virtual Book Book { get; set; }
        public int BookId { get; set; }
    }
}
