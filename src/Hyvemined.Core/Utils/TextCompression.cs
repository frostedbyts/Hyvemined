using System.Buffers.Text;
using System.IO.Compression;
using System.Text;

namespace Hyvemined.Core.Utils
{
    public static class TextCompression
    {
        public static string Compress(this string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            using(MemoryStream input = new MemoryStream(bytes))
            using(MemoryStream output = new MemoryStream())
            {
                using(GZipStream gzip = new GZipStream(output, CompressionMode.Compress))
                {
                    input.CopyTo(gzip);
                }
                return Convert.ToBase64String(output.ToArray());
            }
        }

        public static string Decompress(this string str)
        {
            byte[] bytes = Convert.FromBase64String(str);
            using(MemoryStream input = new MemoryStream(bytes))
            using(MemoryStream output = new MemoryStream())
            {
                using(GZipStream gzip = new GZipStream(input, CompressionMode.Decompress))
                {
                    gzip.CopyTo(output);
                }
                return Encoding.UTF8.GetString(output.ToArray());
            }
        }
    }
}
