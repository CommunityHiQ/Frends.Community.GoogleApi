using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Frends.Community.GoogleApi.Tests
{
    [TestFixture]
    public class UnitTests
    {

        private readonly string _secretJson = Environment.GetEnvironmentVariable("GoogleApiSecretJson");

        [Test]
        public async Task GetAccessTokenTest()
        {
            var input = new Input
            {
                SecretJson = _secretJson,
                Scopes = new string[1] { "userinfo.profile" }
            };
            var result = await GoogleApiTasks.GetServiceAccountAccessToken(input, new CancellationToken());
            Assert.IsNotNull(result.AccessToken);
        }
    }
}
