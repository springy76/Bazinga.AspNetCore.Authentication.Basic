namespace Bazinga.AspNetCore.Authentication.Basic.Tests
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    internal class NegativeBasicCredentialVerifier : IBasicCredentialVerifier
    {
        public Task<bool> AuthenticateAsync(HttpContext context, string username, string password, ICollection<Claim> claims) => Task.FromResult(false);
    }
}
