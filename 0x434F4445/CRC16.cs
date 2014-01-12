using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0x434F4445
{
    class CRC16
    {
        const ushort polynomial = 0xA001;
        ushort[] table = new ushort[256];
        
        public int ComputeChecksum(byte[] bytes) {
            int crc = 0;
            for(int i = 0; i < bytes.Length; ++i) {
                byte index = (byte)(crc ^ bytes[i]);
                crc = (ushort)((crc >> 8) ^ table[index]);
            }
            return crc;
        }
        
        public byte[] ComputeChecksumBytes(byte[] bytes) {
            int crc = ComputeChecksum(bytes);
            return BitConverter.GetBytes(crc);
        }
        
        public void Crc16() {
            ushort value;
            ushort temp;
            for(ushort i = 0; i < table.Length; ++i) {
                value = 0;
                temp = i;
                for(byte j = 0; j < 8; ++j) {
                    if(((value ^ temp) & 0x0001) != 0) {
                        value = (ushort)((value >> 1) ^ polynomial);
                    }else {
                        value >>= 1;
                    }
                    temp >>= 1;
                }
                table[i] = value;
            }
        }
    }
}
