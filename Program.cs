using System;


namespace _17JulyParameters
{
    public class Calc
    {
        public void Increment(int num)
        {
            Console.WriteLine("Value of num inside Method before increment: \t"+num);
            num += 5;
            Console.WriteLine("Value of num inside Method After increment: \t" + num);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum;
            Console.WriteLine("Enter a number");
            myNum = int.Parse(Console.ReadLine());
            Console.WriteLine("myNum in Main before Method Call is: \t"+myNum);
            Calc calc = new Calc();
            calc.Increment(myNum);
            Console.WriteLine("myNum in Main After Method Call is: \t"+myNum);
            Console.ReadKey();
        }
    }
}
