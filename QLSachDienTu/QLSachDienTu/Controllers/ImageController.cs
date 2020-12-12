using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSachDienTu.Controllers
{
    class ImageController
    {
        public static byte[] ConvertToByteArray(Image image)
        {
            return (byte[])((new ImageConverter()).ConvertTo(image, typeof(byte[])));
        }
        public static Image ConvertByteArrayToImage(byte[] b)
        {
            if (b.Length == 0 || b == null)
            {
                return null;
            }
            return (Bitmap)((new ImageConverter()).ConvertFrom(b));
        }
    }
}
