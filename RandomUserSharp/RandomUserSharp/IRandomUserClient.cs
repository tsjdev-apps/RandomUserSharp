using RandomUserSharp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RandomUserSharp
{
    public interface IRandomUserClient
    {
        void Dispose();
        Task<List<User>> GetRandomUsersAsync(int count = 1, Gender gender = Gender.Both, List<Nationality> natioanlitites = null, bool useLegoImages = false, string seed = null);
    }
}