using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBookStore.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyBookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly MyBookStoreContext _Context;

        public BookController(MyBookStoreContext Context)
        {
            _Context = Context;
        }

        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _Context.Book;
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _Context.Book.SingleOrDefault(a => a.BookId == id);
        }

        // POST api/<BookController>
        // Add or Edit a Book
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            Book selectedBook = _Context.Book.Where(a => a.BookId == book.BookId).Select(b => b).FirstOrDefault();
            int? Bookid = _Context.Book.Where(a => a.BookId == book.BookId).Select(b => b.BookId).FirstOrDefault();
            try
            {
                if (Bookid != 0)
                {
                    selectedBook.Author = book.Author;
                    selectedBook.Category = book.Category;
                    selectedBook.Title = book.Title;
                    selectedBook.Price = book.Price;
                    _Context.SaveChanges();
                }
                else
                {
                    _Context.Book.Add(book);
                    _Context.SaveChanges();
                }
            }
            
            catch
            {
                throw;
            }
            
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var book = _Context.Book.FirstOrDefault(a => a.BookId == id);
            if(book != null)
            {
                _Context.Book.Remove(book);
                _Context.SaveChanges();
            }
        }
    }
}
