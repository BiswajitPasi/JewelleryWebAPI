using System.Security.Cryptography;
using System.Text;

namespace JewelleryWebAPI.Tools
{
    public class HPasssword
    {
        public static string hashPassword(string password)
        {
           var sha=SHA256.Create();
           var asByteArray=Encoding.Default.GetBytes(password);
            var hasedPassword= sha.ComputeHash(asByteArray);
            return Convert.ToBase64String(hasedPassword);
        }
    }
}
