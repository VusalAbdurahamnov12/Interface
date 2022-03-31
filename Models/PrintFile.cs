using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_task_03._31._2022.Models
{
    public class PrintFile<T> where T : IPrintableFile
    {
        public void Print(T file)
        {
            file.PrintFile();
        }
    }
}
