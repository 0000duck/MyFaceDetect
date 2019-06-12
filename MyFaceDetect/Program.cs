using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace MyFaceDetect
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Mat img = Cv2.ImRead("D:\\MyData\\girl2.jpg");
            //Cv2.ImShow("srcImg",img);
            //Cv2.PutText(img, "dsfsf", new Point(30,30), HersheyFonts.HersheySimplex, 1, new Scalar(0, 255, 0), 2);
            //Cv2.ImShow("dstimg",img);
            //Cv2.WaitKey();
        }
    }
}
