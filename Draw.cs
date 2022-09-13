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
            char[] mas;
            char[,] mas2;
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
                        mas = new char[3] { '█', '█', '█' };
                        Console.SetCursorPosition(x, y-3);
                        for (j = 0; j < 3; j++)
                        {
                            Console.Write(mas[j]);
                        }
                        x += 4;
                        y = yf;
                        break;

                    case '.':
                        mas = new char[3] { '█', ' ', ' ' };
                        Console.SetCursorPosition(x, y);
                        for (j = 0; j < 3; j++)
                        {
                            Console.Write(mas[j]);
                        }
                        Array.Clear(mas);
                        y = yf;
                        x += 4;
                        break;

                    case ',':
                        mas2 = new char[2, 3] { { ' ', '█', ' ' }, { '█', ' ', ' ' } };
                        for (i = 0; i < 2; i++)
                        {
                            Console.SetCursorPosition(x, y++);
                            for (j = 0; j < 3; j++)
                            {
                                Console.Write(mas2[i,j]);
                            }
                        }
                        x += 4;
                        y = yf;
                        break;
                    case '0':
                        mas2 = new char[7, 3] { { ' ', '█', ' ' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { ' ', '█', ' ' } };
                        for (i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(x, y--);
                            for (j = 0; j < 3; j++)
                            {
                                Console.Write(mas2[i, j]);
                            }
                        }
                        x += 4;
                        y = yf;
                        break;
                    case '1':
                        mas2 = new char[7, 3] { { '█', '█', '█' }, { ' ', '█', ' ' }, { ' ', '█', ' ' }, { ' ', '█', ' ' }, { ' ', '█', ' ' }, { ' ', '█', ' ' }, { '█', '█', ' ' } };
                        for (i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(x, y--);
                            for (j = 0; j < 3; j++)
                            {
                                Console.Write(mas2[i, j]);
                            }
                        }
                        x += 4;
                        y = yf;
                        break;
                    case '2':
                        mas2 = new char[7, 3] { { '█', '█', '█' }, { '█', ' ', ' ' }, { '█', ' ', ' ' }, { '█', '█', '█' }, { ' ', ' ', '█' }, { '█', ' ', '█' }, { '█', '█', '█' } };
                        for (i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(x, y--);
                            for (j = 0; j < 3; j++)
                            {
                                Console.Write(mas2[i, j]);
                            }
                        }
                        x += 4;
                        y = yf;
                        break;
                    case '3':
                        mas2 = new char[7, 3] { { '█', '█', '█' }, { '█', ' ', '█' }, { ' ', ' ', '█' }, { ' ', '█', ' ' }, { ' ', ' ', '█' }, { '█', ' ', '█' }, { '█', '█', '█' } };
                        for (i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(x, y--);
                            for (j = 0; j < 3; j++)
                            {
                                Console.Write(mas2[i, j]);
                            }
                        }
                        x += 4; 
                        y = yf;
                        break;
                    case '4':
                        mas2 = new char[7, 3] { { ' ', ' ', '█' }, { ' ', ' ', '█' }, { ' ', ' ', '█' }, { '█', '█', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' } };
                        for (i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(x, y--);
                            for (j = 0; j < 3; j++)
                            {
                                Console.Write(mas2[i, j]);
                            }
                        }
                        x += 4;
                        y = yf;
                        break;
                    case '5':
                        mas2 = new char[7, 3] { { '█', '█', '█' }, { '█', ' ', '█' }, { ' ', ' ', '█' }, { '█', '█', '█' }, { '█', ' ', ' ' }, { '█', ' ', ' ' }, { '█', '█', '█' } };
                        for (i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(x, y--);
                            for (j = 0; j < 3; j++)
                            {
                                Console.Write(mas2[i, j]);
                            }
                        }
                        x += 4;
                        y = yf;
                        break;
                    case '6':
                        mas2 = new char[7, 3] { { '█', '█', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { '█', '█', '█' }, { '█', ' ', ' ' }, { '█', ' ', ' ' }, { ' ', '█', ' ' } };
                        for (i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(x, y--);
                            for (j = 0; j < 3; j++)
                            {
                                Console.Write(mas2[i, j]);
                            }
                        }
                        x += 4;
                        y = yf;
                        break;
                    case '7':
                        mas2 = new char[7, 3] { { ' ', '█', ' ' }, { ' ', '█', ' ' }, { ' ', '█', ' ' }, { ' ', ' ', '█' }, { ' ', ' ', '█' }, { ' ', ' ', '█' }, { '█', '█', '█' } };
                        for (i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(x, y--);
                            for (j = 0; j < 3; j++)
                            {
                                Console.Write(mas2[i, j]);
                            }
                        }
                        x += 4;
                        y = yf;
                        break;
                    case '8':
                        mas2 = new char[7, 3] { { '█', '█', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { '█', '█', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { '█', '█', '█' } };
                        for (i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(x, y--);
                            for (j = 0; j < 3; j++)
                            {
                                Console.Write(mas2[i, j]);
                            }
                        }
                        x += 4;
                        y = yf;
                        break;
                    case '9':
                        mas2 = new char[7, 3] { { ' ', '█', ' ' }, { ' ', ' ', '█' }, { ' ', ' ', '█' }, { '█', '█', '█' }, { '█', ' ', '█' }, { '█', ' ', '█' }, { '█', '█', '█' } };
                        for (i = 0; i < 7; i++)
                        {
                            Console.SetCursorPosition(x, y--);
                            for (j = 0; j < 3; j++)
                            {
                                Console.Write(mas2[i, j]);
                            }
                        }
                        x += 4;
                        y = yf;
                        break;
                }
                Console.SetCursorPosition(x, y);
            }
        }
    }
}