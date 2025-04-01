using System;

namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        private class Node
        {
            public char Data { get; set; }
            public Node Next { get; set; }

            public Node(char data)
            {
                this.Data = data;
                Next = null;
            }

        }

        private Node top;

        public BracketValidator()
        {
            top = null;
        }

        public void Push(char data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }

        public char Pop()
        {
            if (top == null)
            {
                return '\0';
            }
            char data = top.Data;
            top = top.Next;
            return data;
        }

        public bool ValidasiEkspresi(string ekspresi)
        {
            for (int i = 0; i < ekspresi.Length; i++)
            {
                char data = ekspresi[i];

                if (data == '(' || data == '[' || data == '{')
                {
                    Push(data);
                }
                else if (data == ')' || data == ']' || data == '}')
                {
                    char topData = Pop();

                    if ((data == ')' && topData != '(') || (data == ']' && topData != '[') || (data == '}' && topData != '{'))
                    {
                        return false;
                    }
                }
            }
            return top == null;
        }

    }
}
