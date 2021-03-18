using System;

namespace SkillBoxRandomHome
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Clear()
            {
                Console.Clear();
            }
            static void Delay()
            {
                Console.ReadLine();
            }


            #region ТЗ
   
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            #endregion
            Random ran = new Random();                                                                              // активация рандома 

            Console.Write("Привет!\n" +
                          "Хочешь сыграть с Димси в игру да/нет? "); var DimsyChange = Console.ReadLine();      // реализация игры с компьютером 
            Clear();                                                                                           // очистка конслои

            if (DimsyChange == "да")                                                                            // условие да, выбор игры с компьютером ДИМСИ
            {
                Console.Write("Напишите свой ник: "); var UserName = Console.ReadLine();                        // ввод ника игрока
                Clear();                                                                                       // очистка консоли

                var gameNumber = ran.Next(12, 120);                                                             // рандомное число для расчета
                var Dimsy = "Димси";                                                                           // ник для бота 
                var whileStart = 1;                                                                           // инициалиция количества ходов

                Console.WriteLine("Привет {0} и {1}", UserName, Dimsy);                                         // сообщение о приветствие игрока и бота
                Console.WriteLine("Ваше случайное число:= {0}", gameNumber);                                   // вывод случайного числа
                Delay();                                                                                      // ожидание ввода от пользователя
                Clear();                                                                                     // очистка консоли 

                while (true)                                                                                    // старт цикла игры ПУНКТ 1.1
                {
                    var DimsyRandom = ran.Next(1, 5);                                                         // инициализация случайного числа 
                    while (true)                                                                             // цикл на проверку введенного от Димси числа
                    {
                        if (DimsyRandom <= gameNumber)                                                          // если число от Димсм меньше рандомного числа ПУНКТ 2.1
                        {
                            break;                                                                              // выходим из цикла проверки числа от Димси                                                                 
                        }

                        else if (DimsyRandom>gameNumber)                                                        // тогда если число от Димсм больше рандомного числа 
                        {
                            DimsyRandom = ran.Next(1, 5);                                                       // задать новое случайное значение числу от Димси
                            continue;                                                                          // продолжить проверять число от Димси с ПУНКТА 2.1
                        }
                    }
                    Console.WriteLine("Сейчас рандомное число =: {0}\t" +
                                      "Ход номер {1}\n", gameNumber, whileStart);                               // вывод имя бота и его случайного числа 
                    Console.WriteLine("{0}, вводит число от 1...4: {1} ", Dimsy,DimsyRandom);                  // вывод числа от Димси
                    gameNumber -= DimsyRandom;                                                                // операция вычитания от рандомного числа число от Димси
                    Console.WriteLine("Рандомное число =: {0}", gameNumber);                                 // текущее значение рандомного числа
                    if (gameNumber == 0)                                                                    // если после вычитания рандомное число равно нулю
                    {
                        Console.WriteLine("{0}, тебя победил!",Dimsy);                                          // вывод сообщения о победе Димси
                        break;                                                                                 // выйти из цикла игры с Димси ПУНКТ 1.1
                    }
                    Console.Write("{0}, введи число от 1...4: ", UserName); var userTry = int.Parse(Console.ReadLine());        // вывод сообщения с именем пользователя с дальнейшим вводом числа от пользователя 
                    gameNumber -= userTry;                                                                                     // операция вычитания от рандомного числа число от пользователя
                    if (gameNumber == 0)                                                                                      // если после вычитания рандомное число равно нулю
                    {
                        Console.WriteLine("{0}, ты победил!", UserName);                                                        // вывод сообщения о победе пользователя
                        break;                                                                                                 // выйти из цикла игры с Димси ПУНКТ 1.1
                    }
                    Clear();                                                                                                    // очистка конслои                                                                                           
                    whileStart++;                                                                                              // увеличение числа ХОДА на 1
                }
            }
            else if (DimsyChange == "нет")
            {
                Console.Write("Напишите свой ник: "); var UserOne = Console.ReadLine();
                Clear();
                Console.Write("Напишите свой ник: "); var UserTwo = Console.ReadLine();
                Clear();


                int gameNumber = ran.Next(12, 120);
                int userTry, whileStart = 1;

                Console.WriteLine("Привет {0} и {1}", UserOne, UserTwo);
                Console.WriteLine("Ваше случайное число:= {0}", gameNumber);
                Clear();

                while (true)
                {
                    Console.WriteLine("Сейчас рандомное число:= {0}.\t" +
                                      "Ход номер {1}", gameNumber, whileStart);
                    Console.Write("{0}, введи число от 1...4: ", UserOne); userTry = int.Parse(Console.ReadLine());         //подумать над реализации проверки на число
                    if (userTry > 0 && userTry <= 4) gameNumber -= userTry;
                    else
                    {
                        Console.WriteLine("Ошибка...");
                        break;
                    }
                    if (gameNumber == 0)
                    {
                        Console.WriteLine("{0}, ты победил!\n" +
                                          "Устроим реванш? да/нет", UserOne);
                        var yourChange = Console.ReadLine();
                        switch (yourChange)
                        {
                            case "да":
                                gameNumber = ran.Next(12, 120);
                                whileStart = 1;
                                Console.Clear();
                                continue;
                            case "нет":
                                break;
                            default:
                                Console.WriteLine("Ошибка...");
                                break;
                        }

                        break;
                    }
                    Clear();

                    Console.WriteLine("Сейчас рандомное число:= {0}.\t" +
                                      "Ход номер {1}", gameNumber, whileStart);
                    Console.Write("{0}, введи число: ", UserTwo); userTry = int.Parse(Console.ReadLine());              //подумать над реализации проверки на число
                    if (userTry > 0 && userTry <= 4) gameNumber -= userTry;
                    else
                    {
                        Console.WriteLine("Ошибка...");
                        break;
                    }
                    if (gameNumber == 0)
                    {
                        Console.WriteLine("{0}, ты победил!\n" +
                                          "Устроим реванш? да/нет", UserTwo);
                        var yourChange = Console.ReadLine();
                        switch (yourChange)
                        {
                            case "да":
                                gameNumber = ran.Next(12, 120);
                                whileStart = 1;
                                Clear();
                                continue;
                            case "нет":
                                break;
                            default:
                                Console.WriteLine("Ошибка...");
                                break;
                        }
                        break;
                    }
                    whileStart++;
                    Clear();
                }
            }// реализация игры с человеком
            else
            {
                Console.WriteLine("Ошибка!!!\n" +
                                  "Ответ не определён...");
            }
            Delay();
        }
    }
}
