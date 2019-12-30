using DemoLibrary.Interface;
using System;

namespace DemoLibrary
{
    public class Book : IBorrowableBook
    {
        public string Author { get; set; }
        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; }
        public int CheckOutDurationInDays { get; set; }
        public string LibraryId { get; set; }
        public int Pages { get; set; }
        public string Title { get; set; }

        public void CheckIn()
        {
            Borrower = string.Empty;
        }

        public void Checkout(string borrower)
        {
            Borrower = borrower;
        }

        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckOutDurationInDays);
        }
    }
}
