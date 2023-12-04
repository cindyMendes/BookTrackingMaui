using BookTrackingMaui.DTOs;
using BookTrackingMaui.DTOs.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTrackingMaui.Services
{
    internal interface IBookService
    {
        Task<List<BookResponseModel>> GetAllBooks();
        Task<BookResponseModel> GetBookById(int id);
        Task<MainResponseModel> AddBook(AddBookRequestModel addBookRequest);
        Task<MainResponseModel> UpdateBook(UpdateBookRequestModel updateBookRequest);
        Task<MainResponseModel> DeleteBook(int bookId);
        
    }
}
