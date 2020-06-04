using BookStore.Exception.Src;
using BookStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Repository.Src.Class
{
    public class BookListRepository : IBookListRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return BookStoreException.TryThrow(() =>
            {
                return Enumerable.Range(1, 500).Select(item => new Book { });
            });
        }
    }
}
