using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SkyctrlOCR

{
    interface IOCREngine
    {
         string Recognize(Image image);
        string Recognize(string imageBase64);
    }
}
