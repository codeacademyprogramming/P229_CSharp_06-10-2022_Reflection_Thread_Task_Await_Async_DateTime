using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Exceptions
{
    class BookNotFoundException : Exception
    {
        public BookNotFoundException(string msg) : base(msg)
        {

        }
    }
}
