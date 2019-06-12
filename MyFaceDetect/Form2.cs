using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
namespace MyFaceDetect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mat mm = Cv2.ImRead(@"D:\MyData\\girl2.jpg");
            //pictureBox1.Image =mm.ToBitmap();
            Bitmap grab = mm.ToBitmap();
            //mm.ToBitmap().Save(@"D:\MyData\picFaces\Bitmap类型.png");
            //mm.SaveImage(@"D:\MyData\picFaces\Mat类型.png");
            //pictureBox1.Image.Save(@"D:\MyData\picFaces\Image类型.png");
            Graphics g = Graphics.FromImage(grab);
            Bitmap resBitmap = new Bitmap(100, 100);
            //Random rnd = new Random();
            int count = 0;
            Font font = new Font("宋体", 16, GraphicsUnit.Pixel);
            SolidBrush fontLine = new SolidBrush(Color.Yellow);
            
            g.DrawString("郭爱斌", font, fontLine, 100, 100);
            pictureBox1.Image = grab;
        }
    }
}
