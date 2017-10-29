using System;
using System.Net.Http;

namespace RandomUserSharp
{
    public class RandomUserClient : IDisposable
    {
        private readonly HttpClient _httpClient;

        public RandomUserClient()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("http://api.randomuser.me/1.1") };
        }

        private bool _disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            try
            {
                if (disposing)
                    _httpClient.Dispose();
            }
            finally
            {
                _disposed = true;
            }
        }
    }
}
