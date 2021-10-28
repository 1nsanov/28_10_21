using System;

namespace _28_10_21
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeD A = new ThreeD(1, 2, 3);
            ThreeD B = new ThreeD(10, 10, 10);
            ThreeD C;
            Console.Write("Координаты точки A: ");
            A.Show();
            Console.Write("Координаты точки B: ");
            B.Show();

            Console.Write("Результат A++: ");
            A++;
            A.Show();
            Console.Write("Результат B--: ");
            B--;

            B.Show();
            C = A + B; 
            Console.Write("Результат сложения A + B: ");
            C.Show();
            C = A - B;
            Console.Write("Результат вычитания A - B: ");
            C.Show();
            Console.ReadLine();

        }
    }
}
