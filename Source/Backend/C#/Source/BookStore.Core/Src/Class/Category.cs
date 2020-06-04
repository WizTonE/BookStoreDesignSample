using BookStore.Model;
using BookStore.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core
{
    public class Category : ICategory
    {
        #region Properties
        private IBookListRepository BookListRepository { get; set; }
        #endregion

        #region Constructor
        public Category(IBookListRepository bookListRepository)
        {
            BookListRepository = bookListRepository;
        }
        #endregion

        #region Functions
        public IEnumerable<Book> GetAllCategory()
        {
            return BookListRepository.GetBooks();
        }
        #endregion
    }
}
