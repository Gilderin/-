using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class EncryptionService
    {
        public static String Encrypt(String password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static Boolean Verify(String password, String hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
    }
}
