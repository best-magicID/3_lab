using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба3
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Скачивание файлов // Адресс, фармат, Путь сохранения
            DonwloadFiles donwload = new DonwloadFiles("https://pcoding.ru/darkNet.php", "rar", "E:\\Лабы34\\Лаба3\\Лаба3\\MyDir\\");
            donwload.Donwload();

            Console.ReadLine();
        }
    }
}
