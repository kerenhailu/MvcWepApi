using MvcWepApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcWepApi.Controllers.API
{
    public class ValuesController : ApiController
    {
        // GET: api/Values
        public IHttpActionResult Get()
        {
            Create8Books();
            return Ok(booksList);
        }
        Random random = new Random();
        List<Book> booksList = new List<Book>();
        private void Create8Books()
        {
            Book book1 = new Book("HarriPoter", "sum", 1990, random.Next(100, 500), 0);
            Book book2 = new Book("batmen", "keren", 1980, random.Next(100, 500), 1);
            Book book3 = new Book("Snow White", "loli", 1970, random.Next(100, 500), 2);
            Book book4 = new Book("one piece", "shilat", 1999, random.Next(100, 500), 3);
            Book book5 = new Book("Aladdin", "sum", 1998, random.Next(100, 500), 4);
            Book book6 = new Book("The sleeping beauty", "shiraz", 2000, random.Next(100, 500), 5);
            Book book7 = new Book("Queen", "eden", 2002, random.Next(100, 500), 6);
            Book book8 = new Book("Friends", "idan", 1989, random.Next(100, 500), 7);
            booksList.Add(book1);
            booksList.Add(book2);
            booksList.Add(book3);
            booksList.Add(book4);
            booksList.Add(book5);
            booksList.Add(book6);
            booksList.Add(book7);
            booksList.Add(book8);
        }

        // GET: api/Values/5
        public IHttpActionResult Get(int id)
        {
            Book bookById = booksList.Find(item => item.id == id);
            return Ok(bookById);
        }

        // POST: api/Values
        public IHttpActionResult Post([FromBody] Book value)
        {
            //Create8Books();
            //List<string> names = new List<string>();
            //names.Add(value);
            //return Ok(names);
            List<Book> bookAdd = new List<Book>();

            bookAdd.Add(value);
            return Ok(bookAdd);


        }

        // PUT: api/Values/5
        public IHttpActionResult Put(int id, [FromBody] Book value)
        {
            Create8Books();
            //דרך ארוככה!!
           Book EaitBook=booksList.Find(item => item.id == id);
            // int indexBook=booksList.IndexOf(EaitBook);
            // booksList[indexBook].name = value.name;
            // booksList[indexBook].writer = value.writer;
            // booksList[indexBook].year = value.year;
            // booksList[indexBook].numOfPage = value.numOfPage;

            //דרך קצרה
            booksList[booksList.IndexOf(EaitBook)] = value;
            booksList[booksList.IndexOf(EaitBook)].id = id;

            return Ok(booksList);
        }

        // DELETE: api/Values/5
        public IHttpActionResult Delete(int id)
        {
            Create8Books();
            Book bookToDelete = booksList.Find(item => item.id == id);
            booksList.Remove(bookToDelete);
            return Ok(booksList);
        }
    }
}
