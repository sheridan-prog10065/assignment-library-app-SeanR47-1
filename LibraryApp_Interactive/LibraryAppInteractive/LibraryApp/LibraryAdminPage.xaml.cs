using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppInteractive;

public partial class LibraryAdminPage : ContentPage
{
    private Library _library = new Library();
    public LibraryAdminPage(Library library)
    {        
        InitializeComponent();
        _library = library;
        _pckBookType.ItemsSource = Enum.GetNames(typeof(BookType));
    }

    private void OnRegister(object sender, EventArgs e)
    {
        try
        {
            string name = _txtBookName.Text;
            string isbn = _txtISBN.Text;

            var authors = _txtAuthors.Text
                .Split(',')
                .Select(a => a.Trim())
                .ToList();

            int copies = int.Parse(_txtCopies.Text);
            BookType type = (BookType)_pckBookType.SelectedIndex;

            _library.RegisterBook(name, isbn, authors, type, copies);

            _lblResult.Text = "Book registered successfully!";
        }
        catch
        {
            _lblResult.Text = "Error registering book.";
        }
    }
}