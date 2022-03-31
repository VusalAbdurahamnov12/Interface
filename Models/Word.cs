using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_task_03._31._2022.Models
{
    internal class Word : IPrintableFile
    {
        public string Filename { get; set; }
        public int WordCount { get; set; }
        public void PrintFile()
        {
            Console.WriteLine($"{Filename}Printed WordCount{WordCount}"); ;
        }
        public Word(string filename,int wordCount)
        {
            Filename = filename;
            WordCount = wordCount;
        }
    }
}
