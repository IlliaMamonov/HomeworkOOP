using System;
using System.Collections;
using System.Collections.Generic;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {

            var file1 = new File();
            var file2 = new File();
            var shortcut1 = new Shortcut() { Content = file1 };
            Console.WriteLine(shortcut1.Content.Name);
            var folder1 = new Folder() { Content = { file1, file2 } } ;
            var folder2 = new Folder() { Content = { folder1, shortcut1 } };

        }

    }
        
}

