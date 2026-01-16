using System;
using System.IO;
using System.Text;

namespace FileReaderandWriterUtility
{
    public class Writer
    {
        private string _filePath;

        public Writer(string path)
        {
            _filePath = path;
        }

        public void Write(string text)
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    File.WriteAllText(_filePath, text, Encoding.UTF8);
                }
                else
                {
                    throw new Exception("File not found!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}