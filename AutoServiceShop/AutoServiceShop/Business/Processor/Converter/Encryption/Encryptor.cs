using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Encryption
{
    public sealed class Encryptor
    {
        public static string StringGen()
        {
            string output = Guid.NewGuid().ToString();

            SHA512(output);

            return output;
        }

        public static string SHA512(string input)
        {
            string saltString = Startup.StaticConfig.GetSection("Salt").Value;

            byte[] salt = Encoding.ASCII.GetBytes(saltString);

            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: input,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA512,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
        }
    }
}
