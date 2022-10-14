using System;

namespace Practich3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это клавиатурное пианино.");
            
            Zvuk();
        }

        static void Oktava1(out int[] firstOctave)
        {
            firstOctave = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
        }
        static void Oktava2(out int[] secondOctave)
        {
            secondOctave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
        }

        static void Oktava3(out int[] thirdOctave)
        {
            thirdOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
        }

        static void Zvuk()
        {
            bool n = true;
            int[] nums = new int[12];
            while (n == true)
            {
                bool a = true;

                Console.WriteLine("Чтобы сменить октаву, нажмите либо F1, либо F2, либо F3");
                ConsoleKeyInfo okta = Console.ReadKey();

                if (okta.Key == ConsoleKey.F1)
                {
                    Oktava1(out int[] firstOctave);
                    nums = firstOctave;
                }

                else if (okta.Key == ConsoleKey.F2)
                {
                    Oktava2(out int[] secondOctave);
                    nums = secondOctave;
                }

                else if (okta.Key == ConsoleKey.F3)
                {
                    Oktava3(out int[] thirdOctave);
                    nums = thirdOctave;
                }
                else if (okta.Key == ConsoleKey.Escape)
                { 
                    n = false; 
                }

                Console.Clear();

                while (a == true)
                {

                    //int[] nums = Oktava(); 
                    //Console.WriteLine("А вот и герцы: ", nums[0]);
                    Console.WriteLine("Чтобы вызвать функцию переключения октавы, нажмите esc: ");
                    Console.WriteLine("Введите клавишу(A,W,S,E,D,F,T,G,Y,H): ");
                    ConsoleKeyInfo key = Console.ReadKey();


                    int duration = 300;

                    if (key.Key == ConsoleKey.A)
                    {
                        int b = nums[0];
                        Console.Beep(b, duration);
                    }
                    else if (key.Key == ConsoleKey.W)
                    {
                        int c = nums[1];
                        Console.Beep(c, duration);
                    }
                    else if (key.Key == ConsoleKey.S)
                    {
                        int d = nums[2];
                        Console.Beep(d, duration);
                    }
                    else if (key.Key == ConsoleKey.E)
                    {
                        int e = nums[3];
                        Console.Beep(e, duration);
                    }
                    else if (key.Key == ConsoleKey.D)
                    {
                        int f = nums[4];
                        Console.Beep(f, duration);
                    }
                    else if (key.Key == ConsoleKey.F)
                    {
                        int g = nums[5];
                        Console.Beep(g, duration);
                    }
                    else if (key.Key == ConsoleKey.T)
                    {
                        int h = nums[6];
                        Console.Beep(h, duration);
                    }
                    else if (key.Key == ConsoleKey.G)
                    {
                        int i = nums[7];
                        Console.Beep(i, duration);
                    }
                    else if (key.Key == ConsoleKey.Y)
                    {
                        int j = nums[8];
                        Console.Beep(j, duration);
                    }
                    else if (key.Key == ConsoleKey.H)
                    {
                        int k = nums[9];
                        Console.Beep(k, duration);
                    }
                    else if (key.Key == ConsoleKey.U)
                    {
                        int l = nums[10];
                        Console.Beep(l, duration);
                    }
                    else if (key.Key == ConsoleKey.J)
                    {
                        int m = nums[11];
                        Console.Beep(m, duration);
                    }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        a = false;
                    }
                    Console.Clear();
                }
            }
        }
    }
}