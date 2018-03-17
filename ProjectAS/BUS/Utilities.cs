using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Utilities
    {
        public static bool CheckExtensionImg(string fileName)
        {
            //Ktra phần mở rộng của hình ảnh: .jpg , .png     
            string extension = System.IO.Path.GetExtension(fileName);
            if (extension.Equals(".png") || extension.Equals(".jpg"))
                return true;
            else
                return false;
        }      
    }
}
