using System;
using System.IO;

namespace FileReaderandWriterUtility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Reader reader;
            if (args.Length != 0)
            {
                reader = new Reader(args[0]);
                Console.WriteLine(reader.Read());
            }
            else
            {
                Console.WriteLine("Вы забыли указать имя файла!");
            }
        }
    }
}