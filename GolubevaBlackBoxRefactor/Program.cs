using System;
using System.IO;

namespace GolubevaBlackBox
{
    public class Program
    {
        static void Main(string[] args)
        {
        m1: Console.Write("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine()); // Размерность массива
            if (n < 2)
            {
                Console.WriteLine("Ошибка 1: Неверный размер массива"); ;
                goto m1;
            }
            int[] array = new int[n]; // целочисленный одномерный массив
        m2: for (int i = 0; i < array.Length; i++)
            {
                Random rnd = new Random();
                array[i] = rnd.Next(-100, 100);
                Console.Write(array[i] + " ");
            }
            int lastotrIndex = -1; // переменная для записи индекса (места в массиве) последнего отрицательного числа
            int resultOtr = 0; // переменная для записи значения последнего отрицательного числа
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    lastotrIndex = i;
                    resultOtr = array[i];
                }
            }
            int firstpolIndex = -1; // переменная для записи индекса (места в массиве) первого положительного числа
            int resultPol = 0; // переменная для записи значения первого положительного числа
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    firstpolIndex = i;
                    resultPol = array[i];
                    break;
                }
            }
            if (lastotrIndex == -1 || firstpolIndex == -1) // проверка на наличие в массиве хотябы одного отрицательного одного положительного числа
            {
                Console.WriteLine("Ошибка 2: Нет положительного или отрицательного элемента. Перезаполнение массива.........");
                goto m2;
            }
            Console.Write($"\n{lastotrIndex} {firstpolIndex}\n");
            for (int i = 0; i < array.Length; i++) // Цикл для смены местами последнего отрицательного и первого положительного числа, а также для вывода измененного массива
            {
                if (i == lastotrIndex)
                {
                    array[i] = resultPol;
                }
                else if (i == firstpolIndex)
                {
                    array[i] = resultOtr;
                }
                Console.Write(array[i] + " ");
            }
        }
    }
}


