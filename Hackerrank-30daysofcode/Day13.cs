using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_30daysofcode
{
    
  
abstract class Day13
    {

        protected String title;
        protected String author;

        public Day13(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }

    class MyBook : Day13
    {
        private int price;

        public MyBook(string title, string author, int _price) : base(title, author)
        {
            price = _price;
        }
        public override void display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
            Console.ReadLine();
        }
    }
    //Write MyBook class

   
            
}
