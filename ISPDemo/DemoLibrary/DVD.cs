using DemoLibrary.Interface;
using System;
using System.Collections.Generic;

namespace DemoLibrary
{
    public class DVD : IBorrowableDVD
    {
        public string Author { get; set; }
        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; }
        public int CheckOutDurationInDays { get; set; } = 14;
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public int RunTimeInMinutes { get; set; }
        public List<string> Actors { get; set; }

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
