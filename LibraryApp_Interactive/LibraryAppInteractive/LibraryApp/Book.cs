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
    private List<string> _bookAuthorsList;
    private List<LibraryAsset> _libAssetsList;
    private List<string> _bookAuthorList;
    private IEnumerable<LibraryAsset> _libAssetList;

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

    public IEnumerable<LibraryAsset> Assets
    {
        get { return _libAssetList; }
        set { _libAssetList = (List<LibraryAsset>)value; }
    }

    public bool CheckAvailability()
    {
        throw new NotImplementedException();
    }

    public LibraryAsset BorrowBook()
    {
        throw new NotImplementedException();
    }

    public (TimeSpan, int, decimal) ReturnBook(int libId)
    {
        throw new NotImplementedException();
    }

    public LibraryAsset ReserveBook()
    {
        throw new NotImplementedException();
    }

    public LibraryAsset FindNextAvailableAsset()
    {
        throw new NotImplementedException();
    }
}
