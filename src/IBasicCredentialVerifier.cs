using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Bazinga.AspNetCore.Authentication.Basic
{
    /// <summary>
    /// Basic Credentials Verifier
    /// </summary>
    public interface IBasicCredentialVerifier
    {
        /// <summary>
        /// Verifies the credentials received via Basic Authentication
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="claims">Opportunity to store additional claims.</param>
        /// <returns></returns>
        Task<bool> Authenticate(string username, string password, ICollection<Claim> claims);
    }
}
