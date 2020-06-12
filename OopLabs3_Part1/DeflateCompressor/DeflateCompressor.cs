using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginsInterface;

namespace Plugins
{
    public class DeflateCompressor : IPlugin
    {
        public MemoryStream Compress(byte[] inputData)
        {
            MemoryStream outputStream = new MemoryStream();
            MemoryStream inputStream = new MemoryStream(inputData);
            using (DeflateStream compressionStream = new DeflateStream(outputStream, CompressionMode.Compress))
            {
                inputStream.CopyTo(compressionStream);
            }
                return outputStream;
        }

        public byte[] Decompress(MemoryStream compressedStream)
        {
            MemoryStream outputStream = new MemoryStream();
            using(DeflateStream decompressedStream = new DeflateStream(compressedStream, CompressionMode.Decompress))
            {
                decompressedStream.CopyTo(outputStream);
            }
            return outputStream.ToArray();
        }
    }
}
