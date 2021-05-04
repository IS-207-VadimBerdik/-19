using System;
using System.Threading;

namespace Практическая__19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nШуточное приложения для просмотра состояний системы\n\t(нажмите q/й и enter,чтобы выйти)");

            Thread th_tempetatur = new Thread(PC_temperatur);
            th_tempetatur.IsBackground = true;
            th_tempetatur.Start();

            Thread th_cpu = new Thread(PC_CPU);
            th_cpu.IsBackground = true;
            th_cpu.Start();

            Thread th_hdd = new Thread(PC_HDD);
            th_hdd.IsBackground = true;
            th_hdd.Start();


            Thread th_time = new Thread(PC_time);
            th_time.IsBackground = true;
            th_time.Start();

            string key = null;
            while (true)
            {
                key = Console.ReadLine();

                if (key == "q" || key == "й")
                {
                    break;
                }
            };
        }

        static void PC_time()
        {
            while (true)
            {
                Console.WriteLine($"- Время: {DateTime.Now}");
                Console.WriteLine("\n\n");
                Thread.Sleep(2000);
            }
        }

        static void PC_temperatur()
        {
            while (true)
            {
                var temp = new Random();
                Console.WriteLine($"- Температура: {temp.Next(30, 100)}C");
                Thread.Sleep(2000);
            }
        }

        static void PC_CPU()
        {
            while (true)
            {
                var temp = new Random();
                Console.WriteLine($"- Нагрузка на процессор: {temp.Next(0, 100)}%");
                Thread.Sleep(2000);
            }
        }
        static void PC_HDD()
        {
            while (true)
            {
                var temp = new Random();
                Console.WriteLine($"- Обороты диска: {temp.Next(2000, 5000)}");
                Thread.Sleep(2000);
            }
        }
    }
}
