using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Library
    {
        public Guid Id { get; set; }
        public List<LibraryBook> LibraryBooks { get; set; }
    }
}
