using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Diagnostics;//namespace в котором содержится класс Stopwatch

namespace StopwatchEx
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();


            //Поля класса

            //Stopwatch.Frequency (public static readonly long Frequency) - содержит частоту таймера( кол-во тактов в секунду )

            //Stopwatch.IsHighResolution (public static readonly bool IsHighResolution) - зависит ли таймер от счетчика высокой производительности
            //if(true) - счетчик; (false) - использует DateTime class;

            timer.Start();

            for (int i = 0; i < 10000; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            timer.Stop();


            //Свойства

            //Elapsed {get;}
            //Свойство которое позволяем получить обще-затраченное время конкретного экземпляра
            //Возвращает обьект типа TimeSpan - интервал времени 

            TimeSpan time = timer.Elapsed;
            Console.WriteLine("---------------");
            Console.WriteLine($"Final tyme: [H]:{time.Hours}:[M]{time.Minutes}:[S]{time.Seconds}.[MS]{time.Milliseconds}");


            //ElapsedMilliseconds{get;}
            //Свойство позволяющее получить затраченое время в милисекундах
            Console.WriteLine("---------------");
            Console.WriteLine($"Elapsed milliseconds: {timer.ElapsedMilliseconds}");

            //ElapsedTicks {get;}
            //Свойтво позволяющее получить затраченое время в тактах таймера
            Console.WriteLine("---------------");
            Console.WriteLine($"Tick time: {timer.ElapsedTicks}");

            //IsRuning {get;}
            //Свойство возвращает true если экземпляр класса в текущий момент выполняет расчет интервала
            if (!timer.IsRunning)
            {
                Console.WriteLine("Timer is inactive");
            }
            else
            {
                Console.WriteLine("Timer active");
            }

            //Методы

            //Start() / Stop()
            //(запуск\возобновление)/ (остановка)


            //StartNew() - синтаксический сахар? 
            //инициализирует новый обьект,обнуляет счетчик,запускает таймер

            Stopwatch newTimer = Stopwatch.StartNew();
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"{i} ");
            }
            newTimer.Stop();
            Console.WriteLine($"1st lap: {newTimer.ElapsedMilliseconds} [MS]");

            //Reset() - останавливает и обнуляет
            newTimer.Reset();
            newTimer.Start();
            //newTimer.Restart() 

            for(int i = 0;i < 100;i++)
            {
                Console.WriteLine($"{i - 1}");
            }

            newTimer.Stop();
            Console.WriteLine($"2nd lap: {newTimer.ElapsedMilliseconds} [MS]");

            //Restart() - обнуляет и перезапускает отсчет 








            Console.ReadKey();




        }
    }
}
