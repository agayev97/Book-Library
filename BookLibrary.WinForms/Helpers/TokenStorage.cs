using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.WinForms.Helpers
{
    public class TokenStorage
    {
        private static readonly object _lock = new object();
        private static string _token;

        public static string Token
        {
            get
            {
                lock (_lock)
                {
                    return _token;
                }
            }
            set
            {
                lock (_lock)
                {
                    _token = value;
                }
            }
        }
    }
}
