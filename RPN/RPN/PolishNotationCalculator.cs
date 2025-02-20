using System;
using System.Windows.Forms.VisualStyles;

namespace RPN
{
    public class PolishNotationCalculator
    {
        /* Use the IStack<double> interface type to allow the flexibility of using different stack implementations 
         * (e.g., ArrayStack or LinkedListStack). */
        private IStack<double> stack;

        public PolishNotationCalculator(IStack<double> stackImplementation)
        {
            stack = stackImplementation;
        }

        public double Evaluate(string expression)
        {

            /*
             * 1. Split the expression into individual tokens using a space as the delimiter.
             * 2. Iterate over each token:
             *      - If the token is a number, push it onto the stack.
             *      - If the token is an operator (+, -, *, /):
             *          a. Pop two numbers from the stack (b first, then a).
             *          b. Perform the operation (a + b, a - b, etc.).
             *          c. Push the result back onto the stack.
             * 3. After processing all tokens, the result of the calculation will be the single number remaining on the stack.
             *    Pop and return it as the final result.
             */

            var stack = new ArrayStack<double>(expression.Length);
            string[] tokens = expression.Split(' ');

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double number)) //parses the value to be a double
                {
                    stack.Push(number);
                }
                else
                {
                    double b = stack.Pop();
                    double a = stack.Pop();

                    switch (token) //changes the mathematical operation depending on operation used in the formula
                    {
                        case "+":
                            stack.Push(a + b);
                            break;
                        
                        case "-":
                            stack.Push(a - b);
                            break;

                        case "*":
                            stack.Push(a * b);
                            break;

                        case "/":
                            if(b == 0)
                                throw new DivideByZeroException("Cannot divide by zero"); //prevents the user from dividing by 0
                            stack.Push(a / b);
                            break;

                        default:
                            throw new InvalidOperationException($"Invalid token: {token}");
                    }
                }
            }

            return stack.Pop();
        }
    }
}
