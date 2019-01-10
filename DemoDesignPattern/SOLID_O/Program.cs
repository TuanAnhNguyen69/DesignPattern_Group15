using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_O
{
    class Doc
    {
        public void ExportToWord()
        {
            Console.WriteLine("Export document to Word file!");
        }

        public void ExportToExcel()
        {
            Console.WriteLine("Export document to Excel file!");
        }

        //thêm mới vào (phải sửa code bên trong class Doc)
        /*
        public void ExportToPDF()
        {
            Console.WriteLine("Export document to PDF file!");
        }
        */
    }
    class Program
    {
        static void Main(string[] args)
        {
            Doc doc = new Doc();
            doc.ExportToExcel();
            doc.ExportToWord();

            Console.ReadKey();
        }
    }
}
