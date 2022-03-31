using System;
using Interface_task_03._31._2022.Models;
namespace Interface_task_03._31._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Excel excel = new Excel("excel.xlxs", 5, 10);
            Word word = new Word("word.docx", 50);
            Pdf pdf = new Pdf("Pdf.pdf",50);

            PrintFile<Excel> ex = new PrintFile<Excel>();
            PrintFile<Word> wo = new PrintFile<Word>();
            PrintFile<Pdf> pd = new PrintFile<Pdf>();
            ex.Print(excel);
            wo.Print(word);
            pd.Print(pdf);
            new PrintFileNor(word);
            new PrintFileNor(excel);
            new PrintFileNor(pdf);

        }
    }
}
