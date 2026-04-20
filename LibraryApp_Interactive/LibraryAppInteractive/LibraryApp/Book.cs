using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppInteractive;

internal class Book
{
    /// <summary>
    /// _bookName: name of book
    /// _bookISBN: ISBN of book
    /// _bookAuthorList: list of authors of book
    /// _libAssetList: list of assets of book
    /// </summary>
    private string _bookName;
    private string _bookISBN;
    private List<string> _bookAuthorList;
    private List<LibraryAsset> _libAssetList;

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

    
}
