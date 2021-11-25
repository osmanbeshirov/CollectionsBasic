using System;
using System.Collections.Generic;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //**basit pratik

            //List<string> diller = new List<string> { "Java", "C#", "Python" };

            //Console.WriteLine(diller[0]);

            //foreach (var dil in diller)
            //{
            //    Console.WriteLine(dil);
            //}



            //**OOP pratik

            Book kitab1 = new Book();
            kitab1.id = 1;
            kitab1.name = "Alcatras";
            kitab1.author = "William";
            kitab1.price = 230;

            Book kitab2 = new Book();
            kitab2.id = 2;
            kitab2.name = "Avatar";
            kitab2.author = "Cameroon";
            kitab2.price = 260;

            Book kitab3 = new Book();
            kitab3.id = 3;
            kitab3.name = "Call of duty";
            kitab3.author = "James";
            kitab3.price = 490;

            Book kitab4 = new Book();
            kitab4.id = 4;
            kitab4.name = "Xiaomi";
            kitab4.author = "Chen Chuk Ben";
            kitab4.price = 1200;

            Book kitab5 = new Book();
            kitab5.id = 5;
            kitab5.name = "Baby driver";
            kitab5.author = "Sergei Dunking";
            kitab5.price = 1220;

            //Book[] kitablar = new Book[] {kitab1,kitab2,kitab3 };

            //foreach (var kitab in kitablar)
            //{
            //    Console.WriteLine(kitab.name + "/" + kitab.author + "/" + kitab.price);

            //}


            //**ListPratik

            List<Book> kitablar = new List<Book> {kitab1,kitab2,kitab3 };

            //kitablar.Add(kitab1);
            //kitablar.Add(kitab2);

            kitablar.Add(kitab4);

            //foreach (var kitab in kitablar)
            //{
            //    Console.WriteLine(kitab.name +"/" + kitab.price);
            //}

            BookManager bookManager = new BookManager();
            bookManager.Add(kitab1);
            bookManager.Add(kitab4);

            kitablar.Add(kitab5);

            bookManager.Add(kitab5);


        }
    }
}
