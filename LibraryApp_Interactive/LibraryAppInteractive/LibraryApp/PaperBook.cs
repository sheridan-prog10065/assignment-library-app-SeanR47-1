using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

internal class PaperBook : Book
{
    /// <summary>
    /// MAX_BORROR_DAYS: max borrow days for a paper book
    /// LATE_PENALTY_PER_DAY: late penalty per day
    /// </summary>
    private const int MAX_BORROR_DAYS = 30;
    private const float LATE_PENALTY_PER_DAY = 0.25f;

    //Instance of paper book class
    public PaperBook(string bookName, string bookISBN) : base(bookName, bookISBN)
    {

    }
}
