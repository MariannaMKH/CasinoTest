using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Helper
    {

        private static Random random = new Random();

        public static int GetRandomNumber(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }

        public static string ComputeHash(string password, long salt)
        {
            string data = string.Format("{0}_{1}_{0}", password, salt);
            using (var sha256 = new SHA256Managed())
            {
                var hashArray = sha256.ComputeHash(Encoding.ASCII.GetBytes(data));
                return string.Concat(Array.ConvertAll(hashArray, b => b.ToString("x2")));
            }
        }
    }
}
