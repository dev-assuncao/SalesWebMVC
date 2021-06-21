using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbConcurrencyException : ArgumentException
    {
        public DbConcurrencyException(string message) : base (message)
        {
        }
    }
}
