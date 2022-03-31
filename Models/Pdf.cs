using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_task_03._31._2022.Models
{
    internal class Pdf : IPrintableFile
    {
        public string Filename { get; set; }
        public int PageCount { get; set; }

        public void PrintFile()
        {
            Console.WriteLine($"{Filename}Printed Pagecount{PageCount}");
        }
        public Pdf(string filename,int pagecount)
        {
            Filename = filename;
            PageCount = pagecount;
        }
    }
}
