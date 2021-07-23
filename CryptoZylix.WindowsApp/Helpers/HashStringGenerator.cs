using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoZylix.WindowsApp.Helpers
{
    public static class HashStringGenerator
    {
        public static string GenerateHashSha256(this string stringHash)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(stringHash));
                return Convert.ToBase64String(hash);
            }
        }
    }
}
