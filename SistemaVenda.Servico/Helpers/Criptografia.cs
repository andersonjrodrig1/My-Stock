using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SistemaVenda.Servico.Helpers
{
    public static class Criptografia
    {
        public static string GetStringMD5Hash(string value)
        { 
            StringBuilder sb = new StringBuilder();

            using (var hashMd5 = MD5.Create())
            {
                byte[] data = Encoding.ASCII.GetBytes(value);
                byte[] dataBytes = hashMd5.ComputeHash(data);

                for (int i = 0; i < dataBytes.Count(); i++)
                {
                    sb.Append(dataBytes[i].ToString("x2"));
                }
            }

            return sb.ToString();
        }
    }
}
