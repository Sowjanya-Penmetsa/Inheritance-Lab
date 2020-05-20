using System;

namespace Stack_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings SOS = new StackOfStrings();
            SOS.Push("hello");
            SOS.Push("How");
            SOS.Push("r");
            SOS.Push("u");
            Console.WriteLine(SOS.IsEmpty());
            Console.WriteLine(SOS.Pop());
            Console.WriteLine(SOS.Peek());
            Console.ReadLine();

        }   

            
    }
    
}
