using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public class Struct38
    {
        public Struct38(BitReader reader)
        {
            num = reader.ReadUInt16();
            for(var i = 0; i < num; i++)
            {
                field0s.Add(reader.ReadByte());
            }
        }
        public UInt16 num;
        public List<Byte> field0s = new List<Byte>();
    }
}