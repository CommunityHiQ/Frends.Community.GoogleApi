using System.ComponentModel;

namespace Frends.Community.GoogleApi
{
    /// <summary>
    /// Input-class for GetServiceAccountAccessToken-Task.
    /// </summary>
    public class Input
    {
        /// <summary>
        /// Service account connection information in JSON format.
        /// </summary>
        [PasswordPropertyText]
        public string SecretJson { get; set; }

        /// <summary>
        /// Scopes to which you can access with the access token.
        /// </summary>
        public string[] Scopes { get; set; }
    }

    /// <summary>
    /// Result-class for GetServiceAccountAccessToken-Task.
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Service accounts access token.
        /// </summary>
        public string AccessToken { get; set; }
    }
}
