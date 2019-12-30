using DemoLibrary;
using DemoLibrary.Interface;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IBorrowableBook borrowableBook = new Book();
            borrowableBook.Author = "Tim";
            borrowableBook.CheckOutDurationInDays = 5;
            borrowableBook.BorrowDate = DateTime.Now;

            Console.WriteLine(borrowableBook.GetDueDate());
        }
    }
}
