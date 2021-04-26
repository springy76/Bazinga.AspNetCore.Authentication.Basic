using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Bazinga.AspNetCore.Authentication.Basic
{
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// Basic Credentials Verifier
    /// </summary>
    public interface IBasicCredentialVerifier
    {
        /// <summary>
        /// Verifies the credentials received via Basic Authentication
        /// </summary>
        /// <param name="context">The HttpContext for this request.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="claims">Opportunity to store additional claims.</param>
        /// <returns></returns>
        Task<bool> AuthenticateAsync(HttpContext context, string username, string password, ICollection<Claim> claims);
    }
}
