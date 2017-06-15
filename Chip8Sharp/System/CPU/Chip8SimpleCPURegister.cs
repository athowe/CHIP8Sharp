using System;
namespace Chip8Sharp.System.CPU
{
    public class Chip8SimpleCPURegister
    {
        private byte Data;
        public Chip8SimpleCPURegister(byte data = 0)
        {
            Data = data;
        }
        public byte SetData(byte data)
        {
            Data = data;
            return Data;
        }
        public byte GetData()
        {
            return Data;
        }
    }
}
