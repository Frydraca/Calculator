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
            // Finds the operator.
            List<int> operators = FindOperators(input);
            if (operators.Count < 1) return "No operator was found.";

            foreach(int operatorIndex in operators)
            {
                bool operationFound = false;
                double left;
                double right;
                char operation = input[operatorIndex];
                int nextOperatorIndex = operators.IndexOf(operatorIndex) + 1;
                try
                {
                    // Separate out the operands.
                    if(operators.IndexOf(operatorIndex) == 0)
                    {
                        if (operatorIndex == 0 && (operation == '-' || operation == '+')) left = 0;
                        else left = double.Parse(input.Substring(0, operatorIndex));
                    }
                    else
                    {
                        left = currentResult;
                    }
                    if(nextOperatorIndex < operators.Count)
                    {
                        right = double.Parse(input.Substring(operatorIndex + 1, operators[nextOperatorIndex] - (operatorIndex + 1)));
                    }
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
