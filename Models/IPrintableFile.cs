using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_task_03._31._2022.Models
{
    public interface IPrintableFile
    {
        public string Filename { get; set; }

        public void PrintFile();
    }
}
