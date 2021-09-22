using System;
using System.IO;

namespace LearningVisualStudioC
{
    internal class ReadText
    {
        public static void ReadATextFile()
        {
            string text = System.IO.File.ReadAllText(@"D:\Web Developement\Visual Studio\C#\LearningVisualStudioC\LearningVisualStudioC\new.txt");
            Console.WriteLine("Txtfile contains the following: {0}", text);
        }

        public static void ReadAllLines()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\Web Developement\Visual Studio\C#\LearningVisualStudioC\LearningVisualStudioC\new.txt");

            Console.WriteLine("Contents of txt are:");
            foreach (string line in lines)
            {
                Console.WriteLine($"\t {line}");
            }
        }

        public static void WriteFile()
        {
            string[] lines = { "first line", "second line", "third line" };
            File.WriteAllLines(@"D:\Web Developement\Visual Studio\C#\LearningVisualStudioC\LearningVisualStudioC\written.txt", lines);
        }

        public static void StreamWriting()
        {
            string[] lines = { "first 1", "second 2", "third 3" };

            using (StreamWriter file = new StreamWriter(@"D:\Web Developement\Visual Studio\C#\LearningVisualStudioC\LearningVisualStudioC\StreamWriter.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }

        public static void AddStreamWriter()
        {
            using (StreamWriter file = new StreamWriter(@"D:\Web Developement\Visual Studio\C#\LearningVisualStudioC\LearningVisualStudioC\StreamWriter.txt", true))
            {
                file.WriteLine("append me");
            }
        }
    }
}