
using System.Data;
using System.Data.SqlTypes;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
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

            //double[] price = { 25.5, 40.0, 33.75 };

            //Console.WriteLine(price[1]);
            #endregion

            #region Question 2

            //int[,] shelfCopies = { { 3,5}, {1,4 } };

            //Console.WriteLine(shelfCopies[1,0]);


            #endregion

            #region Question 3

            //static void WelcomeMessage()
            //{
            //    Console.WriteLine("Welcome to the Library!");
            //}

            //WelcomeMessage();

            #endregion

            #region Question 4

            //static void printBookTitle(string title)
            //{
            //    Console.WriteLine("Book title:" + title);
            //}

            //printBookTitle("cleanCode");
            #endregion

            #region Question 5

            //static void AddBounsPages(int pages)
            //{
            //    pages += 50;
            //    Console.WriteLine(pages);
            //}
            //int pages = 400;
            //AddBounsPages(pages);
            //Console.WriteLine(pages);
            ////  Because passing by vlaue
            #endregion

            #region Question 6

            //static void ApplyDiscount(double[] prices)
            //{
            //    prices[0] -= 5;

            //}

            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);

            //// this is it passing by refrence because []
            #endregion

            #region Question 7

            //static void AddBounsPages(ref int pages)
            //{
            //    pages += 50;

            //}
            //int pages = 400;
            //AddBounsPages(ref pages);
            //Console.WriteLine(pages);
            //// Because passing by ref
            #endregion

            #region Question 8 

            //static void RepalceArray(ref double[] prices)
            //{

            //    prices = new double[] { 10.0, 12.5, 15.0 };

            //}
            //double[] prices = { 1.0, 2.0 };

            //RepalceArray(ref prices);

            //Console.WriteLine(prices.Length);






            #endregion

            #region Question 9


            //static bool TryGetPrice(string title, out double price)
            //{

            //    price = 25.5;
            //    title = "Clean Code";

            //    if (title == "Clean Code")
            //    {
            //        price = 25.5;
            //        return true;
            //    }
            //    else
            //    {
            //        price = 0;
            //        return false;
            //    }

            //}

            //string myTitle = "Clean Code";
            //double myPrice;

            //bool isFound = TryGetPrice(myTitle, out myPrice);
            //Console.WriteLine(myPrice);


            #endregion

            #region Question 10

            //static void PrintBookInfo(string title, int pages = 300)
            //{
            //    Console.WriteLine($"title: {title}, Pages: {pages}");
            //}

            //PrintBookInfo("pages");
            //PrintBookInfo("title", 301);

            #endregion

            #region Question 11

            //static void PrintBookInfo(string title, int pages = 300)
            //{
            //    Console.WriteLine(title + pages);
            //}


            //PrintBookInfo(pages: 301 , title: "pages");

            #endregion

            #region Question 12

            //static void PrintAllTitles(params string[] titles)
            //{

            //    foreach (string title in titles)
            //    {
            //        Console.WriteLine(title);
            //    }
            //}

            //PrintAllTitles("1", "2", "3", "4", "5");

            #endregion


        }

    }

}






