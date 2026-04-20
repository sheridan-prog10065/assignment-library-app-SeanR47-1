using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

public class Book
{
    /// <summary>
    /// _bookName: name of book
    /// _bookISBN: ISBN of book
    /// _bookAuthorList: list of authors of book
    /// _libAssetList: list of assets of book
    /// </summary>
    private string _bookName;
    private string _bookISBN;
    private List<LibraryAsset> _libAssetsList;
    private List<string> _bookAuthorList;

    //Constructor
    public Book(string bookName, string bookISBN)
    {
        _bookName = bookName;
        _bookISBN = bookISBN;
        

    }

    /// <summary>
    /// gets and sets name, ISBN, authors and assets for a book
    /// </summary>
    public string Name
    {
        get { return _bookName; }
        set { _bookName = value; }
    }

    public string ISBN
    {
        get { return _bookISBN; }
        set { _bookISBN = value; }
    }

    public List<string> Authors
    {
        get { return _bookAuthorList;  }
        set { _bookAuthorList = value; }
    }

    public List<LibraryAsset> Assets
    {
        get { return _libAssetsList; }
        set { _libAssetsList = value; }
    }

    public (bool, DateTime?) CheckAvailability()
    {
        var nextAsset = FindNextAvailableAsset();

        if (nextAsset.Status == AssetStatus.Available)
            return (true, null);
        else
            return (false, nextAsset.Loan.DueDate);
    }

    public LibraryAsset BorrowBook()
    {
        LibraryAsset asset = FindNextAvailableAsset();

        if (asset.Status != AssetStatus.Available)
            throw new Exception("Book is not available. Please reserve instead.");

        asset.Status = AssetStatus.Loaned;
        asset.Loan = new LoanPeriod(DateTime.Now, DateTime.Now.AddDays(14));

        return asset;
    }

    public (TimeSpan, int, decimal) ReturnBook(int libId)
    {
        LibraryAsset asset = FindLibraryAsset(libId);
        LoanPeriod loan = asset.Loan;

        loan.ReturnedOn = DateTime.Now;
        asset.Loan = loan;

        TimeSpan duration = loan.LoanDuration;
        TimeSpan late = loan.LatePeriod;

        asset.Status = AssetStatus.Available;

        return (duration, late.Days, 0);
    }

    public LibraryAsset ReserveBook()
    {
        LibraryAsset asset = FindNextAvailableAsset();

        asset.Status = AssetStatus.Reserved;

        return asset;
    }

    public LibraryAsset FindNextAvailableAsset()
    {
        LibraryAsset nextAsset = null;

        foreach (LibraryAsset asset in _libAssetsList)
        {
            if (asset.Status == AssetStatus.Available)
                return asset;

            if (asset.Status == null || (nextAsset.Loan.DueDate < nextAsset.Loan.DueDate && nextAsset.Status != AssetStatus.Reserved))
            {
                nextAsset = asset;
            }
        }

        return nextAsset;
    }

    public LibraryAsset FindLibraryAsset(int libId)
    {
        LibraryAsset asset = _libAssetsList[libId];
        return asset;
    }
}
