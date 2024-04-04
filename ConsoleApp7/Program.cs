using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fin; //попытка открытия test
            try
            {
                fin = new FileStream("test.dat", FileMode.Open);
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }


            int i; 
            FileStream fin2;    //чтение test2
            try
            {
                fin2 = new FileStream("test2.dat", FileMode.Open);
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            do
            {
                try
                {
                    i = fin2.ReadByte();
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Ошибка чтения файла");
                    Console.WriteLine(exc.Message);
                    return;
                }
                if (i != -1)
                    Console.Write((char)i);
            } 
            while (i != -1);

            Console.WriteLine("\n");
            fin2.Close();


            FileStream fout; //запись алфавита
            try
            {
                fout = new FileStream("test.txt", FileMode.Create);
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message); 
                return;
            }
            try
            {
                for (char с = 'A'; с <= 'Z'; с++) fout.WriteByte((byte)с);
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                if (fout != null) fout.Close();
            }


            int i3;
            FileStream fin3 = null; 
            FileStream fout3 = null; //создание копии
            try
            {
                fin3 = new FileStream("test2.dat", FileMode.Open);
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message); return;
            }
            // Открыть исходник
            try
            {
                fout3 = new FileStream("Copy.cs", FileMode.Create);
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message); return;
            }
            // Копировать
            try
            {
                do
                {
                    i3 = fin3.ReadByte();
                    if (i3 != -1) fout3.WriteByte((byte)i3);
                } while (i3 != -1);
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                if (fin3 != null) fin3.Close();
                if (fout3 != null) fout3.Close();
            }

            string str;
            FileStream fout4; //Запись в файл с клавиатуры
            try
            {
                fout4 = new FileStream("test.txt", FileMode.Create);
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            StreamWriter fstr_out = new StreamWriter(fout4);
            try
            {
                Console.WriteLine("Введите текст, последняя строка - слово 'стоп'");
                do
                {
                    str = Console.ReadLine();
                    if (str != "стоп")
                    {
                        str = str + "\r\n";
                        fstr_out.Write(str);
                    }
                }
                while (str != "стоп");
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            fstr_out.Close();


            string filePath = "numbers.txt"; //запись чисел с клавиатуры
            while (true)
            {
                Console.Write("Введите число (или 'exit' для завершения): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                if (double.TryParse(input, out double number))
                {
                    WriteNumberToFile(filePath, number);
                    Console.WriteLine($"Число {number} успешно записано в файл.");
                }
                else
                {
                    Console.WriteLine("Неверный формат числа. Попробуйте еще раз.");
                }
            }

            string filePath6 = "numbers.txt"; //среднее арифметическое
            if (File.Exists(filePath6))
            {
                double average = CalculateAverage(filePath6);
                Console.WriteLine($"Среднее арифметическое значение чисел в файле: {average}");
            }
            else
            {
                Console.WriteLine("Файл 'numbers.txt' не найден.");
            }

            string fileName7 = Console.ReadLine(); //просмотр
            string filePath7 = Path.Combine(Directory.GetCurrentDirectory(), fileName7);
            if (File.Exists(filePath7))
            {
                Console.WriteLine($"Содержимое файла '{fileName7}':");
                string fileContent7 = File.ReadAllText(filePath7);
                Console.WriteLine(fileContent7);
            }
            else
            {
                Console.WriteLine($"Файл '{fileName7}' не найден.");
            }
        }



        static void WriteNumberToFile(string filePath, double number)
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(number);
            }
        }
        static double CalculateAverage(string filePath)
        {
            using (StreamReader reader = File.OpenText(filePath))
            {
                double sum = 0;
                int count = 0;

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (double.TryParse(line, out double number))
                    {
                        sum += number;
                        count++;
                    }
                }
                if (count > 0)
                {
                    return sum / count;
                }
                else
                {
                    Console.WriteLine("Файл не содержит чисел для вычисления среднего.");
                    return 0;
                }
            }
        }
    }
}
