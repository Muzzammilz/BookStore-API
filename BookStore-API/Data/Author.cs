﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore_API.Data
{
    [Table("Authors")]
    public partial class Author
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastNnme { get; set; }
        public string Bio { get; set; }
        public virtual IList<Book> Books { get; set; }
    }
}