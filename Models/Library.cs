using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Library
    {
        public int Id { get; set; }
        public virtual List<LibraryBook> LibraryBooks { get; set; }
    }
}
