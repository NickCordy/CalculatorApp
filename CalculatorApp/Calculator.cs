using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Calculator
    {
        public enum Operation {
            NONE, ADD, SUBTRACT, MULTIPLY, DIVIDE,
        }
        public Operation operation { get; set; } = Operation.NONE;
        public string firstNumber { get; set; } = string.Empty;
        public string secondNumber { get; set; } = string.Empty;

        public void AppendToNumber(string digit)
        {
            if (operation == Operation.NONE)
            {
                if (digit == "." && firstNumber.Contains("."))
                {
                    return;
                }

                firstNumber += digit;
            }
            else
            {
                if (digit == "." && secondNumber.Contains("."))
                {
                    return;
                }

                secondNumber += digit;
            }
        }

        public void Calculate()
        {
            double result = 0;
            string resultStr;

            if (secondNumber != string.Empty)
            {
                switch (operation)
                {
                    case Operation.ADD:
                        result = Add();
                        break;
                    case Operation.SUBTRACT:
                        result = Subtract();
                        break;
                    case Operation.MULTIPLY:
                        result = Multiply();
                        break;
                    case Operation.DIVIDE:
                        result = Divide();
                        break;
                }

                resultStr = result.ToString();
                firstNumber = resultStr;
                secondNumber = string.Empty;
                operation = Operation.NONE;
            }
        }

        public void Clear()
        {
            operation = Operation.NONE;
            firstNumber = string.Empty;
            secondNumber = string.Empty;
        }

        public void ClearEntry()
        {
            if (operation == Operation.NONE)
            {
                firstNumber = string.Empty;
            }
            else
            {
                secondNumber = string.Empty;
            }
        }

        public void Percent()
        {
            if (secondNumber != string.Empty)
            {
                secondNumber = (double.Parse(secondNumber) / 100).ToString();
            }
        }

        public double Add()
        {
            return double.Parse(firstNumber) + double.Parse(secondNumber);
        }

        public double Subtract()
        {
            return double.Parse(firstNumber) - double.Parse(secondNumber);
        }

        public double Multiply()
        {
            return double.Parse(firstNumber) * double.Parse(secondNumber);
        }

        public double Divide()
        {
            return double.Parse(firstNumber) / double.Parse(secondNumber);
        }

        public void Square()
        {
            if (operation == Operation.NONE)
            {
                firstNumber = (double.Parse(firstNumber) * double.Parse(firstNumber)).ToString();
            }
            else
            {
                secondNumber = (double.Parse(secondNumber) * double.Parse(secondNumber)).ToString();
            }
        }

        public void SquareRoot()
        {
            if (firstNumber != string.Empty)
            {
                if (operation == Operation.NONE)
                {
                    firstNumber = Convert.ToString(Math.Sqrt(Convert.ToDouble(firstNumber)));
                }
                else
                {
                    secondNumber = Convert.ToString(Math.Sqrt(Convert.ToDouble(secondNumber)));
                }
            }
        }

        public void Negate()
        {
            if (operation == Operation.NONE && firstNumber != string.Empty)
            {
                firstNumber = (-double.Parse(firstNumber)).ToString();
            }
            else if (secondNumber != string.Empty)
            {
                secondNumber = (-double.Parse(secondNumber)).ToString();
            }
        }

        public void Reciprocal()
        {
            if (firstNumber != string.Empty)
            {
                if (operation == Operation.NONE)
                {
                    firstNumber = Convert.ToString(1 / Convert.ToDouble(firstNumber));
                }
                else
                {
                    secondNumber = Convert.ToString(1 / Convert.ToDouble(secondNumber));
                }
            }
        }

        public void Backspace()
        {
            if (operation == Operation.NONE && secondNumber == string.Empty)
            {
                firstNumber = firstNumber.Remove(firstNumber.Length - 1, 1);

                if (firstNumber == "-")
                {
                    firstNumber = string.Empty;
                }
            }
            else if (secondNumber != string.Empty)
            {
                secondNumber = secondNumber.Remove(secondNumber.Length - 1, 1);

                if (secondNumber == "-")
                {
                    secondNumber = string.Empty;
                }
            }
        }
    }
}
