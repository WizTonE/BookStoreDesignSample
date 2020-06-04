using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Model
{
    public class Book
    {
        public Category Category { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public Author Author { get; set; }
    }
}
