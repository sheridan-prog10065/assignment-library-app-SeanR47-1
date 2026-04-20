using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

public class DigitalBook : Book
{
    /// <summary>
    /// _maxBorrowDays: max borrow days for a digital book
    /// _latePenaltyPerDay: late penalty per day
    /// </summary>
    private int _maxBorrowDays;
    private float _latePenaltyPerDay;

    //Instance of digital book class
    public DigitalBook(string bookName, string bookISBN) : base (bookName, bookISBN)
    {
        
    }

    public void DetermineLoanLiscense()
    {
        throw new NotImplementedException();
    }

    public new LibraryAsset BorrowBook()
    {
        throw new NotImplementedException();
    }

    public new (TimeSpan, int, decimal) ReturnBook(int libID)
    {
        throw new NotImplementedException();
    }
}
