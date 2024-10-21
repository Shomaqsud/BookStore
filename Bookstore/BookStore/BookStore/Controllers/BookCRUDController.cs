using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    
        [ApiController]
        [Route("Book")]

        public class BookController : ControllerBase
        {
            private readonly BookStoreContext _appContext;
            public BookController(BookStoreContext appContext)
            {
                _appContext = appContext;
            }
            [HttpPost]
            public int CreateAutor(BookModel book)
            {
                _appContext.Books.Add(book);
                _appContext.SaveChanges();
                return book.Id;
            }
            [HttpGet]
            public List<BookModel> GetBooks()
            {
                return _appContext.Books.ToList();
            }
            [HttpDelete]
            public void DeleteAutor(int bookid)
            {
                var bk = _appContext.Books.FirstOrDefault(b => b.Id == bookid);
                _appContext.Books.Remove(bk);
                _appContext.SaveChanges();
            }

            [HttpPut]
            public BookModel UpdateBook(BookModel book)
            {
                _appContext.Books.Update(book);
                _appContext.SaveChanges();
                return book;
            }
        }
    
}
