using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Horses
{
    internal class Program
    {
        class Horse
        {
             int x;
             int y;

            public Horse(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void StartPosition()//стартовая позиция лошадей
            {
                Console.SetCursorPosition(this.x, this.y);
                Console.Write('@');
                Console.SetCursorPosition(0, 21);
            }

            public void Run(Horse Run, Horse Run2)//рандомный бег лошадей
            {
                Random random = new Random();
                Console.Clear();
                Console.SetCursorPosition(this.x += random.Next(0, 4), this.y);
                Console.Write('@');
                Console.SetCursorPosition(Run.x += random.Next(0, 4), Run.y);
                Console.Write('@');
                Console.SetCursorPosition(Run2.x += random.Next(0, 4), Run2.y);
                Console.Write('@');
            }
            public void Proverka(ref bool GameOver)//игра окончена?
            {
                if (this.x >= 51 && y == 7)
                {
                    GameOver = true;
                    Console.SetCursorPosition(19, 22);
                    Console.WriteLine("Выиграла первая лошадь!!!\r\n" +
                        "                   ~~~cпасибо за участие~~~");
                }
                else 
                if (this.x >= 51 && y == 12)
                {
                    GameOver = true;
                    Console.SetCursorPosition(19, 22);
                    Console.WriteLine("Выиграла вторая лошадь!!!\n\r" +
                        "                   ~~~cпасибо за участие~~~");
                }
                else
                    if(this.x >= 51 && y == 17)
                {
                    GameOver = true;
                    Console.SetCursorPosition(19, 22);
                    Console.WriteLine("Выиграла третья лошадь!!!\r\n" +
                        "                   ~~~cпасибо за участие~~~");
                }
            }

        }
        static void field_output(int[,] Pole)
        {
            var SizeX = 12;

            var SizeY = 5;
            Console.SetCursorPosition(SizeX, SizeY);
            for (int i = 0; i < Pole.GetLength(0); i++, ++SizeY)
            {
                for (int j = 0; j < Pole.GetLength(1); j++, ++SizeX)
                {
                    Console.SetCursorPosition(SizeX, SizeY);
                    if (Pole[i, j] == 1)
                    {
                        Console.Write("■");
                    }
                    else if (Pole[i, j] == 2)
                    {
                        Console.Write("▒");
                    }
                }
                SizeX = 12;
            }
        }
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetWindowSize(63, 35);
            Console.CursorVisible = false;
            int[,] Pole =
           {
            {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,1,1,1,1,1,1,1,1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0,0,0,0,0,0,2},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0,0,0,0,0,0,2},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0,0,0,0,0,0,2},
            {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,1,1,1,1,1,1,1,1},
            {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,1,1,1,1,1,1,1,1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0,0,0,0,0,0,2},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0,0,0,0,0,0,2},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0,0,0,0,0,0,2},
            {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,1,1,1,1,1,1,1,1},
            {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,1,1,1,1,1,1,1,1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0,0,0,0,0,0,2},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0,0,0,0,0,0,2},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0,0,0,0,0,0,2},
            {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,1,1,1,1,1,1,1,1}};

            field_output(Pole);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Horse One = new Horse(13, 7);
            Horse Two = new Horse(13, 12);
            Horse Three = new Horse(13, 17);

            One.StartPosition();
            Two.StartPosition();
            Three.StartPosition();

            Console.SetCursorPosition(16,0);
            Console.WriteLine("Добро пожаловать в игру скачки!");
            Console.SetCursorPosition(9, 2);
            Console.WriteLine("~~~нажмите на любую кнопку и они начнуться~~~");
            Console.ReadKey();

            var GameOver = false;
            while (!GameOver)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                One.Run(Two,Three);
                Console.ForegroundColor = ConsoleColor.Magenta;
                field_output(Pole);
                Console.ForegroundColor = ConsoleColor.Yellow;
                One.Proverka(ref GameOver);
                Two.Proverka(ref GameOver);
                Three.Proverka(ref GameOver);
                Thread.Sleep(100);
            }
            Console.ReadKey();
        }
    }
}