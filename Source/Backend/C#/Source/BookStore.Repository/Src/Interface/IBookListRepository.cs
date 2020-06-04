using BookStore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository
{
    public interface IBookListRepository
    {
        IEnumerable<Book> GetBooks();
    }
}
