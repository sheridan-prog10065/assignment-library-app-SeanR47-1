using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

public class LibraryAsset
{

    /// <summary>
    /// FIELDS:
    /// _book ~ book assosciated with asset
    /// _libID ~ unique library ID
    /// _status ~ status is available, not available, loaned or reserved
    /// _loanPeriod ~ information on the loan period
    /// </summary>
    private Book _book;
    private int _libID;
    private AssetStatus _status;
    private LoanPeriod _loanPeriod;

    //Constructor
    public LibraryAsset(int libID, Book book)
    {
        _libID = libID;
        _book = book;
        _status = AssetStatus.Available;
        _loanPeriod = new LoanPeriod();
    }

    /// <summary>
    /// Gets and sets the id, status and loan period
    /// </summary>
    public int LibId
    {
        get { return _libID; }
        set { _libID = value; }
    }

    public AssetStatus Status
    {
        get { return _status; }
        set { _status = value; }
    }

    public LoanPeriod Loan
    {
        get { return _loanPeriod; }
        set { _loanPeriod = value; }
    }

    public bool IsAvailable
    {
        get
        {
            throw new NotImplementedException();
        }
    }

}
