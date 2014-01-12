using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _0x434F4445
{
    class Adler32
    {
        /// <summary>
        /// Computes the Adler32 checksum for the given data.
        /// </summary>
        /// <param name="initial">
        /// Initial value or previous result. Use 1 for the
        /// first transformation.
        /// </param>
        /// <param name="data">The data to compute the checksum of</param>
        /// <param name="start">Index of first byte to compute checksum for</param>
        /// <param name="length">Number of bytes to compute checksum for</param>
        /// <returns>The checksum of the given data</returns>
        public static byte[] ComputeChecksum(byte[] stream, int offset,
                               int length)
        {
            var adler = 1;
            var len = length;
            var NMAX = 3854;
            var BASE = 65521;
            var s1 = adler & 0xffff;
            var s2 = ((adler & 0xffff0000) >> 16) & 0xFFFF;
            var k = 0;
            var bpos = offset;
            while( len>0 ){
                k = len < NMAX ? len : NMAX;
                len -= k;
                while( k>0 ){
                    s1 = unchecked((int)s1 + stream[bpos]);
                    s2 = unchecked((int)s2 + s1);
                    bpos += 1;
                    k -= 1;
                }
                s1 = s1 % BASE;
                s2 = s2 % BASE;
            }
            return new byte[]{(byte)(s2>>8), (byte)(s2&255), (byte)(s1>>8), (byte)(s1&255)};
        }
    }
}
