using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_O_true
{
    class Doc
    {
        public virtual void Export()
        {

        }
    }

    class WordDoc : Doc
    {
        public override void Export()
        {
            Console.WriteLine("Export document to Word file!");
        }
    }

    class ExcelDoc : Doc
    {
        public override void Export()
        {
            Console.WriteLine("Export document to Excel file!");
        }
    }

    //Tạo thêm 1 class để xuất ra file PDF
    class PDFDoc : Doc
    {
        public override void Export()
        {
            Console.WriteLine("Export document to PDF file!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Doc wordDoc = new WordDoc();
            Doc excelDoc = new ExcelDoc();
            Doc pdfDoc = new PDFDoc();

            wordDoc.Export();
            excelDoc.Export();
            pdfDoc.Export();

            Console.ReadKey();
        }
    }
}
