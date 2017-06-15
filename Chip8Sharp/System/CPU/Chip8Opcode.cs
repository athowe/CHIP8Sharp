using System;
namespace Chip8Sharp.System.CPU
{
    public class Chip8Opcode
    {
        private ushort CurrentCode;
        public Chip8Opcode(ushort currentCode = 0)
        {
            CurrentCode = currentCode;
        }
        public ushort GetOpcode()
        {
            return CurrentCode;  
        }
        public ushort SetOpcode(ushort newCode)
        {
            CurrentCode = newCode;
            return CurrentCode;
        }
    }
}
