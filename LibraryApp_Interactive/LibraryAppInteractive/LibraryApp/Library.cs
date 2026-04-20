namespace LibraryAppInteractive;

/// <summary>
/// Defines the Library class used to manage the library books and assets.
///
/// NOTE: A single object/instance of this class (called a "singleton") is created and shared automatically
/// with the two pages in the application through the process of Dependency Injection handled and configured
/// in MauiProgram class.  
/// </summary>
public class Library
{
    /// <summary>
    /// FIELDS:
    /// _bookList ~ list of titles of books in the library
    ///_libIDGeneratorSeed ~ gives each book a dif id
    /// </summary>
    private List<Book> _bookList;
    private int _libIDGeneratorSeed;
    private const int DEFAULT_LIBID_START = 100;

    //Constructor
    public Library()
    {
        _bookList = new List<Book>();
        _libIDGeneratorSeed = DEFAULT_LIBID_START;

    }

    public void CreateDefaultBooks()
    {

    }

    public int DetermineLibID()
    {
        throw new NotImplementedException();
    }

    public Book RegisterBook(string bookName, string bookISBN, string[] authors, BookType bookType, int nCopies)
    {
        throw new NotImplementedException();
    }

    public Book FindBookByName(string bookName)
    {
        throw new NotImplementedException();
    }

    public Book FindBookByISBN(string bookISBN)
    {
        throw new NotImplementedException();
    }
}