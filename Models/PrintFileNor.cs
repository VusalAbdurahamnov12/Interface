using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_task_03._31._2022.Models
{
    public class PrintFileNor
    {
        public PrintFileNor(IPrintableFile file)
        {
            file.PrintFile();
        }
    }
}
