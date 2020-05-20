using System;

namespace Random_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Randomlist list = new Randomlist();
            list.Add("item1");
            list.Add("item2");
            list.Add("item3");
            list.Add("item4");
            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }
            
            Console.WriteLine("Removed element is:" + list.RandomString());
            Console.ReadLine();
        }

    }
}
