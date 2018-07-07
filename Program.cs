using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализация конструкций имён объектов
            char[] types = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string[] series = new string[6] { "123342", "234453", "345564", "456675", "567786", "678897" };
            string[] numbers = new string[9] { "01", "02", "03", "04", "05", "06", "07", "08", "09" };

            //Запрос порядкового номера объекта
            Console.WriteLine("Введите номер объекта:");
            int number = Convert.ToInt32(Console.ReadLine());

            //Генерация типа объекта
            int numberType = Convert.ToInt32(Math.Truncate(Convert.ToDouble(number - 1) / 594));

            //Генерация серии объекта
            int numberSeries1 = Convert.ToInt32(Math.Truncate(Convert.ToDouble(number) / 99));
            if (number % 99 == 0) numberSeries1 = numberSeries1 - 1;
            int numberSeries = Convert.ToInt32(numberSeries1 - Math.Truncate(Convert.ToDouble(numberSeries1) / 6) * 6);

            //Генерация номера объекта
            int numberNumber1 = Convert.ToInt32(number - Math.Truncate(Convert.ToDouble(number) / 99) * 99);
            if (numberNumber1 == 0) numberNumber1 = 99;
            string numberNumber;
            if (numberNumber1 <= 9) numberNumber = Convert.ToString(numbers[numberNumber1 - 1]);
            else numberNumber = Convert.ToString(numberNumber1);

            //Вывод имени объекта
            Console.WriteLine("Имя объекта: \n{0}", types[numberType] + series[numberSeries] + numberNumber + types[numberType]);

            ////Вывод всех имён объекта начиная с указанного порядкового номера
            //do
            //{
            //    //Генерация типа объекта
            //    int numberType = Convert.ToInt32(Math.Truncate(Convert.ToDouble(number - 1) / 594));

            //    //Генерация серии объекта
            //    int numberSeries1 = Convert.ToInt32(Math.Truncate(Convert.ToDouble(number) / 99));
            //    if (number % 99 == 0) numberSeries1 = numberSeries1 - 1;
            //    int numberSeries = Convert.ToInt32(numberSeries1 - Math.Truncate(Convert.ToDouble(numberSeries1) / 6) * 6);

            //    //Генерация номера объекта
            //    int numberNumber1 = Convert.ToInt32(number - Math.Truncate(Convert.ToDouble(number) / 99) * 99);
            //    if (numberNumber1 == 0) numberNumber1 = 99;
            //    string numberNumber;
            //    if (numberNumber1 <= 9) numberNumber = Convert.ToString(numbers[numberNumber1 - 1]);
            //    else numberNumber = Convert.ToString(numberNumber1);

            //    //Вывод имени объекта
            //    Console.WriteLine(types[numberType] + series[numberSeries] + numberNumber + types[numberType]);

            //    //Увеличение порядкового номера на один
            //    number++;
            //} while (number <= 15444);

            Console.ReadLine();
        }
    }
}
