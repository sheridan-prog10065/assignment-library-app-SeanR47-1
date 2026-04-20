using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

internal class DigitalBook : Book
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
}
