using System;
using System.IO;
using System.Text;

namespace FileReaderandWriterUtility
{
    public class Reader
    {
        private string _filePath;
        private string _fileText;

        public Reader(string filePath)
        {
            _filePath = filePath;
            _fileText = String.Empty;
        }
        
        public string Read()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    _fileText = File.ReadAllText(_filePath, Encoding.UTF8);
                }
                else
                {
                    throw new Exception("File not found!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.ToString()}");
            }
            return _fileText;
        }
        
        public string GetFullPath()
        {
            return _filePath;
        }
    }
}