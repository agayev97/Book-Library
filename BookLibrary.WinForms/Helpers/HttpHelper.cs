using BookLibrary.WinForms.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.WinForms.Helpers
{
    public static class HttpHelper
    {
        public static HttpClient GetClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7114/");

            if(AppSession.IsAuthenticcated)
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", AppSession.Token);
            }

            return client;
        }
    }
}
