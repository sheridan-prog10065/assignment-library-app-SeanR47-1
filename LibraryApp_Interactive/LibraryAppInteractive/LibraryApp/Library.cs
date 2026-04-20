using System.Xml.Linq;

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

    /// <summary>
    /// Gives unique ID. each new id is increased by 1
    /// </summary>
    /// <returns>_libIDGeneratorSeed</returns>
    
    public int DetermineLibID()
    {
        _libIDGeneratorSeed++;
        return _libIDGeneratorSeed;
    }

    /// <summary>
    /// gives the book its properties based on whether its paper or digital
    /// adds assets
    /// </summary>
    /// <param name="bookName"></param>
    /// <param name="bookISBN"></param>
    /// <param name="authors"></param>
    /// <param name="bookType"></param>
    /// <param name="nCopies"></param>
    /// <returns>book</returns>
    public Book RegisterBook(string bookName, string bookISBN, List<string> authors, BookType bookType, int nCopies)
    {
        Book book;

        if (bookType == BookType.Paper)
        
            book = new PaperBook(bookName, bookISBN);

        else
            book = new DigitalBook(bookName, bookISBN);

        book.Authors = authors;

        for (int i = 0; i < nCopies; i++)
        {
            int id = DetermineLibID();
            LibraryAsset asset = new LibraryAsset(id, book);
            book.Assets.Add(asset);
        }

        _bookList.Add(book);

        return book;
    }
    /// <summary>
    /// finds and returns the book based on name
    /// </summary>
    /// <param name="bookName"></param>
    /// <returns></returns>
    public Book FindBookByName(string bookName)
    {
        //Ai asked how to get the book name to lower case
        return _bookList.FirstOrDefault(b => b.Name.ToLower().Contains(bookName.ToLower()));
    }

    /// <summary>
    /// finds and returns book based on ISBN
    /// </summary>
    /// <param name="bookISBN"></param>
    /// <returns></returns>
    public Book FindBookByISBN(string bookISBN)
    {
        return _bookList.FirstOrDefault(b => b.Name.ToLower().Contains(bookISBN.ToLower()));
    }
}