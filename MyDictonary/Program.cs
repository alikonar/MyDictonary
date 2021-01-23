using System;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            DictonaryClass<string, int> dictonaryClass = new DictonaryClass<string, int>();

            dictonaryClass.Add("Mantı", 200);
            dictonaryClass.Add("Tavuk", 300);
            dictonaryClass.Add("Sucuk", 400);
            dictonaryClass.Add("Ekmem", 500);


            Console.WriteLine(dictonaryClass.Count);

        }
    }
}
