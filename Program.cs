//using System;

////Call by value
//namespace _17JulyParameters
//{
//    public class Calc
//    {
//        public void Increment(int num)
//        {
//            Console.WriteLine("Value of num inside Method before increment: \t"+num);
//            num += 5;
//            Console.WriteLine("Value of num inside Method After increment: \t" + num);
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int myNum;
//            Console.WriteLine("Enter a number");
//            myNum = int.Parse(Console.ReadLine());
//            Console.WriteLine("myNum in Main before Method Call is: \t"+myNum);
//            Calc calc = new Calc();
//            calc.Increment(myNum);
//            Console.WriteLine("myNum in Main After Method Call is: \t"+myNum);
//            Console.ReadKey();
//        }
//    }
//}

//using System;

////Call by Parameter
//namespace _17JulyParameters
//{
//    public class Calc
//    {
//        public void Increment( ref int num)
//        {
//            Console.WriteLine("Value of num inside Method before increment: \t" + num);
//            num += 5;
//            Console.WriteLine("Value of num inside Method After increment: \t" + num);
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int myNum;
//            Console.WriteLine("Enter a number");
//            myNum = int.Parse(Console.ReadLine());
//            Console.WriteLine("myNum in Main before Method Call is: \t" + myNum);
//            Calc calc = new Calc();
//            calc.Increment( ref myNum);
//            Console.WriteLine("myNum in Main After Method Call is: \t" + myNum);
//            Console.ReadKey();
//        }
//    }
//}

//ref method
//using System;

//namespace _17JulyParameters
//{
//    public class Calc
//    {
//        public void BonusCalc(double salary, ref double bonus)
//        {
//            bonus = salary * 0.2;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double salary = 50000;
//            double bonus = 500;
//            Calc calc = new Calc();
//            calc.BonusCalc(salary, ref bonus);
//            Console.WriteLine($"Salary: \t {salary} and Bonus : {bonus}");
//            Console.ReadKey();
//        }
//    }
//}


//out method
using System;

namespace _17JulyParameters
{
    public class Calc
    {
        public void BonusCalc(double salary, out double bonus)
        {
            bonus = salary * 0.2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary = 50000;
            double bonus;
            Calc calc = new Calc();
            calc.BonusCalc(salary, out bonus);
            Console.WriteLine($"Salary: \t {salary} and Bonus : {bonus}");
            Console.ReadKey();
        }
    }
}