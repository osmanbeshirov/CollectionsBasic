using System;
using System.Collections.Generic;
using System.Text;

namespace ListTest
{
    class BookManager
    {
        public void Add(Book nesne)
        {
            Console.WriteLine("Muellifi - " + nesne.author + " olan, " + nesne.name +" adli kitab sebete uğurla elave olundu..." );
        }
    }
}
