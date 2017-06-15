using System;
namespace Chip8Sharp.System.CPU
{
    public class Chip8Stack
    {
        private StackLimit;
        private ushort[] Stack;
        private ushort StackCounter;

        public Chip8Stack(int stackLimit)
        {
            Stack = new ushort[stackLimit];
        }
        public ushort GetStackCounter()
        {
            return StackCounter;   
        }
        public ushort GetStack(int stackIndex)
        {
            return Stack[stackIndex];
        }
        public ushort SetStack(int stackIndex, ushort data)
        {
            Stack[stackIndex] = data;
            return Stack[stackIndex];
        }
    }
}
