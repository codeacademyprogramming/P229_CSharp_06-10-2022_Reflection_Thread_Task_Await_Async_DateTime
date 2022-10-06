using System;
using System.Collections.Generic;
using System.Text;
using HomeWork.Enums;

namespace HomeWork.Models
{
    class Book
    {
        public Genre Genre;
        public string Name;
        public string Author;
        public int PageCount;

        public Book(string name, string author, int pageCount, Genre genre)
        {
            Genre = genre;
            Name = name;
            Author = author;
            PageCount = pageCount;
        }
    }
}
