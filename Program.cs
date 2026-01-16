using System;
using System.IO;

namespace FileReaderandWriterUtility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Reader reader;
            Writer writer;
            if (args.Length != 0 && args[1] == "-r")
            {
                reader = new Reader(args[0]);
                Console.WriteLine(reader.Read());
            }
            else if (args.Length != 0 && args[1] == "-w")
            {
                writer = new Writer(args[0]);
                writer.Write(args[2]);
            }
            else
            {
                Console.WriteLine("Вы забыли указать имя файла!");
            }
        }
    }
}