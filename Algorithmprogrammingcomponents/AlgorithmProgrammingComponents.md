Algorithm programming components:

Algorithm: set of rules for solving a problem or accomplishing a task.

Characteristics of a Good Algorithm: 
   -Correctness: the algorithm should be solve the problem correct 
   -Efficiency: the algorithm should be run in a reasonable amount of time
   -Clarity:  the algorithm should be easy to understand and implement
   -Finiteness: the algorithm should be have end
   -Generality: the algorithm should be work for multiple inputs 


Types of Algorithms:
   -Sequential Algorithm (Step-by-step Execution): algorithm that follows a fixed sequence of steps. execution: Steps in a Sequential Algorithm
            1.Start: Define the starting point of the process.
            2.Input: Collect data required for the algorithm.
            3.Processing: Perform operations or computations in sequence.
            4.Output: Display or store the result.
            5.End: Terminate the process.
   Example of a Sequential Algorithm
        Problem: Calculate the area of a rectangle.
            1.Start
            2.Input the length (L) and width (W) of the rectangle.
            3.Compute the area: Area = L - W.
            4.Output the area.
            5.End
   -Iterative Algorithm (Using Loops):  repeats a process multiple times using loops. 
   How Iterative Algorithms Work:
            1.Initialize variables
            2.Set up a loop with a condition
            3.Update variables in each iteration
            4.Check the condition and repeat or exit
    Example of a Iterative Algorithm (Using Loops): 
            int Factorial(int n) 
            { 
               int result = 1; 
               for (int i = 1; i <= n; i++)  
               { 
                 result *= i 
                 } 
                     return result; 
            }     
   -Recursive Algorithm (Function Calls Itself): algorithm that solves a problem by calling itself with a smaller input. 
   How Recursive Algorithms Work
            1. If the number is 0 or 1, return 1. 
            2. Otherwise, multiply the number by the factorial of (number - 1). 
            3. Keep calling itself until reaching 1.
    Example of a Recursive Algorithm (Function Calls Itself):
            int Factorial(int n)  
            { 
               if (n == 0 || n == 1) return 1;   
               return n * Factorial(n - 1); 
                }

