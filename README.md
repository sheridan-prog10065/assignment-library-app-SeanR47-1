# Report

## Table of inputs
| Name | Type | Maui |
| :---         |     :---:      |          ---: |
| Book Name   | string     | _txtBookName   |
| ISBN     | string      | _txtISBN     |
| Authors     | List<string>      | _txtAuthors     |
| Book Type     | enum      | _pckBookType     |
| Number of copies    | int      | _txtCopies     |
| Search     | string      | _txtSearchBook    |
| Book     | Book       | BooksListView      |
| Assets     | LibraryAsset       | AssetsListView      |

## Table of outputs
| Name | Type | Maui |
| :---         |     :---:      |          ---: |
| List of Books   | List<Book>     | BooksListView   |
| List of Assets     | List<LibraryAsset>      | AssetsListView     |
| Registration Result     | string      | _lblResult     |
| Status     | string     | _lblStatus     |

Program doesn't work fully. Tried to implement as much as possible for marks
