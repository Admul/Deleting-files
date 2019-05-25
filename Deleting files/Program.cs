using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Deleting_files
{
    class Program
    {
        static void Main(string[] args)
        {
            int countf = 0, count = 0;

            Console.WriteLine("Введите путь к папке в которой хранятся удаляемые файлы: ");
            string path = Console.ReadLine();
            Console.WriteLine("Введите ключ удаления файлов: ");
            string name = Console.ReadLine();

            //Получаем пути файлов
            DirectoryInfo info = new DirectoryInfo(path);
            DirectoryInfo[] dirs = info.GetDirectories();
            FileInfo[] files = info.GetFiles();

            //Считаем кол-во нужных файлов в папке
            for (int i = 0; i < files.Length; i++)
                if (files[i].Name.Contains(name))
                    countf++;

            //Удаляем ненужные файлы
            for (int i = 0; i < files.Length; i++)
                if (files[i].Name.Contains(name))
                {
                    count++;
                    files[i].Delete();
                    Console.WriteLine($"Удаление {files[i].Name}\nПрогресс: {count}/{countf}");
                }

            Console.ReadKey();
        }
    }
}
