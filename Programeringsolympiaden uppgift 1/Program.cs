using System.Data.Common;

namespace uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tormor = true;

            while (tormor = true)
            {
                int morot = 40;
                

                Console.WriteLine("Tors tid: ");
                string tor = Console.ReadLine();
                Console.WriteLine("Mors tid: ");
                string mor = Console.ReadLine();

                float tors = float.Parse(tor);
                float mors = float.Parse(mor);

                float summa = mors;
                float summa2 = tors;

                if (tors > mors)
                {
                    tors = summa;
                }
                if (mors < summa)
                {
                    mors = summa2;
                }

                float test = summa2 / summa;

                Console.WriteLine(test);

                float test2 = 40 * test;

                Console.WriteLine(test2);

                float test3 = 40 - test2;

                Console.WriteLine($"Du fick{test3} {test2} ");

                break;
            }


        }
    }
}