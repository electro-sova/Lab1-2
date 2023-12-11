namespace Lab1
{
    public class Program
    {
        public static int[] Sort(int[] array)
        {
            static void Swap(ref int a, ref int b)
            {
                var c = a;
                a = b;
                b = c;
            }

            var length = array.Length;

            for (var i = 1; i < length; i++)
            {
                for (var j = 0; j < length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }
        public static bool Palindrome(string s)
        {
            if (s.Length < 2)
            {
                return false;
            }

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static int Factorial(int number)
        {
            if (number < 0) throw new Exception("Число меньше нуля");

            int fact = 1;

            for (int i = 1; i <= number; i++) fact *= i;

            return fact;
        }
        public static int Fibonacci(int number)
        {
            if (number < 0) throw new Exception("Число меньше нуля");

            if (number == 1) return 1;
            else if (number == 0) return 0;

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        public static double Stepen(double a, double b)
        {
            if (a <= 0) throw new Exception("Число меньше или равняется нулю");

            return Math.Pow(a, b);
        }
        public static bool PrimeNumber(int number)
        {
            if (number < 0) return false;

            for (int i = 2; i < Math.Sqrt(number) + 1; i++) if (number % i == 0) return false;

            return true;
        }


        static void Main(string[] args)
        {
            int[] a = { 10, 9, 11, 225, 224, 956, 304, 2, 5 };

            Console.WriteLine("Отсортированный массив:");
            foreach (var e in Sort(a)) Console.Write(e + " ");

            Console.WriteLine("Числа факториала");
            Console.WriteLine($"7! = {Factorial(5)}"); //5040
            Console.WriteLine($"4! = {Factorial(6)}"); //24

            Console.WriteLine("\nСлова палиндромы");

            string s1 = "kkkkjjjj";
            string s2 = "112211";

            Console.WriteLine($"{s1} = {Palindrome(s1)}"); //false
            Console.WriteLine($"{s2} = {Palindrome(s2)}"); //true

            Console.WriteLine("Числа фибоначчи");
            Console.WriteLine($"5 = {Fibonacci(11)}"); // 89
            Console.WriteLine($"6 = {Fibonacci(25)}"); // 75025

            Console.WriteLine("Возведение в степень");
            Console.WriteLine($"1.1 ^ 1.1 = {Stepen(0.5, 0.5)}"); // 0.707
            //Console.WriteLine($" 0 ^ 0.1 = {ExponentiationRealNumber(0, 1.1)}"); //Ошибка

            Console.WriteLine("Простое ли число:");

            Console.WriteLine($"1:{PrimeNumber(2)}"); //false
            Console.WriteLine($"6:{PrimeNumber(100)}"); //false
            Console.WriteLine($"7:{PrimeNumber(7)}"); //true

            Console.Read();
        }
    }
}