using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace ExampleWithNG
{
    class Program
    {
        static void Main(string[] args)
        {
            Pix img = Pix.LoadFromFile("images/i1.jpg");
            TesseractEngine engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
            Page page = engine.Process(img, PageSegMode.Auto);
            string result = page.GetText();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(result);
        }
    }
}
