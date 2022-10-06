using HomeWork.Enums;
using HomeWork.Interfaces;
using HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Text;
using HomeWork.Exceptions;

namespace HomeWork.Services
{
    class LibraryManager : ILibraryManager
    {
        List<Book> _books;

        public LibraryManager()
        {
            _books = new List<Book>();
        }

        public List<Book> Books => _books;

        public void Add(Book book)
        {
            if (_books.Exists(b => b.Name.ToLower() == book.Name.ToLower()))
                throw new SameBookalreadyAddedExpection($"Daxil Edilen Add - {book.Name} Kitab Artiq Movcuddur");

            _books.Add(book);
        }

        public List<Book> Filter(string name, Genre genre)
        {
            return _books.FindAll(b => b.Name.ToLower() == name.ToLower() && b.Genre == genre);
        }

        public List<Book> Search(string search)
        {
            throw new NotImplementedException();
        }

        public Book ShowInfo(string name)
        {
            Book book = _books.Find(b => b.Name.ToLower() == name.ToLower());

            if (book == null)
                throw new BookNotFoundException($"Bu Adda - {name} Kitab Tapilmadi");

            return book;
        }
    }
}
