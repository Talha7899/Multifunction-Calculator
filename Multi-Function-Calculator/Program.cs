/*
 Create a console-based application in C# that acts as a calculator. The application will first ask the user whether they want to use a normal calculator or a scientific calculator and will then display operations accordingly. The application will handle basic arithmetic operations for the normal calculator and include additional scientific functions for the scientific calculator.Step-by-Step Requirements:
When the application starts, prompt the user to choose between a normal calculator and a scientific calculator.
Based on the user's choice, the application should display different sets of operations.
Addition
Subtraction
Multiplication
Division
All operations from the normal calculator
Exponentiation (raising a number to the power of another)
Square root
Logarithm (base 10)
Sine, Cosine, Tangent
The user should be prompted to enter two numbers for operations like addition, subtraction, etc.
For single-number operations like square root or logarithm, ensure only one number is prompted.
Depending on the selected operation, your application should perform the calculation and display the result.
The user should have the option to perform another calculation or exit the program after each operation.
Implementation Tips:
Use switch statements or if-else chains to handle different operations.
Ensure proper error handling, especially for divisions (check for division by zero) and logarithmic calculations (positive numbers only).
Utilize the Math class in C# for scientific operations.
Challenges:
How to handle continuous use, i.e., allowing the user to perform more calculations or exit.
Implementing error handling and user input validation to ensure the program does not crash with unexpected input.
 */

double num1;
double num2;
string conform;

do
{

    Console.WriteLine("Welcome to the Multifunction Calculator!\n\nChoose your calculator type:\n1. Normal Calculator\n2. Scientific Calculator");

    Console.WriteLine("Enter your choice: ");
    int Choose = int.Parse(Console.ReadLine());
    if (Choose == 1)
    {
        Console.WriteLine("You have selected the Normal Calculator.");
        Console.WriteLine("Available Operations:");
        Console.WriteLine("1. Addition (+)\n2. Subtraction (-)\n3. Multiplication (*)\n4. Division (/)\n5. Modulus (%)");
        Console.WriteLine("Enter the number for the operation you want to perform: ");
        int op_no = int.Parse(Console.ReadLine());
        switch (op_no)
        {
            case 1:
                Console.WriteLine("You have selected Addition.");
                Console.WriteLine("Enter a first number");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter a second number");
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Addition of two numbers = {num1 + num2}");
                break;
            case 2:
                Console.WriteLine("You have selected Subtraction.");
                Console.WriteLine("Enter a first number");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter a second number");
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Subtraction of two numbers = {num1 - num2}");
                break;
            case 3:
                Console.WriteLine("You have selected Multiplication.");
                Console.WriteLine("Enter a first number");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter a second number");
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Multiplication of two numbers = {num1 * num2}");
                break;
            case 4:
                Console.WriteLine("You have selected Division.");
                Console.WriteLine("Enter a first number");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter a second number");
                num2 = double.Parse(Console.ReadLine());
                if (num2 == 0)
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                else
                {
                    Console.WriteLine($"Division of two numbers = {num1 / num2}");
                }
                break;
            case 5:
                Console.WriteLine("You have selected Remainder.");
                Console.WriteLine("Enter a first number");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter a second number");
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Remainder of two numbers = {num1 % num2}");
                break;
        }
    }
    else if (Choose == 2)
    {
        Console.WriteLine("You have selected the Scientific Calculator.");
        Console.WriteLine("Available Operations:");
        Console.WriteLine("1. Addition (+)\n2. Subtraction (-)\n3. Multiplication (*)\n4. Division (/)\n5. Modulus (%)\n6. Power (x^y)\n7. Square Root (√x)\n8. Logarithm (log)\n9. Sine (sin)\n10. Cosine (cos)\n11. Tangent (tan)\n12.PI (Π)\n13. Exponational Constant (e)\n");
        Console.WriteLine("Enter the number for the operation you want to perform: ");
        int op_no = int.Parse(Console.ReadLine());
        switch (op_no)
        {
            case 1:
                Console.WriteLine("You have selected Addition.");
                Console.WriteLine("Enter a first number");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter a second number");
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Addition of two numbers = {num1 + num2}");
                break;
            case 2:
                Console.WriteLine("You have selected Subtraction.");
                Console.WriteLine("Enter a first number");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter a second number");
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Subtraction of two numbers = {num1 - num2}");
                break;
            case 3:
                Console.WriteLine("You have selected Multiplication.");
                Console.WriteLine("Enter a first number");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter a second number");
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Multiplication of two numbers = {num1 * num2}");
                break;
            case 4:
                Console.WriteLine("You have selected Division.");
                Console.WriteLine("Enter a first number");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter a second number");
                num2 = double.Parse(Console.ReadLine());
                if (num2 == 0)
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                else
                {
                    Console.WriteLine($"Division of two numbers = {num1 / num2}");
                }
                break;
            case 5:
                Console.WriteLine("You have selected Remainder.");
                Console.WriteLine("Enter a first number");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter a second number");
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Remainder of two numbers = {num1 % num2}");
                break;
            case 6:
                Console.WriteLine("You have selected Power.");
                Console.WriteLine("Enter a base number.");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter a power number.");
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{num1} raise to the power {num2} = {Math.Pow(num1, num2)}");
                break;
            case 7:
                Console.WriteLine("You have selected Square Root.");
                Console.WriteLine("Enter a number to calculate square root.");
                double squareRoot = double.Parse(Console.ReadLine());
                Console.WriteLine($"Square Root of {squareRoot} = {Math.Sqrt(squareRoot)}");
                break;
            case 8:
                Console.WriteLine("You have selected Logarithm.");
                Console.WriteLine("Enter a number to calculate Log.");
                double log = double.Parse(Console.ReadLine());
                Console.WriteLine($"Log of {log} = {Math.Log10(log)}");
                break;
            case 9:
                Console.WriteLine("You have selected Trignometric function Sine.");
                Console.WriteLine("Enter a number to calculate value of Sine.");
                double valSine = double.Parse(Console.ReadLine());
                Console.WriteLine($"Value of Sine({valSine}) in radians = {Math.Sin(valSine)})");
                break;
            case 10:
                Console.WriteLine("You have selected Trignometric function Cosine.");
                Console.WriteLine("Enter a number to calculate value of Cosine.");
                double valCosine = double.Parse(Console.ReadLine());
                Console.WriteLine($"Value of Cosine({valCosine}) in radians = {Math.Cos(valCosine)}");
                break;
            case 11:
                Console.WriteLine("You have selected Trignometric function Tangent.");
                Console.WriteLine("Enter a number to calculate value of Tangent.");
                double valTangent = double.Parse(Console.ReadLine());
                Console.WriteLine($"Value of Tangent({valTangent}) in radians = {Math.Tan(valTangent)}");
                break;
            case 12:
                Console.WriteLine($"Value of PI = {Math.PI}");
                break;
            case 13:
                Console.WriteLine($"Value of e = {Math.E}");
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid input to select calculator type.");
    }
    Console.WriteLine("Would you like to perform another operation? (yes/no): yes");
    conform = Console.ReadLine().ToLower();
}while(conform == "yes");
Console.WriteLine("Thank you I will see you next time.");