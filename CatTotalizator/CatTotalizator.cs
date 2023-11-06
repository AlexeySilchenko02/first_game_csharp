using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatTotalizator;

namespace CatTotalizator
{
    /*
     * Очередное приключение в Рейд-режиме ждёт! Условия и задачи текущей стадии находятся в файле Conditions.txt.
     */

    public class CatTotalizator
    {
        public static Random rnd = new Random();
        public const int distance = 1000;
        public static int winNumber;
        public static double bestTime = 999999999.9999999;
        public static int playerPrediction;
        public static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в \"Симулятор кошачьих бегов\"!");
            Console.WriteLine($"Правила очень просты: у нас есть {Cat.totalCatsInTheGame} котов, участвующих в забеге!");
            Console.WriteLine("Каждый из котов имеет свой уникальный номер. Вам нужно угадать кто прибежит к финишу первым.");
            Console.WriteLine("Для этого достаточно просто ввести его номер с клавиатуры и узнать угадали или нет!");
            Console.WriteLine("Хотите сыграть? (введите \"да\" чтобы сыграть или \"нет\", чтобы завершить игру).");
            bool game = true;
            while (game)
            {
                string s = Console.ReadLine();
                if(s == "да")
                {
                    Console.Clear();
                    Console.WriteLine($"Отлично!!! Забег вот-вот начнется, какой номер по вашему мнению выиграет? Укажите пожалуйста число от 1 до {Cat.totalCatsInTheGame}.");
                    playerPrediction = int.Parse(Console.ReadLine());
                    Console.WriteLine("Спортсмены готовы! На старт... внимание... МАРШ!!!");
                    StartRace();
                    Console.WriteLine($"Победил кот под номером: {winNumber}, пробежав дистанцию за = {bestTime} секунд!");
                    if(playerPrediction == winNumber)
                    {
                        Console.WriteLine("ПОЗДРАВЛЯЕМ!!! Вы угадали!");
                        Console.WriteLine("Спасибо за игру! До встречи!");
                    }
                    else if(playerPrediction != winNumber)
                    {
                        Console.WriteLine("Очень жаль, но вы проиграли!");
                        Console.WriteLine("В следующий раз повезет! До встречи!");
                    }
                    game = false;
                }
                else if(s == "нет")
                {
                    Console.WriteLine("Очень жаль! До встречи!");
                    game = false;
                }
                else
                {
                    Console.WriteLine("Вы ввели что-то не то! Давайте еще раз...");
                }
            }
        } 
        public static void StartRace()
        {
            Cat cat = new Cat();
            cat.catNumber = 1;
            cat.catSpeed = rnd.Next(1,11);
            if (cat.GetCatTime(distance) <= bestTime)
            {
                bestTime = cat.GetCatTime(distance);
                winNumber = 1;
            }
            Cat cat2 = new Cat();
            cat2.catNumber = 2;
            cat2.catSpeed = rnd.Next(1, 11); 
            if (cat2.GetCatTime(distance) <= bestTime)
            {
                bestTime = cat.GetCatTime(distance);
                winNumber = 2;
            }
            Cat cat3 = new Cat();
            cat3.catNumber = 3;
            cat3.catSpeed = rnd.Next(1, 11); 
            if (cat3.GetCatTime(distance) <= bestTime)
            {
                bestTime = cat.GetCatTime(distance);
                winNumber=3;
            }
            Cat cat4 = new Cat();
            cat4.catNumber = 4;
            cat4.catSpeed = rnd.Next(1, 11); 
            if (cat4.GetCatTime(distance) <= bestTime)
            {
                bestTime = cat.GetCatTime(distance);
                winNumber=4;
            }
            Cat cat5 = new Cat();
            cat5.catNumber = 5;
            cat5.catSpeed = rnd.Next(1, 11); 
            if (cat5.GetCatTime(distance) <= bestTime)
            {
                bestTime = cat.GetCatTime(distance);
                winNumber=5;
            }
            Cat cat6 = new Cat();
            cat6.catNumber = 6;
            cat6.catSpeed = rnd.Next(1, 11); 
            if (cat6.GetCatTime(distance) <= bestTime)
            {
                bestTime = cat.GetCatTime(distance);
                winNumber=6;
            }
            Cat cat7 = new Cat();
            cat7.catNumber = 7;
            cat7.catSpeed = rnd.Next(1, 11); 
            if (cat7.GetCatTime(distance) <= bestTime)
            {
                bestTime = cat.GetCatTime(distance);
                winNumber=7;
            }
            Cat cat8 = new Cat();
            cat8.catNumber = 8;
            cat8.catSpeed = rnd.Next(1, 11); 
            if (cat8.GetCatTime(distance) <= bestTime)
            {
                bestTime = cat.GetCatTime(distance);
                winNumber=8;
            }
            Cat cat9 = new Cat();
            cat9.catNumber = 9;
            cat9.catSpeed = rnd.Next(1, 11); 
            if (cat9.GetCatTime(distance) <= bestTime)
            {
                bestTime = cat.GetCatTime(distance);
                winNumber=9;
            }
            Cat cat10 = new Cat();
            cat10.catNumber = 10;
            cat10.catSpeed = rnd.Next(1, 11); 
            if (cat10.GetCatTime(distance) <= bestTime)
            {
                bestTime = cat.GetCatTime(distance);
                winNumber=10;
            }
        }
    }

}
