using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PixelFont_Kulish
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = 0;
            Console.WriteLine("Ввод числа осуществляется с помощью NumPad'а (пробел, точка, запятая, знак отрицания).\nЧтобы написать (.) - используйте английскую раскладку.\nЧтобы написать написать (,) - используйте русскую раскладку.");
            Console.Write("Введите число: ");
            string str = null;
            for (; ; )
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key >= ConsoleKey.NumPad0 && keyInfo.Key <= ConsoleKey.NumPad9 || keyInfo.Key == ConsoleKey.Decimal || keyInfo.Key == ConsoleKey.Subtract || keyInfo.Key == ConsoleKey.Spacebar)
                {
                    Console.Write(keyInfo.KeyChar);
                    str += keyInfo.KeyChar;
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }
            if (str != null)
            {
                char[] number = str.ToCharArray();
                foreach (char c in number)
                {
                    length++;
                }
                Draw dr = new();
                dr.Nums(length, number);
            }
            else
            {
                Console.WriteLine("Вы ничего не ввели.");
            }
            Console.ReadKey();
        }
    }
}
