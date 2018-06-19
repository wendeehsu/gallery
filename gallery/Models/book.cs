using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

namespace gallery.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookImg { get; set; }
    }

    public class BookManager 
    {
        public static ObservableCollection<Book> GetBooks(string a)
        {
            var books = new ObservableCollection<Book>();
            string[] name =  new string[] { "Integer", "ut", "ante", "tempor", "aliquet", "turpis", "et", "molestie", "turpis", "Quisque", "in", "neque", "eu", "quam", "viverra", "sagittis", "Cras", "porta", "feugiat", "tortor" };
            
            if(a == "")
            {
                for (int i = 0; i <20; i++)
                {
                    books.Add(new Book { BookID = i+1 , BookName = name[i], BookImg = $"/Assets/pic/{i+1}.jpg"});
                }
            }
            else
            {
                for(int i = 0; i < name.Length; i++)
                {
                    if (name[i].Contains(a))
                    {
                        books.Add(new Book { BookID = i + 1, BookName = name[i], BookImg = $"/Assets/pic/{i + 1}.jpg" });
                    }
                }
                foreach(Book i in books)
                {
                    Debug.WriteLine(i.BookName);
                }
            }
            return books;
        }
    }
}