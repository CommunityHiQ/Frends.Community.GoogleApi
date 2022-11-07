using Google.Apis.Auth.OAuth2;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Frends.Community.GoogleApi
{
    /// <summary>
    /// Read email.
    /// </summary>
    public class GoogleApiTasks
    {
        /// <summary>
        /// Get Access Token for Service Account. See https://github.com/CommunityHiQ/Frends.Community.GoogleApi
        /// </summary>
        /// <param name="input">Information for fetching access token.</param>
        /// <param name="cancellationToken">Automatically passed by Frends. Interrupts Task execution if Process is terminated.</param>
        /// <returns>Object{ string AccessToken }</returns>
        public static async Task<Result> GetServiceAccountAccessToken([PropertyTab] Input input, CancellationToken cancellationToken)
        {
            string accessToken = string.Empty;
            using (var stream = GenerateStreamFromString(input.SecretJson))
            {
                var credential = GoogleCredential.FromStream(stream)
                                                 .CreateScoped(input.Scopes)
                                                 .UnderlyingCredential as ServiceAccountCredential;

                accessToken = await credential.GetAccessTokenForRequestAsync(null, cancellationToken);
            }
            return new Result { AccessToken = accessToken };
        }

        private static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
