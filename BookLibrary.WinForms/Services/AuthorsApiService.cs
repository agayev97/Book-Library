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
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppSession.Token);

            var response = await _httpClient.GetAsync("api/authors");

            response.EnsureSuccessStatusCode();

            return  await response.Content.ReadAsAsync<List<AuthorDto>>();

        }
    }
}
