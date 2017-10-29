using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomUserSharp.Models;

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
        public async Task GetRandomUserAsync_ResultCountIsEqualToExpectedResultCount()
        {
            // arrange
            const int firstExpectedResult = 1;
            const int firstCount = 0;
            const int secondExpectedResult = 1;
            const int secondCount = 1;
            const int thirdExpectedResult = 30;
            const int thirdCount = 30;
            
            // act
            var firstUsers = await _randomUserClient.GetRandomUsersAsync(firstCount);
            var secondUsers = await _randomUserClient.GetRandomUsersAsync(secondCount);
            var thirdUsers = await _randomUserClient.GetRandomUsersAsync(thirdCount);

            // assert
            Assert.AreEqual(firstExpectedResult, firstUsers.Count);
            Assert.AreEqual(secondExpectedResult, secondUsers.Count);
            Assert.AreEqual(thirdExpectedResult, thirdUsers.Count);
        }

        [TestMethod]
        public async void GetRandomUserAsync_UserResultTakeCareOfProvidedGender()
        {
            // act
            var femaleUsers = await _randomUserClient.GetRandomUsersAsync(20, Gender.Female);
            var maleUsers = await _randomUserClient.GetRandomUsersAsync(20, Gender.Male);            
            var femaleGenders = femaleUsers.Select(u => u.Gender).Distinct().ToList();
            var maleGenders = maleUsers.Select(u => u.Gender).Distinct().ToList();

            // arrange
            Assert.AreEqual(1, femaleGenders.Count);
            Assert.AreEqual(1, maleGenders.Count);
            Assert.AreEqual(Gender.Female, femaleGenders.Single());
            Assert.AreEqual(Gender.Male, maleGenders.Single());
        }
    }
}
