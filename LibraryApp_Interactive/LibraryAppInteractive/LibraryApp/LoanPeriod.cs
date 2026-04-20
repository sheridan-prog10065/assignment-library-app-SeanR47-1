using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

public struct LoanPeriod
{
    //Fields
    private DateTime _borrowedOn;
    private DateTime _returnedOn;
    private DateTime _dueDate;

    //Properties
    public DateTime BorrowedOn
    {
        get { return _borrowedOn; }
        set { _borrowedOn = value; }
    }

    public DateTime ReturnedOn
    {
        get { return _returnedOn; }
        set { _returnedOn = value; }
    }

    //Read only properties
    public DateTime DueDate
    {
        get { return _dueDate; }
        set { _dueDate = value; }
    }

    public TimeSpan LatePeriod
    {
        get
        {
            if (_returnedOn > _dueDate)
                return _returnedOn - _dueDate;
            else
                return TimeSpan.Zero;
        }
    }

    public TimeSpan LoanDuration
    {
        get { return _returnedOn - _borrowedOn; }
    }

    //Constructor
    public LoanPeriod(DateTime borrowedOn, DateTime dueDate)
    {
        _borrowedOn = borrowedOn;
        _dueDate = dueDate;

        _returnedOn = DateTime.MinValue;
    }
}
