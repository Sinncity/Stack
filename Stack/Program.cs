using System;
using System.Collections.Generic;


namespace LearningStack
{





    internal class Program
    {
        static void Main(String[] args)
        {


            //Last in First Out = lifo
            //Remove Pop()
            //Add  Push()

            Stack<String> myStack = new Stack<String>();


            myStack.Push("a");
            myStack.Push("b");
            myStack.Push("c");
            myStack.Push("d");
            myStack.Push("e");

            //myStack.Pop();
            //String myLetter = myStack.Pop();


            //Console.WriteLine(myStack.Peek());

            //Console.WriteLine(myStack.Contains("c"));


            for (int i = 0; i < 10; i++)
            {

                myStack.Push("f");
            }


            Console.WriteLine(myStack);





            Stack<int> intStack = new Stack<int>();
            intStack.Push(10);
            intStack.Push(20);
            intStack.Push(30);
            var top = intStack.Pop();
            Console.WriteLine(top);
            Console.WriteLine(intStack);
            top = intStack.Peek();
            Console.WriteLine(top);
            intStack.Contains(20);
            Console.WriteLine(intStack);



            StringReverser reverser = new StringReverser();
            var result = reverser.reverse(Char);





        }
    }
    public class StringReverser
    {

        public String reverse(String input)
        {
            Stack<Char> reverseStack = new Stack<Char>();


            foreach (char ch in input.ToCharArray())
            {
                reverseStack.Push(ch);
            }
            //String reversed = reverseStack.Pop();
            String reversed = "";
            while (reverseStack.Count > 0)
            {
                reversed += reverseStack.Pop();
                return reversed.ToString();
            }

        }


    }
}
