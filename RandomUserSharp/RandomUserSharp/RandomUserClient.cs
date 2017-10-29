using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RandomUserSharp.Models;
using RandomUserSharp.Utils;

namespace RandomUserSharp
{
    public class RandomUserClient : IDisposable
    {
        private readonly HttpClient _httpClient;

        public RandomUserClient()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri("http://api.randomuser.me/1.1") };
        }

        public async Task<User> GetSingleRandomUserAsync(Gender gender = Gender.Both, List<Nationality> natioanlities = null, bool useLegoImages = false, string seed = null)
        {
            var options = new RequestOptions { Gender = gender, Seed = seed, UseLegoImages = useLegoImages, Nationalities = natioanlities };
            return await GetRandomUsersAsync(options).ContinueWith(r => r.Result.FirstOrDefault());
        }

        public async Task<List<User>> GetRandomUsersAsync(int count, Gender gender = Gender.Both, List<Nationality> natioanlitites = null, bool useLegoImages = false, string seed = null)
        {
            var options = new RequestOptions { Count = count, Gender = gender, Seed = seed, UseLegoImages = useLegoImages, Nationalities = natioanlitites };
            return await GetRandomUsersAsync(options).ContinueWith(r => r.Result);
        }
        
        private async Task<List<User>> GetRandomUsersAsync(RequestOptions options)
        {
            var parameters = $"/?{options}";
            var response = await _httpClient.GetAsync(parameters);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var users = await Task.Run(() => JsonConvert.DeserializeObject<RootObject>(json).Users);

            return users;
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
