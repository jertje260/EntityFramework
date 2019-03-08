using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Author
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Book Book { get; set; }
    }
}
