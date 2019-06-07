using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Utilities
{
    public static class ImageManagement
    {
        public static byte[] ImageToByte(string url)
        {
            Image img = Image.FromFile(url);
            using (var ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static string TemporaryImage(Image image)
        {
            string fileName = Path.GetTempFileName() + ".jpg";

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                Bitmap bmp = new Bitmap(image);
                bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            return fileName;
        }

        public static Image ByteToImage(byte[] image)
        {
            using (var ms = new MemoryStream(image, false))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
