using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.Collections;

namespace Calculator
{
    public interface ICalculator
    {
        String Calculate(String input);
    }

    public interface IOperation
    {
        double Operate(double left, double right);
    }

    public interface IOperationData
    {
        Char Symbol { get; }
    }

    [Export(typeof(ICalculator))]
    class Calculator : ICalculator
    {
        [ImportMany]
        IEnumerable<Lazy<IOperation, IOperationData>> operations;

        private List<int> FindOperators(string input)
        {
            List<int> operatorIndicies = new List<int>();
           
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsDigit(input[i]) && input[i] != '.') operatorIndicies.Add(i);
            }
            return operatorIndicies;
        }

        public String Calculate(string input)
        {
            double currentResult = 0;
            bool skipNextOperator = false;
            // Finds the operators.
            List<int> operators = FindOperators(input);
            if (operators.Count < 1) return "No operator was found.";

            foreach(int operatorIndex in operators)
            {
                if (skipNextOperator)
                {
                    skipNextOperator = false;
                    continue;
                }

                bool operationFound = false;
                bool negativeNumberOnTheRight = false;
                double left;
                double right;
                char operation = input[operatorIndex];
                int nextOperatorIndex = -1;
                int nextNextOperatorIndex = -1;

                // Check if this is the last operation
                if (operators.IndexOf(operatorIndex) + 1 < operators.Count)
                {
                    // Get next operation index for later calculation
                    nextOperatorIndex = operators[operators.IndexOf(operatorIndex) + 1];
                    // If the next operation is immediate and it is a minus symbol, then it is not a 'real' operation just a negative number
                    if (nextOperatorIndex - operatorIndex == 1 && input[nextOperatorIndex] == '-')
                    {
                        negativeNumberOnTheRight = true;
                        skipNextOperator = true;
                        if (operators.IndexOf(nextOperatorIndex) + 1 < operators.Count)
                        {
                            nextNextOperatorIndex = operators[operators.IndexOf(operatorIndex) + 2];
                        }
                    }
                }
                try
                {
                    // Separate out the operands.
                    if(operators.IndexOf(operatorIndex) == 0)
                    {
                        // Case for starting with a negative number (or a positive number with a '+' symbol)
                        if (operatorIndex == 0 && (operation == '-' || operation == '+')) left = 0;
                        else left = double.Parse(input.Substring(0, operatorIndex));
                    }
                    else
                    {
                        left = currentResult;
                    }
                    if(nextOperatorIndex != -1)
                    {
                        // Case for a negative number
                        if (negativeNumberOnTheRight)
                        {
                            if (nextNextOperatorIndex != -1)
                            {
                                right = double.Parse(input.Substring(operatorIndex + 2, nextNextOperatorIndex - (operatorIndex + 2)));
                                right = -right;
                            }
                            // There is no next operation, the right operand is the remaining part of the input (negative)
                            else
                            {
                                right = double.Parse(input.Substring(operatorIndex + 2));
                                right = -right;
                            }
                        }
                        else
                        {
                            right = double.Parse(input.Substring(operatorIndex + 1, nextOperatorIndex - (operatorIndex + 1)));
                        }
                    }
                    // There is no next operation, the right operand is the remaining part of the input
                    else
                    {
                        right = double.Parse(input.Substring(operatorIndex + 1));
                    }
                }
                catch
                {
                    return "Could not parse command.";
                }


                foreach (Lazy<IOperation, IOperationData> operationData in operations)
                {
                    if (operationData.Metadata.Symbol.Equals(operation))
                    {
                        currentResult = operationData.Value.Operate(left, right);
                        operationFound = true;
                        break;
                    }
                }
                if (!operationFound) return "Operation Not Found!";
            }

            return currentResult.ToString();
        }
    }
}
