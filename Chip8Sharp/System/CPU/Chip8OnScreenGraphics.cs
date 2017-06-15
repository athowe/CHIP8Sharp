using System;
namespace Chip8Sharp.System.CPU
{
    public class Chip8OnScreenGraphics
    {
        private byte[] ScreenSpace;
        /// <summary>
        /// 1 byte per pixel, 0 = black, 1 = white
        /// </summary>
        private int TotalPixels;
        private int ResolutionWidth;
        private int ResolutionHeight;
        /// <summary>
        /// All in pixels
        /// </summary>

        public Chip8OnScreenGraphics(int resolutionWidth, int resolutionHeight)
        {
            ResolutionWidth = resolutionWidth;
            ResolutionHeight = resolutionHeight;
            TotalPixels = ResolutionWidth * ResolutionHeight;
            ScreenSpace = new byte[TotalPixels];
        }
        public byte GetByte(int index)
        {
            return ScreenSpace[index];    
        }
        public byte SetByte(int index, byte data)
        {
            ScreenSpace[index] = data;
            return ScreenSpace[index];  
        }
    }
}
