using System;
using System.Collections;

class uppgift2{

    static bool isOperator(char x){

switch(x)
        {
            case '+':
            case '^':
            case '%':
            case '-':
            case '/':
            case '*':
            return true;
        }
        return false;
    }
public static string convert(string str)
{
    Stack stack = new Stack();

    int l = str.Length;

    for(int i = l - 1; i >= 0; i--)
    {
        char c = str[i];
        
        if (isOperator(c))
        {
            string op1 = (string)stack.Pop();
            string op2 = (string)stack.Pop();

            string temp = "(" +op1 + c +op2 + ")";
            stack.Push(temp);
        }
        else
        {
        stack.Push(c + "");
        }
    }
    return (string)stack.Pop();
}
public static void Main(string[] args)
{
    string input ="*+12-34";

    string convertedinput = convert(input);
    Console.WriteLine(convertedinput);
}
}