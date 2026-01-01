// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// What is happening to my code after I hit "Run"?
// 1. The C# compiler (csc) takes your source code (Program.cs) and compiles it into an Intermediate Language (IL) code, producing an assembly (a .dll or .exe file).
// 2. When you run the program, the .NET runtime's Just-In-Time (JIT) compiler converts the IL code into native machine code specific to your operating system and hardware.
// 3. Finally, the native machine code is executed by your computer's CPU, resulting in the output you see in the console.
// This process allows C# to be platform-independent, as the same IL code can be run on any platform that has a compatible .NET runtime.


// What is .NET?
// .NET is a free, open-source developer platform created by Microsoft for building a wide range
//.NET is the environment in which C# code runs. It provides the necessary libraries, runtime, and tools to develop and execute applications across different platforms, including Windows, macOS, and Linux. 

// What is C#?
// C# (pronounced "C-sharp") is a modern, object-oriented programming language developed by Microsoft. It is designed for building a variety of applications that run on the .NET framework. C# is known for its simplicity, versatility, and strong type safety, making it a popular choice for developing web, desktop, mobile, and game applications.

//In short, C# is the language you write your code in, and .NET is the platform that allows your C# code to run.

//C# is object-oriented, which means it is based on "objects" that encapsulate data and behavior. This approach promotes code reusability, modularity, and maintainability. C# supports key object-oriented principles such as inheritance, polymorphism, encapsulation, and abstraction.

// The code above is held within a method called Main.
// A method is a block of code that performs a specific task. The Main method is the entry point of a C# console application, where the program starts executing.
// This method is held within a class. A class is a blueprint for creating objects and defines properties and behaviors that the objects created from the class will have. The class here is named Program.
//The code is below but includes the hidden structure:
/*

using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

*/