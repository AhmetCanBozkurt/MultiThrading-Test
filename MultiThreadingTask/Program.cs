using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SiraliCalistir();
            ParalelCalistir();


        }
        static void ParalelCalistir()
        {

            int numberOfTasks = 50; // Paralel çalıştırmak istediğiniz task sayısı
            Task[] tasks = new Task[numberOfTasks];

            for (int i = 0; i < numberOfTasks; i++)
            {
                int taskIndex = i; // Değişkeni kapatmak için
                tasks[i] = Task.Run(() => RunMethod(taskIndex));
            }

            Task.WaitAll(tasks); // Tüm taskların bitmesini bekle

            Console.WriteLine("Tüm tasklar tamamlandı.");
            Console.ReadLine();

        }

        static void RunMethod(int taskIndex)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Console.WriteLine($"Task {taskIndex} başladı: {DateTime.Now:HH:mm:ss.fff}");

            // Simülasyon amacıyla bir gecikme ekliyoruz (Örneğin: 1-3 saniye)
            Task.Delay(new Random().Next(1000, 3000)).Wait();

            stopwatch.Stop();
            Console.WriteLine($"Task {taskIndex} bitti: {DateTime.Now:HH:mm:ss.fff}, Süre: {stopwatch.ElapsedMilliseconds} ms");
        }




        static void SiraliCalistir()
        {
            int numberOfTasks = 50; // Çalıştırmak istediğiniz task sayısı

            // Sıralı çalıştırmayı test edelim
            Console.WriteLine("Sıralı çalıştırma başladı...");
            Stopwatch overallStopwatch = Stopwatch.StartNew();

            for (int i = 0; i < numberOfTasks; i++)
            {
                int taskIndex = i; // Değişkeni kapatmak için
                Stopwatch taskStopwatch = Stopwatch.StartNew();
                Console.WriteLine($"Task {taskIndex} başladı: {DateTime.Now:HH:mm:ss.fff}");

                // Simülasyon amacıyla bir gecikme ekliyoruz (Örneğin: 1-3 saniye)
                RunMethod(taskIndex);

                taskStopwatch.Stop();
                Console.WriteLine($"Task {taskIndex} bitti: {DateTime.Now:HH:mm:ss.fff}, Süre: {taskStopwatch.ElapsedMilliseconds} ms");
            }

            overallStopwatch.Stop();
            Console.WriteLine($"Sıralı çalıştırma tamamlandı. Toplam Süre: {overallStopwatch.ElapsedMilliseconds} ms");
            Console.ReadLine();
        }

        static  void RunMethodSirali(int taskIndex)
        {
            // Simülasyon amacıyla bir gecikme ekliyoruz (Örneğin: 1-3 saniye)
             Task.Delay(new Random().Next(1000, 3000));
        }

    }
}
