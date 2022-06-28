using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace D_zach_Kabanov
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Mebel = new List<string> { "Кресло", "Торшер", "Диван", "Стул", "Лампа", "Торшер1" };
            Console.WriteLine(string.Join(" ", Mebel));
            string[] bYKV = {"А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я",
                "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю","я"};
            Console.WriteLine("Введите новое слово для добавления");
            Mebel.Add(Convert.ToString(Console.ReadLine()));
            Console.WriteLine(string.Join(" ", Mebel));
            Console.WriteLine("Введите первую букву слова:");
            char f = Convert.ToChar(Console.ReadLine().ToUpper()); ///ввод пользвателем буквы исключения
            string a = Convert.ToString(f);
            for (int i = 0; i < a.Length; i++)
            {
                if (bYKV.Contains(a.ToUpper())) ///сравниваем введённый впользователем символ с алфовитом
                {
                    var selectedMebel = from m in Mebel  ///проходит по всем элементам массива Mebel и определяет каждый элемент как m. Используя переменную m мы можем проводить над ней разные операции
                                        where m.ToUpper().StartsWith(f)  ///проводится фильтрация объектов

                                        select m;  ///передает выбранные значения в результирующую выборку
                    string k = " ";
                    foreach (string m in selectedMebel)
                    {
                        Console.WriteLine(m);
                        k = m;
                    }
                    Mebel.Remove(k); ///удаляет слово
                    Console.WriteLine(string.Join(" ", Mebel));
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                }
            }
        }
    }
}