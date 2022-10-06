using HomeWork.Enums;
using HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Interfaces
{
    interface ILibraryManager
    {
        List<Book> Books { get; }
        void Add(Book book);
        Book ShowInfo(string name);
        List<Book> Search(string search);
        List<Book> Filter(string name, Genre genre);
    }
}
