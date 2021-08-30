using System.Collections.Generic;

namespace Chip8.Helpers
{
    public static class Chip8Helpers
    {
        public static byte[] GetFonts()
        {
            return new byte[] 
            {
                0xF0, 0x90, 0x90, 0x90, 0xF0, // 0 (0x050)
                0x20, 0x60, 0x20, 0x20, 0x70, // 1 (0x055)
                0xF0, 0x10, 0xF0, 0x80, 0xF0, // 2 (0x060)
                0xF0, 0x10, 0xF0, 0x10, 0xF0, // 3 (0x065)
                0x90, 0x90, 0xF0, 0x10, 0x10, // 4 (0x070)
                0xF0, 0x80, 0xF0, 0x10, 0xF0, // 5 (0x075)
                0xF0, 0x80, 0xF0, 0x90, 0xF0, // 6 (0x080)
                0xF0, 0x10, 0x20, 0x40, 0x40, // 7 (0x085)
                0xF0, 0x90, 0xF0, 0x90, 0xF0, // 8 (0x090)
                0xF0, 0x90, 0xF0, 0x10, 0xF0, // 9 (0x095)
                0xF0, 0x90, 0xF0, 0x90, 0x90, // A (0x100)
                0xE0, 0x90, 0xE0, 0x90, 0xE0, // B (0x105)
                0xF0, 0x80, 0x80, 0x80, 0xF0, // C (0x110)
                0xE0, 0x90, 0x90, 0x90, 0xE0, // D (0x115)
                0xF0, 0x80, 0xF0, 0x80, 0xF0, // E (0x120)
                0xF0, 0x80, 0xF0, 0x80, 0x80  // F (0x125)
            };
        }
    }
}
