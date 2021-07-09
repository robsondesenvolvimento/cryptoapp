using CryptoZylix.WindowsApp.Models;
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoZylix.WindowsApp.Services
{
    class DataProtectService
    {
        private readonly IDataProtector _protector;
        private readonly string keyName = "9f726ebf-b21f-42a3-8f93-83f870814612";

        // the 'provider' parameter is provided by DI
        public DataProtectService(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector(keyName);
        }

        public string ProtectedData(string input)
        {
            string protectedPayload = _protector.Protect(input);
            return protectedPayload ?? "Não foi possivel proteger o dado.";
        }

        public string UnProtectedData(string protectedPayload)
        {
            string unprotectedPayload = _protector.Unprotect(protectedPayload);
            return unprotectedPayload ?? "Não foi possivel reverter a criptografia";
        }
    }
}
