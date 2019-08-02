using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace file
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string path = @"C:\Users\alena\Source\Repos\file.txt";

             long l2;
             long l;
             // создаем объект BinaryWriter
             using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                 {
                     l = 666666666666;
                     writer.Write(l);

                 }


                 using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                 {
                 // пока не достигнут конец файла
                 // считываем каждое значение из файла

                 while (reader.PeekChar() > -1)
                 {
                     l2 = reader.ReadInt64();

                     Console.Write(l2);
                 }
                 reader.Close();
                 }
             File.Delete(path);
             using (FileStream fstream = new FileStream(@"C:\Users\alena\Source\Repos\file2.txt", FileMode.OpenOrCreate))
             {
                 // преобразуем строку в байты
                 string str = l.ToString();
                 char[] ch = str.ToCharArray();
                 byte[] array = System.Text.Encoding.Default.GetBytes(ch);
                 // запись массива байтов в файл
                 fstream.Write(array, 0, array.Length);
                 Console.WriteLine("Текст записан в файл");
             }

             // чтение из файла
             using (FileStream fstream = File.OpenRead(@"C:\Users\alena\Source\Repos\file2.txt"))
             {
                 // преобразуем строку в байты
                 byte[] array = new byte[fstream.Length];
                 // считываем данные
                 fstream.Read(array, 0, array.Length);
                 // декодируем байты в строку
                 string textFromFile = System.Text.Encoding.Default.GetString(array);
                 Console.WriteLine("Текст из файла: {0}", textFromFile);

             }
             File.Delete(path);
             */
            string path1 = @"D:\fileInfo.txt";
            string path2 = @"C:\";
            using (FileStream fstream = new FileStream(path1, FileMode.OpenOrCreate))
            {
                if (Directory.Exists(path2))
                {

                    Console.WriteLine("Подкаталоги:");
                    string[] dirs = Directory.GetDirectories(path2);
                    Console.WriteLine();
                    Console.WriteLine("Файлы:");
                    string[] files = Directory.GetFiles(path2);
                    

                    byte[] array;
                    byte[] array1;
                    foreach (string s in dirs)
                    {
                        array = System.Text.Encoding.Default.GetBytes(s);

                        // запись массива байтов в файл
                        fstream.Write(array, 0, array.Length);
                    }
                    foreach (string s in files)
                    {
                        array1 = System.Text.Encoding.Default.GetBytes(s);

                        // запись массива байтов в файл
                        fstream.Write(array1, 0, array1.Length);
                    }
                    Console.WriteLine("Текст записан в файл");
                }
            }
            using (FileStream fstream = File.OpenRead(path1))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine("Текст из файла: {0}", textFromFile);


            }
        
            }

        }
    }

