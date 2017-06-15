using System;
namespace Chip8Sharp.System.CPU
{
    public class Chip8CPU
    {
        /* OPCODES */
        private Chip8Opcode OpCode;

        /* MEMORY */
        private Chip8Memory Memory;

        /* ON SCREEN GRAPHICS */
        private Chip8OnScreenGraphics OnScreenGraphics;

        /* REGISTERS */
        private byte[] CPURegister; //aka V0 --> VE
        private Chip8SimpleCPURegister IndexRegister; // aka I
        private Chip8SimpleCPURegister ProgramCounter; // aka pc
        private Chip8Timer DelayTimer;
        private Chip8Timer SoundTimer;
        private Chip8Stack Stack;
        private byte[] HexKeypad;

        // Chip8CPU = new Chip8CPU(4096, 64, 32, 16);
        // 4K of memory, 64px wide 32px high, 16 high stack
        public Chip8CPU(int memoryLimit = 4096, int resolutionWidth = 64, int resolutionHeight = 32, int stackLimit = 16)
        {
            Memory = new Chip8Memory(memoryLimit); //4K
            OnScreenGraphics = new Chip8OnScreenGraphics(resolutionWidth, resolutionHeight);
            Stack = new Chip8Stack(stackLimit);
            OpCode = new Chip8Opcode(0);
            IndexRegister = new Chip8SimpleCPURegister(0);
            ProgramCounter = new Chip8SimpleCPURegister(0);

            HexKeypad = new byte[16];
            CPURegister = new byte[16];
        }

        public ushort SetOpcode(ushort opcode)
        {
            return OpCode.SetOpcode(opcode);
        }
        public ushort GetOpcode()
        {
            return OpCode.GetOpcode();
        }

        public byte GetMemory(int memoryAddress)
        {
            return Memory.GetAddress(memoryAddress);
        }
        public byte SetMemory(int memoryAddress, byte data)
        {
            return Memory.SetAddress(memoryAddress, data);
        }

        public byte GetIndexRegister()
        {
            return IndexRegister.GetData();
        }
        public byte SetIndexRegister(byte data)
        {
            return IndexRegister.SetData(data);
        }
        public byte GetProgramCounter()
        {
            return ProgramCounter.GetData();
        }
        public byte SetProgramCounter(byte data)
        {
            return ProgramCounter.SetData(data);
        }
    }
}
