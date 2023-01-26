class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            //the expression will be a string array
            string[] expression = {"*" , "+" , "1" , "2" , "-" , "3" , "4"};
            for (int i = 0; i < expression.Length; i++)//we write the prefix expression
            {
                Console.Write(expression[i]);
            }
            int result;//a result to push onto the stack after an operation was done

            Console.WriteLine();//newline space
            Array.Reverse(expression);//we reverse the expression to read in the characters from right to left
            int n;
            foreach (string c in expression)//for each string character in the array
            {
                if (int.TryParse(c, out n))//if the character can be converted to a number (operand)
                {
                    stack.Push(n);//push the number onto the stack
                }
                if (c == "+")//handling of operators
                {
                    int x = stack.Pop();
                    int y = stack.Pop();
                    result = x + y;//evaluate the values popped from the stack
                    stack.Push(result);//push current result onto the stack
                }
                if (c == "-")
                {
                    int x = stack.Pop();
                    int y = stack.Pop();
                    result = x - y;
                    stack.Push(result);
                }
                if (c == "*")
                {
                    int x = stack.Pop();
                    int y = stack.Pop();
                    result = x * y;
                    stack.Push(result);
                }
                if (c == "/")
                {
                    int x = stack.Pop();
                    int y = stack.Pop();
                    result = y / x;
                    stack.Push(result);
                }

            }
            /*write the final result of the expression,
             * which is at the top of the stack, so we use Peek()*/
            Console.WriteLine("result of expression: {0}", stack.Peek());

            Console.ReadLine();
        }
    }