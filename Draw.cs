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
            char[,] mas = null;
            int i;
            int j;
            var x = (Console.WindowWidth - length * 4) / 2;
            var y = Console.WindowHeight / 2;
            var yf = y;
            Console.SetCursorPosition(x, y);
            for (var z = 0; z < length; z++)
            {
                switch (number[z])
                {
                    case ' ':
                        x += 1;
                        break;
                    case '-':
                        mas = new char[7,3] { { '█', '█', '█' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
                        break;
                    case '.':
                        mas = new char[7, 3] { { '█', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
                        break;
                    case ',':
                        mas = new char[7, 3] { { '█', ' ', ' ' }, { ' ', '█', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
                        y++;
                        break;
                    case '0':
                        mas = new char[7, 3] { { ' ', '█', ' ' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { ' ', '█', ' ' } };
                        break;
                    case '1':
                        mas = new char[7, 3] { { '█', '█', '█' }, { ' ', '█', ' ' }, { ' ', '█', ' ' }, { ' ', '█', ' ' }, { ' ', '█', ' ' }, { ' ', '█', ' ' }, { '█', '█', ' ' } };
                        break;
                    case '2':
                        mas = new char[7, 3] { { '█', '█', '█' }, { '█', ' ', ' ' }, { '█', ' ', ' ' }, { '█', '█', '█' }, { ' ', ' ', '█' }, { '█', ' ', '█' }, { '█', '█', '█' } };
                        break;
                    case '3':
                        mas = new char[7, 3] { { '█', '█', '█' }, { '█', ' ', '█' }, { ' ', ' ', '█' }, { ' ', '█', ' ' }, { ' ', ' ', '█' }, { '█', ' ', '█' }, { '█', '█', '█' } };
                        break;
                    case '4':
                        mas = new char[7, 3] { { ' ', ' ', '█' }, { ' ', ' ', '█' }, { ' ', ' ', '█' }, { '█', '█', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' } };
                        break;
                    case '5':
                        mas = new char[7, 3] { { '█', '█', '█' }, { '█', ' ', '█' }, { ' ', ' ', '█' }, { '█', '█', '█' }, { '█', ' ', ' ' }, { '█', ' ', ' ' }, { '█', '█', '█' } };
                        break;
                    case '6':
                        mas = new char[7, 3] { { '█', '█', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { '█', '█', '█' }, { '█', ' ', ' ' }, { '█', ' ', ' ' }, { ' ', '█', ' ' } };
                        break;
                    case '7':
                        mas = new char[7, 3] { { ' ', '█', ' ' }, { ' ', '█', ' ' }, { ' ', '█', ' ' }, { ' ', ' ', '█' }, { ' ', ' ', '█' }, { ' ', ' ', '█' }, { '█', '█', '█' } };
                        break;
                    case '8':
                        mas = new char[7, 3] { { '█', '█', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { '█', '█', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { '█', '█', '█' } };
                        break;
                    case '9':
                        mas = new char[7, 3] { { ' ', '█', ' ' }, { ' ', ' ', '█' }, { ' ', ' ', '█' }, { '█', '█', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { '█', '█', '█' } };
                        break;
                }
                for (i = 0; i < 7; i++)
                {
                    Console.SetCursorPosition(x, y--);
                    for (j = 0; j < 3; j++)
                    {
                        Console.Write(mas[i, j]);
                    }
                }
                x += 4;
                y = yf;
                Console.SetCursorPosition(x, y);
            }
        }
    }
}