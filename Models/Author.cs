﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
