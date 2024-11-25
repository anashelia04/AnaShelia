using System;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Console.WriteLine("To turn off program type \"exit\" otherwise enter the directory path: ");

        while (true)
        {
           string entered = Console.ReadLine();
           if (entered == "exit")
           {
             break;
           }

          if (Directory.Exists(entered))
          {
              printFilesInDirectory(entered);
           }
           else
           {
               Console.WriteLine("The directory " + entered + " does not exist!");
           }
}
        }
        static void printFilesInDirectory(string entered)
        {

            Console.WriteLine("Files in directory: " + entered + " ");
            string[] files = null;
            string[] directories = null;


          if (Directory.Exists(entered))
           {
                files = Directory.GetFiles(entered);

               foreach (string file in files)
               {
                   Console.WriteLine(Directory.GetFiles(file) + " ");
              }

               directories = Directory.GetDirectories(entered);
            }


           if (directories != null)
           {
              foreach (string directory in directories)
               {
                    printFilesInDirectory(directory);
               }
            }
        }
    }
}
