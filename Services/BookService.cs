using BookTrackingMaui.Shared;
using BookTrackingMaui.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookTrackingMaui.DTOs.Book;

namespace BookTrackingMaui.Services
{
    internal class BookService : IBookService
    {
        public async Task<List<BookResponseModel>> GetAllBooks()
        {
            var _baseUrl = new Uri("https://localhost:7086");
            var returnResponse = new List<BookResponseModel>();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.GetAllBooks}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<List<BookResponseModel>>(deserializeResponse.Content.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;
        }

        public async Task<BookResponseModel> GetBookById(int id)
        {
            var _baseUrl = new Uri("https://localhost:7086");
            var returnResponse = new BookResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.GetBookById}/{id}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<BookResponseModel>(deserializeResponse.Content.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;
        }

        public async Task<MainResponseModel> AddBook(AddBookRequestModel addBookRequest)
        {
            var _baseUrl = new Uri("https://localhost:7086");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.AddBook}";
                    var serializedContent = JsonConvert.SerializeObject(addBookRequest);
                    var apiResponse = await client.PostAsync(url, new StringContent(serializedContent, Encoding.UTF8, "application/json"));

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        returnResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;
        }

        public async Task<MainResponseModel> UpdateBook(UpdateBookRequestModel updateBookRequest)
        {
            var _baseUrl = new Uri("https://localhost:7086");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.UpdateBook}";
                    var serializedContent = JsonConvert.SerializeObject(updateBookRequest);
                    var apiResponse = await client.PutAsync(url, new StringContent(serializedContent, Encoding.UTF8, "application/json"));

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        returnResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                    }
                    else
                    {
                        returnResponse.IsSuccess = false;
                        returnResponse.Content = apiResponse.Content;
                        returnResponse.Message = apiResponse.StatusCode.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;
        }

        public async Task<MainResponseModel> DeleteBook(int bookId)
        {
            var _baseUrl = new Uri("https://localhost:7086");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.DeleteBook}/{bookId}";
                    var apiResponse = await client.DeleteAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        returnResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;
        }


    }
}
