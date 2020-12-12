using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSachDienTu.Controllers
{
    class fileController
    {
        public static string GetOpenBookFilePath()
        {
            string path = string.Empty;
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.RestoreDirectory = true;
                op.Title = "Browse file";
                op.Filter = " All file (*.*)|*.*|text file (*.txt)|*.txt|pdf file (*.pdf)|*.pdf|document file (*.doc)|*.doc";
                op.FilterIndex = 1;
                op.CheckFileExists = true;
                op.CheckPathExists = true;
                if (op.ShowDialog() == DialogResult.OK)
                {
                    path = op.FileName;
                }
                else
                {
                    path = string.Empty;
                }
            }
            return path;
        }
        public static string GetOpenImageFilePath()
        {
            string path = string.Empty;
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.RestoreDirectory = true;
                op.Title = "Browse file";
                op.Filter = " All file (*.*)|*.*|(*.png)|*.*|(*.jfif)|*.jfif|(*.jpg)|*.jpg|(*.peg)|*.peg";
                op.FilterIndex = 1;
                op.CheckFileExists = true;
                op.CheckPathExists = true;
                if (op.ShowDialog() == DialogResult.OK)
                {
                    path = op.FileName;
                }
                else
                {
                    path = string.Empty;
                }
            }
            return path;
        }
        public static string GetSavePath(string fileType, string fileName)
        {
            string path = string.Empty;
            using (SaveFileDialog op = new SaveFileDialog())
            {
                op.RestoreDirectory = true;
                op.Title = "Save as";
                op.FileName = fileName;
                op.Filter = string.Format("{0} file (*.{0})|*.{0}", fileType);
                if (op.ShowDialog() == DialogResult.OK)
                {
                    path = op.FileName;
                }
                else
                    path = string.Empty;
            }
            return path;
        }
        public static string GetFileName(string path)
        {
            return path.Trim().Substring(path.LastIndexOf('.') + 1);
        }
        public static byte[] ConvertToByteArray(string path)
        {
            return System.IO.File.ReadAllBytes(path);

        }
        public static void DowloadFile(byte[] source, string path)
        {
            System.IO.File.WriteAllBytes(path, source);
        }
    }
}
