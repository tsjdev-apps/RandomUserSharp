using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RandomUserSharp.Tests
{
    [TestClass]
    public class RandomUserClientTests
    {
        private RandomUserClient _randomUserClient;

        [TestInitialize]
        public void Initialize()
        {
            _randomUserClient = new RandomUserClient();
        }

        [TestCleanup]
        public void Cleanupo()
        {
            _randomUserClient.Dispose();
            _randomUserClient = null;
        }

        [TestMethod]
        public async Task GetRandomUserAsync()
        {
            var expectedResult = 1;
            var count = 0;

            var users = await _randomUserClient.GetRandomUsersAsync(count);

            Assert.AreEqual(expectedResult, users.Count);
        }
    }
}
