using System.Diagnostics;

int result = Fibonacci(5);
Console.WriteLine(result);

static int Fibonacci(int n)
{
    int n1 = 0;
    int n2 = 1;
    int sum;
Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
Debug.WriteLine($"We are looking for the {n}th number");
    for (int i = 2; i <= n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
        Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");
    }
Debug.WriteLine("Set the breakpoint below this line and step through the code to observe variable values.");

    return n == 0 ? n1 : n2;
    
}

//code copied from https://learn.microsoft.com/en-us/training/modules/dotnet-debug/4-use-visual-studio-code-debugger
// This program calculates the nth Fibonacci number using an iterative approach.
// The Fibonacci sequence is a series of numbers where each number is the sum of the two preceding ones, usually starting with 0 and 1.
// For example, the first six numbers in the Fibonacci sequence are: 0, 1, 1, 2, 3, 5.
// The Fibonacci function takes an integer n as input and returns the nth Fibonacci number.

//For the solution: The loop originally was not counting up to the number given but instead stopped one number early. I changed the loop condition from i < n to i <= n.