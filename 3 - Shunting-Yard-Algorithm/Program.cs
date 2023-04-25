using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

public class ShuntingYard
{
    //Set the priority of the operator
    private static Dictionary<char, int> operators = new Dictionary<char, int>()
    {
        { '+', 2 },
        { '-', 2 },
        { '*', 3 },
        { '/', 3 },
        { '%', 3 },
        { '^', 4 },
    };

    public static string ConvertToPostfix(string infix)
    {
        string postfix = "";
        string number = "";

        List<char> operatorList = new List<char>();


        for (int i = 0; i < infix.Length; i++)
        {
            char c = infix[i];

            //if it is a digit or a dot e part of a number
            if (Char.IsDigit(c) || c == '.')
            {
                number += c;
            }
            //If it is a operator
            else if (operators.ContainsKey(c))
            {
                postfix += number + " ";
                number = "";

                //if the the last operator as hghier priority whe put it´on the postfix
                while (operatorList.Count > 0 && operatorList[operatorList.Count - 1] != '(' && operators[c] <= operators[operatorList[operatorList.Count - 1]])
                {
                    postfix += operatorList[operatorList.Count - 1] + " ";
                    operatorList.RemoveAt(operatorList.Count - 1);
                }

                operatorList.Add(c);
            }
            else if (c == '(')
            {
                operatorList.Add(c);
            }
            //If it is a close parenthesis whe put everthing in posfix variable
            else if (c == ')')
            {
                postfix += number + " ";
                number = "";

                while (operatorList.Count > 0 && operatorList[operatorList.Count - 1] != '(')
                {
                    postfix += operatorList[operatorList.Count - 1] + " ";
                    operatorList.RemoveAt(operatorList.Count - 1);
                }

                if (operatorList.Count == 0 || operatorList[operatorList.Count - 1] != '(')
                {
                    throw new ArgumentException("Mismatched parentheses");
                }

                operatorList.RemoveAt(operatorList.Count - 1);
            }
            else if (Char.IsWhiteSpace(c))
            {
                // ignore whitespace
            }
            else
            {
                throw new ArgumentException("Invalid character in input");
            }
        }

        postfix += number + " ";

        while (operatorList.Count > 0)
        {
            if (operatorList[operatorList.Count - 1] == '(' || operatorList[operatorList.Count - 1] == ')')
            {
                throw new ArgumentException("Mismatched parentheses");
            }

            postfix += operatorList[operatorList.Count - 1] + " ";
            operatorList.RemoveAt(operatorList.Count - 1);
        }

        return postfix.TrimEnd();
    }
    public static string ConvertToPrefix(string infix)
    {
        // Reverse the infix expression
        char[] reversed = infix.ToCharArray();
        Array.Reverse(reversed);
        infix = new string(reversed);

        // Replace open and closed parentheses with their counterparts
        infix = infix.Replace('(', '\u0001');
        infix = infix.Replace(')', '(');
        infix = infix.Replace('\u0001', ')');

        // Convert to postfix notation
        string postfix = ConvertToPostfix(infix);

        // Reverse the postfix expression to get prefix notation
        string[] tokens = postfix.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(tokens);
        return string.Join(" ", tokens);
    }

    public static double PostfixEvaluator(string postfix)
    {
        List<double> tokens = new List<double>();
        string number = string.Empty;
        foreach (char c in postfix.ToCharArray())
        {
            if (Char.IsDigit(c) || c == '.')
            {
                number += c;
            }
            else if (Char.IsWhiteSpace(c) && !string.IsNullOrEmpty(number))
            {
                if (!double.TryParse(number, out double dbl_number))
                {
                    Console.WriteLine($"Error parsing the number {number}");
                }
                tokens.Add(dbl_number);
                number = "";
            }
            else if (operators.ContainsKey(c))
            {
                double num2 = tokens[tokens.Count - 1];
                tokens.RemoveAt(tokens.Count - 1);

                double num1 = tokens[tokens.Count - 1];
                tokens.RemoveAt(tokens.Count - 1);

                tokens.Add(ProcessOperation(num1, num2, c));
            }
        }

        return tokens.FirstOrDefault();
    }

    public static double ProcessOperation(double num1, double num2, char op)
    {

        switch (op)
        {

            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                return num1 / num2;
            case '%':
                return num1 % num2;
            case '^':
                return Math.Pow(num1, num2);
            default:
                throw new NotImplementedException($"The operator {op} is not implemented");

        }
    }




    public class Program
    {
        public static void Main()
        {
            string infix = "3 + 4 * 2 / ( 1 - 5 ) ^ 2 ^ 3";
            string postfix = ShuntingYard.ConvertToPostfix(infix);
            Console.WriteLine(postfix); // "342*15-23^^/+"
            Console.WriteLine(ShuntingYard.PostfixEvaluator("5 4 * 3 2 * + 1 -"));
            Console.ReadLine();

        }
    }
}