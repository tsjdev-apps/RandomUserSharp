using NUnit.Framework;
using RandomUserSharp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomUserSharp.Tests
{
    public class Tests
    {
        private RandomUserClient _randomUserClient;

        [SetUp]
        public void Setup()
        {
            _randomUserClient = new RandomUserClient();
        }

        [Test]
        public async Task RandomUserClient_GetRandomUsersAsync_NoInput()
        {
            var users = await _randomUserClient.GetRandomUsersAsync();

            Assert.IsNotNull(users);
            Assert.AreEqual(1, users.Count);
        }

        [TestCase(1)]
        [TestCase(25)]
        [TestCase(100)]
        public async Task RandomUserClient_GetRandomUsersAsync_GetCorrespondingNumberOfUsers(int cnt)
        {
            var users = await _randomUserClient.GetRandomUsersAsync(cnt);

            Assert.IsNotNull(users);
            Assert.AreEqual(cnt, users.Count);
        }

        [Test]
        public async Task RandomUserClient_GetRandomUsersAsync_AllFieldsAreFilled()
        {
            var user = (await _randomUserClient.GetRandomUsersAsync(1)).FirstOrDefault();

            Assert.IsNotNull(user);
            Assert.IsNotNull(user.Gender);
            Assert.IsNotNull(user.Name);
            Assert.IsNotNull(user.Cell);
            Assert.IsNotNull(user.Email);
            Assert.IsNotNull(user.Phone);
            Assert.IsNotNull(user.DateOfBirth);
            Assert.IsNotNull(user.DateOfBirth.Age);
            Assert.IsNotNull(user.DateOfBirth.Date);
            Assert.IsNotNull(user.Location);
            Assert.IsNotNull(user.Location.Postcode);
            Assert.IsNotNull(user.Location.City);
            Assert.IsNotNull(user.Location.State);
            Assert.IsNotNull(user.Location.Street);
            Assert.IsNotNull(user.Location.Coordinates);
            Assert.IsNotNull(user.Location.Coordinates.Latitude);
            Assert.IsNotNull(user.Location.Coordinates.Longitude);
            Assert.IsNotNull(user.Location.Timezone);
            Assert.IsNotNull(user.Location.Timezone.Description);
            Assert.IsNotNull(user.Location.Timezone.Offset);
            Assert.IsNotNull(user.Id);
            Assert.IsNotNull(user.Id.Name);
            Assert.IsNotNull(user.Id.Value);
            Assert.IsNotNull(user.Login);
            Assert.IsNotNull(user.Login.Md5);
            Assert.IsNotNull(user.Login.Password);
            Assert.IsNotNull(user.Login.Salt);
            Assert.IsNotNull(user.Login.Sha1);
            Assert.IsNotNull(user.Login.Sha256);
            Assert.IsNotNull(user.Login.Username);
            Assert.IsNotNull(user.Login.Uuid);
            Assert.IsNotNull(user.Nationality);
            Assert.IsNotNull(user.PictureInfo);
            Assert.IsNotNull(user.PictureInfo.Large);
            Assert.IsNotNull(user.PictureInfo.Medium);
            Assert.IsNotNull(user.PictureInfo.Thumbnail);
            Assert.IsNotNull(user.Registered);
            Assert.IsNotNull(user.Registered.Age);
            Assert.IsNotNull(user.Registered.Date);
        }

        [TestCase(Gender.Male)]
        [TestCase(Gender.Female)]
        public async Task RandomUserClient_GetRandomUsersAsync_RespectGender(Gender gender)
        {
            var users = await _randomUserClient.GetRandomUsersAsync(50, gender);
            var providedGenders = users.Select(u => u.Gender).Distinct().ToList();

            Assert.IsNotNull(users);
            Assert.AreEqual(1, providedGenders.Count);
        }

        [TestCase(Nationality.AU)]
        [TestCase(Nationality.BR)]
        [TestCase(Nationality.NO)]
        public async Task RandomUserClient_GetRandomUsersAsync_RespectNationality(Nationality nationality)
        {
            var users = await _randomUserClient.GetRandomUsersAsync(50, natioanlitites: new List<Nationality> { nationality });
            var providedNationalities = users.Select(u => u.Nationality).Distinct().ToList();

            Assert.IsNotNull(users);
            Assert.AreEqual(1, providedNationalities.Count);
            Assert.AreEqual(nationality, providedNationalities.First());
        }

        [Test]
        public async Task RandomUserClient_GetRandomUsersAsync_UseLegoImages()
        {
            var users = await _randomUserClient.GetRandomUsersAsync(50, useLegoImages: true);
            var providedNationalities = users.Select(u => u.Nationality).Distinct().ToList();

            Assert.IsNotNull(users);
            Assert.AreEqual(1, providedNationalities.Count);
            Assert.AreEqual(Nationality.LEGO, providedNationalities.First());
        }

        [Test]
        public async Task RandomUserClient_GetRandomUsersAsync_GetOneUserEvenNullIsProvided()
        {
            var users = await _randomUserClient.GetRandomUsersAsync(0);

            Assert.IsNotNull(users);
        }

        [Test]
        public async Task RandomUserClient_GetRandomUsersAsync_GetSpecificUserBySeed()
        {
            var user = (await _randomUserClient.GetRandomUsersAsync(seed: "53f075655c8f5cc4")).FirstOrDefault();

            Assert.IsNotNull(user);
            Assert.AreEqual(Gender.Male, user.Gender);
            Assert.AreEqual("Mr", user.Name.Title);
            Assert.AreEqual("Célsio", user.Name.First);
            Assert.AreEqual("da Luz", user.Name.Last);
        }
    }
}
