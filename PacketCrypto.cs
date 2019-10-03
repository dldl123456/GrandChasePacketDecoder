using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO.Compression;
using System.IO;

namespace GrandChasePacketDecoder
{
    public static class PacketCrypto
    {
        public static readonly byte[] GC_DES_KEY = { 0xC7, 0xD8, 0xC4, 0xBF, 0xB5, 0xE9, 0xC0, 0xFD };
        public static readonly byte[] GC_HMAC_KEY = { 0xC0, 0xD3, 0xBD, 0xC3, 0xB7, 0xCE, 0xB8, 0xB8 };
        public static readonly byte GC_HMAC_SIZE = 10;

        public static byte[] DecryptAll(byte[] packetBuffer, byte[] key)
        {
            byte[] packet;
            packet = DecryptPacket(packetBuffer, key);

            if (packet[6] == 1)
                packet = UncompressPacket(packet);

            return packet;
        }

        public static byte[] DecryptPacket(byte[] packetBuffer, byte[] key)
        {
            byte[] IV = Util.ReadBytes(packetBuffer, 8, 8);

            using (DESCryptoServiceProvider desProvider = new DESCryptoServiceProvider())
            {
                desProvider.Mode = CipherMode.CBC;
                desProvider.Padding = PaddingMode.None;

                using (ICryptoTransform decryptor = desProvider.CreateDecryptor(key, IV))
                {
                    byte[] rawData = decryptor.TransformFinalBlock(packetBuffer, 16, packetBuffer.Length - GC_HMAC_SIZE - 16);

                    return Util.ReadBytes(rawData, 0, (rawData.Length - (rawData[rawData.Length - 1] + 2)));
                }
            }
        }

        public static byte[] UncompressPacket(byte[] packetToUncompress)
        {
            byte[] first = Util.ReadBytes(packetToUncompress, 0, 11);
            byte[] secondBefore = Util.ReadBytes(packetToUncompress, 11, (packetToUncompress.Length - 11));
            byte[] secondAfter = DecompressData(secondBefore);

            return Util.ConcatBytes(first, secondAfter);
        }

        public static byte[] DecompressData(byte[] buffer)
        {
            MemoryStream resultStream = new MemoryStream();
            using ( MemoryStream ms = new MemoryStream(buffer) ) {
                using ( DeflateStream ds = new DeflateStream(ms, CompressionMode.Decompress) ) {
                    ds.CopyTo(resultStream);
                    ds.Close();
                }
            }
            Byte[] decompressedByte = resultStream.ToArray();
            resultStream.Dispose();
            return decompressedByte;
        }
    }
}
