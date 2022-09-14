using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelFont_Kulish
{
    internal class Draw
    {
        public void Nums(int length, char[] number)
        {
            string[] mas = null;
            int i;
            var x = (Console.WindowWidth - length * 4) / 2;
            var y = Console.WindowHeight / 2;
            var yf = y;
            Console.SetCursorPosition(x, y);
            for (var z = 0; z < length; z++)
            {
                switch (number[z])
                {
                    case ' ':
                        Array.Clear(mas);
                        break;
                    case '-':
                        mas = new string[7] { "", "", "", "███", "", "", "" };
                        break;
                    case '.':
                        mas = new string[7] { "█", "", "", "", "", "", "" };
                        break;
                    case ',':
                        mas = new string[7] { "█", " █", "", "", "", "", "" };
                        y++;
                        break;
                    case '0':
                        mas = new string[7] { " █", "█ █", "█ █", "█ █", "█ █", "█ █", " █" };
                        break;
                    case '1':
                        mas = new string[7] { "███", " █", " █", " █", " █", " █", "██" };
                        break;
                    case '2':
                        mas = new string[7] { "███", "█", "█", "███", "  █", "█ █", "███" };
                        break;
                    case '3':
                        mas = new string[7] { "███", "█ █", "  █", " █", "  █", "█ █", "███" };
                        break;
                    case '4':
                        mas = new string[7] { "  █", "  █", "  █", "███", "█ █", "█ █", "█ █" };
                        break;
                    case '5':
                        mas = new string[7] { "███", "█ █", "  █", "███", "█", "█", "███" };
                        break;
                    case '6':
                        mas = new string[7] { "███", "█ █", "█ █", "███", "█", "█", " █" };
                        break;
                    case '7':
                        mas = new string[7] { " █", " █", " █", "  █", "  █", "  █", "███" };
                        break;
                    case '8':
                        mas = new string[7] { "███", "█ █", "█ █", "███", "█ █", "█ █", "███" };
                        break;
                    case '9':
                        mas = new string[7] { " █", "  █", "  █", "███", "█ █", "█ █", "███" };
                        break;
                }
                for (i = 0; i < 7; i++)
                {
                    Console.SetCursorPosition(x, y--);
                    Console.Write(mas[i]);
                }
                x += 4;
                y = yf;
                Console.SetCursorPosition(x, y);
            }
        }
    }
}