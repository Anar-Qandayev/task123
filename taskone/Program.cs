using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            if (n >= m)
            {
                Console.Write("m ededi n ededinden boyuk olmalidir");
            }
            int count = 0;

            for (int i = n; i <= m; i++)
            {
                if (i % x == 0) count++;
            }
            Console.WriteLine(n + " Ededi ile " + m + " ededi arasında " + x + " ededine bolunen ededlerin sayı: " + count);
            else
            {
                Console.WriteLine("Sistemde xeta bas verdi!!!");
            }

        }

    }
}