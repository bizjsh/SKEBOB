using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы n: ");
            int n = int.Parse(Console.ReadLine());

            double[,] matrix = new double[n, n];

            Console.WriteLine($"Введите матрицу {n}x{n} построчно (числа через пробел):");
            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split(' ');
                //Цикл по столбцам матрицы
                for (int j = 0; j < n; j++)
                    //Преобразование строки в число и запись в матрицу
                    matrix[i, j] = double.Parse(row[j]);
            }

            bool symmetric = true;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (matrix[i, j] != matrix[j, i])//Сравнение симметричных элементов относительно главной диагонали
                        symmetric = false;

            Console.WriteLine(symmetric ? "Матрица симметрична" : "Матрица не симметрична");
        }
    }
}
