using BookLibrary.WinForms.Models;
using BookLibrary.WinForms.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.WinForms.Services
{
    public class BooksApiServices
    {
        private readonly HttpClient _httpClient;

        public BooksApiServices()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7114/");
        }

        public async Task<List<BookDto>> GetAllAsync()
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppSession.Token);

            var response = await _httpClient.GetAsync("api/books");

            if(!response.IsSuccessStatusCode)
            {
                return new List<BookDto>();
            }
               

            return await response.Content
                .ReadFromJsonAsync<List<BookDto>>();
        }
    }
}
