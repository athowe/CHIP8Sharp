![logo](Resources/Logo/Chip8Logo-[4096-x-4096].gif)

#CHIP8# (Or Chip8Sharp)
CHIP8# is a library created in C# to help me learn about emulation and lower level programming, as well as things like how hardware deals with memory.

#About the CHIP8
CHIP8 is an interpreted programming language from the 70s which was used in several home micro computers. They are very simple machines and an ideal target for a first emulation project - even if people think it's badly designed! [Read more about CHIP8 here](https://en.wikipedia.org/wiki/CHIP-8).

There was also an extension, SUPERCHIP, later released.

#About the author
I have been programming for almost 15 years, but always as a hobbyist, mainly in web dev (PHP, JS, (X)HTML) and usually never finishing projects. So go lightly on me if I make mistakes! I'm new to emulation and not super well versed in C#, although it is my desktop language of choice (even as a Mac user ;) )

As a note, this will be primarily tested on OS X. This should mean it'll run on anything that uses Mono, but let me know if there are any cross platform issues.

#Project goals
1. Learn emulation programming
2. Learn about how hardware works
3. Be a "drop in, ready to go" library that is not dependent on the frontend
3. Do it "C# style" (no int i = 0; where I can avoid it, always strive for readable names - int Counter = 0;) - verbose and easy to read over less space taken up. Abstract where it makes sense and is possible.
4. Create a frontend that can take advantage of the library I have created here
5. Be fully dyanmic on tech specs! If you wanna boot up Chip8Sharp with 16K of memory, that's no problem!'
6. Finish the project! ;)
7. Possibly RetroArch support?
8. SuperChip support

#Can I use this code for...?
Yes, absolutely. Commercial, open source purposes, whatever. I have put this up so you can do what you like with it :)

#How to read comments
~~~~
/* THIS IS A HEADER */
// This is usage instructions
/// This is descriptive or useful information
~~~~

~~~~
/* HELLO WORLD PROGRAM */
public class HelloWorld
{
    // Output hello world message
    public HelloWorld()
    {
        Console.Log("Hello, world!");
        /// uses Console.Log to output "Hello, world!" to the terminal
    }
}
~~~~
Hopefully my comments are less inane than that, though ;)

#Thanks and resources
1. [MultiGesture - how to write a CHIP8 emulator](http://www.multigesture.net/articles/how-to-write-an-emulator-chip-8-interpreter/)