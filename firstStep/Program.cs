using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace firstStep
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region Question 1
            //string title = "clean code";
            //string upperTitle = title;

            //title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion

            #region Question 2

            //string name1 = "clean code";
            //string name2 = "clean code";
            //Console.WriteLine(object.ReferenceEquals(name1,name2));



            #endregion

            #region Question 3

            //StringBuilder sb = new StringBuilder("BookList");
            //sb.AppendLine();
            //sb.Append("Updated");

            //Console.WriteLine(sb);


            #endregion

            #region Question 4

            //StringBuilder sb = new StringBuilder("BookList");
            //sb.Replace("BookList", "Library");
            //Console.WriteLine(sb);

            #endregion

            #region Question 5

            //string title = "Clean Code";
            //int pages = 464;

            //Console.WriteLine("Book:"+ title+ "Pages:"+ pages);


            #endregion

            #region Question 6

            //string title = "Clean Code";
            //int pages = 464;

            //Console.WriteLine($"Book: {title}" +"\n"+ "pages: " + pages);


            #endregion

            #region Question 7

            //string title = "Clean Code";
            //int pages = 464;

            //string result = string.Format("Book: {0}, Pages: {1}", title, pages);
            //Console.WriteLine(result);

            #endregion

            #region Question 8

            //int pages = 464;
            //if (pages > 300)
            //{
            //    Console.WriteLine("LongBook");
            //}
            //else { Console.WriteLine("shortBook"); }


            #endregion

            #region Question 9

            //int pages = 464;
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable == true)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}

            #endregion

            #region Question 10

            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "Clean code":
            //        Console.WriteLine("Great choise");
            //        break;

            //    case "Refactoring":
            //        Console.WriteLine("Nice pick");
            //        break;

            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;


            //}

            #endregion

            #region Question 11

            //int pages = 464;

            //string result = (pages > 300 ? "LongBook" : "shortBook");
            //Console.WriteLine(result);
            #endregion

            #region Question 12

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //for (int i = 0; i < books.Length; i++)
            //{

            //    Console.WriteLine((i + 1) + "." + books[i]);
            //}

            #endregion

            #region Question 13
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };


            //int i = 0;
            //while (i < books.Length)
            //{

            //    Console.WriteLine(books[i]);
            //    i++;
            //}

            #endregion

            #region Question 14

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;

            //do
            //{
            //    Console.WriteLine(books[i]);
            //    i++;
            //} while (i < books.Length);

            #endregion

            #region Question 15

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}

            #endregion

            #region Question 16
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //foreach (string book in books)
            //{
            //    if (book == "Refactoring")
            //        break;
            //    Console.WriteLine(book);
            //}



            #endregion

            #region Question 17

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //foreach (string book in books)
            //{
            //    if (book == "The Pragmatic Programmer")
            //        continue;
            //    Console.WriteLine(book);
            //}


            #endregion

            #region Question 18

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

           
            //void printFirstBook(string[] books)
            //{
            //    if (books == null || books.Length == 0)
            //    {
            //        return;
            //    }
            //}

            //Console.WriteLine(books[0]);
            #endregion

        }

    }


}
