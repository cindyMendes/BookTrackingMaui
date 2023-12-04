using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTrackingMaui.DTOs
{
    internal class APIs
    {        
        //Book
        public const string GetAllBooks = "api/Book/GetAllBooks"; 
        public const string GetBookById = "api/Book/GetBookById";
        public const string GetBooksByAuthorId = "api/Book/GetBooksByAuthorId";
        public const string AddBook = "api/Book/AddBook";
        public const string UpdateBook = "api/Book/UpdateBook";
        public const string DeleteBook = "api/Book/DeleteBook";
        
        //Author
        public const string GetAllAuthors = "api/Author/GetAllAuthors";
        public const string GetAuthorById = "api/Author/GetAuthorById";
        public const string AddAuthor = "api/Author/AddAuthor";
        public const string UpdateAuthor = "api/Author/UpdateAuthor";
        public const string DeleteAuthor = "api/Author/DeleteAuthor";

        //Category
        public const string GetAllCategories = "api/Category/GetAllCategories";
        public const string GetCategoryById = "api/Category/GetCategoryById";
        public const string AddCategory = "api/Category/AddCategory";
        public const string UpdateCategory = "api/Category/UpdateCategory";
        public const string DeleteCategory = "api/Category/DeleteCategory";

        //Nationality
        public const string GetAllNationalities = "api/Nationality/GetAllNationalities";
        public const string GetNationalityById = "api/Nationality/GetNationalityById";
        public const string AddNationality = "api/Nationality/AddNationality";
        public const string UpdateNationality = "api/Nationality/UpdateNationality";
        public const string DeleteNationality = "api/Nationality/DeleteNationality";

        //Bibliography
        public const string GetAllBibliographyies = "api/Bibliography/GetAllBibliographyies";
        public const string GetBibliographyById = "api/Bibliography/GetBibliographyById";
        public const string AddBibliography = "api/Bibliography/AddBibliography";
        public const string UpdateBibliography = "api/Bibliography/UpdateBibliography";
        public const string DeleteBibliography = "api/Bibliography/DeleteBibliography";

        //Series
        public const string GetAllSeries = "api/Series/GetAllSeries";
        public const string GetSeriesById = "api/Series/GetSeriesById";
        public const string AddSeries = "api/Series/AddSeries";
        public const string UpdateSeries = "api/Series/UpdateSeries";
        public const string DeleteSeries = "api/Series/DeleteSeries";

        //BookCategory
        public const string GetAllBooksCategories = "api/BookCategory/GetAllBooksCategories";
        public const string GetBookCategoryById = "api/BookCategory/GetBookCategoryById";
        public const string AddBookCategory = "api/BookCategory/AddBookCategory";
        public const string UpdateBookCategory = "api/BookCategory/UpdateBookCategory";
        public const string DeleteBookCategory = "api/BookCategory/DeleteBookCategory";


    }
}
