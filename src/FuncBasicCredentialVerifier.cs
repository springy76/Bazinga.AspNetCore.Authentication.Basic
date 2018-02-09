using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Bazinga.AspNetCore.Authentication.Basic
{
    internal class FuncBasicCredentialVerifier : IBasicCredentialVerifier
    {
        private readonly Func<(string username, string password), Task<bool>> _func;

        public FuncBasicCredentialVerifier(Func<(string username, string password), Task<bool>> func)
        {
            _func = func ?? throw new ArgumentNullException(nameof(func));
        }

        public Task<bool> Authenticate(string username, string password, ICollection<Claim> claims)
        {
            return _func((username, password));
        }
    }
}