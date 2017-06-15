using System;
namespace Chip8Sharp.System.CPU
{
    public class Chip8Memory
    {
		private byte[] MemorySpace;
        /// <summary>
		///  0x000 --> 0x1FF: CHIP8
		///  0x050 --> 0x0A0:  4px x 5px fontset
		///  0x200 --> 0xFFF:  Program ROM & Work RAM
		/// </summary>
		
        /* INITIALISE */
        public Chip8Memory(int bytesOfMemory)
        {
            MemorySpace = new byte[bytesOfMemory];
            SetupMemory();
        }
        /// <summary>
        /// Set up memory address space for the CPU
        /// </summary>
        private void SetupMemory()
        {
            
        }


        /* GET & SET MEMORY */
        public byte GetAddress(int memoryAddress)
        {
            return MemorySpace[memoryAddress];    
        }

        public byte SetAddress(int memoryAddress, byte data)
        {
            MemorySpace[memoryAddress] = data;
            return MemorySpace[memoryAddress];
        }

    }
}
