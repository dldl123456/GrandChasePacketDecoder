using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrandChasePacketDecoder
{
    static class Util
    {
        public static byte[] str2hex(string value)
        {
            value = value.Replace(" ", ""); // 일반 스페이스
            value = value.Replace(":", ""); // 와이어샤크
            value = value.Trim();

            byte[] temp = new byte[value.Length / 2];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = Convert.ToByte(value.Substring(i * 2, 2), 16);
            }

            return temp;
        }

        public static string hex2str(byte[] value)
        {
            StringBuilder sb = new StringBuilder();

            if (value == null || value.Length == 0)
            {
                sb.Append("(Empty)");
            }
            else
            {
                foreach (byte b in value)
                {
                    sb.AppendFormat("{0:X2} ", b);
                }
            }

            return sb.ToString();
        }

        public static byte[] ReadBytes(byte[] source, int offset, int length)
        {
            byte[] outputBytes = new byte[length];
            Buffer.BlockCopy(source, offset, outputBytes, 0, length);

            return outputBytes;
        }

        public static byte[] ConcatBytes(byte[] firstBytes, byte[] secondBytes)
        {
            byte[] outputBytes = new byte[firstBytes.Length + secondBytes.Length];

            Buffer.BlockCopy(firstBytes, 0, outputBytes, 0, firstBytes.Length);
            Buffer.BlockCopy(secondBytes, 0, outputBytes, firstBytes.Length, secondBytes.Length);

            return outputBytes;
        }
    }
}
