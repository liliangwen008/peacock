using System;
using System.Drawing;
using System.IO;

namespace SkyctrlOCR
{
    class Program
    {
        static void Main(string[] args)
     
        {
            String fileFullName = "C:\\Users\\liliangwen\\Pictures\\dddd.JPG";
            IOCREngine ocr = new OneNoteOCREngine();
            Bitmap bmp = new Bitmap(fileFullName);
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] arr = new byte[ms.Length]; ms.Position = 0;
            ms.Read(arr, 0, (int)ms.Length); ms.Close();
            String  base64  = Convert.ToBase64String(arr);

            String result  = ocr.Recognize(base64);
            System.Console.WriteLine(result);
            Console.Read();

        }
    }

}
