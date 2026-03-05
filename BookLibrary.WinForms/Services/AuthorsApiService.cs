using BookLibrary.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.WinForms.Services
{
    public class AuthorsApiService
    {
        private readonly HttpClient _httpClient;

        public AuthorsApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7114/");
        }

        public async Task<List<AuthorDto>> GetAllAsync()
        {
            var authors = await _httpClient.GetFromJsonAsync<List<AuthorDto>>("api/authors");
            return authors ?? new List<AuthorDto>();

        }
    }
}
