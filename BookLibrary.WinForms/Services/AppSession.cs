using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.WinForms.Services
{
    public class AppSession
    {
        public static string? Token {  get; set; }
        public static string? UserName {  get; set; }
        public static string? Role {  get; set; }

        public static bool IsAuthenticcated =>
            !string.IsNullOrEmpty(Token);

        public static void Clear()
        {
            Token = null;
            UserName = null;
            Role = null;
        }
    }
}
