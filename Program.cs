using System;
using System.Collections.Generic;
using System.IO;

namespace lspath
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = Environment.GetEnvironmentVariable("PATH");
            IEnumerable<string> pathDirs = path.Split(Path.PathSeparator);
            
            foreach (string pathDir in pathDirs)
                Console.WriteLine(pathDir);
        }
    }
}
