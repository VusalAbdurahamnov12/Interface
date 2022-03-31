using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_task_03._31._2022.Models
{
    internal class Excel : IPrintableFile
    {
        public string Filename { get; set; }
        public int ColumntCount { get; set; }
        public int RowCount { get; set; }
        public void PrintFile()
        {
            Console.WriteLine($"{Filename}Printed\nRowCount{RowCount} ColumntCount{ColumntCount}");
        }
        public Excel(string filename,int columnCount,int rowCount)
        {
            Filename=filename;
            ColumntCount=columnCount;
            RowCount=rowCount;
        }
    }
}
