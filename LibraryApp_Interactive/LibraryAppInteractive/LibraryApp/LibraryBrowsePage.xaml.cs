namespace LibraryAppInteractive;

public partial class LibraryBrowsePage : ContentPage
{
    private Library _library = new();
    private Book _selectedBook;
    public LibraryBrowsePage(Library library)
    {   
        InitializeComponent();
        _library = library;
    }

    private void OnSearch(object sender, EventArgs e)
    {
        Book book = _library.FindBookByName(_txtSearchBook.Text);
        if (book != null)
        {
            BooksListView.ItemsSource = new List<Book> { book };
            _lblStatus.Text = "Book found";
        }
        else
        {
            _lblStatus.Text = "Book not found";
        }
    }

    private void OnBorrow(object sender, EventArgs e)
    {
        LibraryAsset asset = _selectedBook.BorrowBook();
        if (asset != null)
            _lblStatus.Text = $"Borrowed asset {asset.LibId}";
        else
            _lblStatus.Text = "No copies";
    }

    private void OnReturn(object sender, EventArgs e)
    {
        LibraryAsset asset = _selectedBook.Assets
            .FirstOrDefault(a => a.Status == AssetStatus.Loaned);

        if (asset == null)
        {
            _lblStatus.Text = "No borrowed assets";
            return;
        }

        var result = _selectedBook.ReturnBook(asset.LibId);

        _lblStatus.Text = $"Returned. Late: {result.Item2}, Fee: {result.Item3}";
    }

   
}