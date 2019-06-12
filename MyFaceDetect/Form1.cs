using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.Face;
namespace MyFaceDetect
{
    public partial class Form1 : Form
    {
        FaceDetect faceDetect;         //人脸识别类，里面包含各种方法
        VideoCapture cap;
        Thread videoThread,grabThread; //定义线程显示摄像头获得的信息
        Mat img = new Mat();           //保存摄像头获得的图像
        Rect[] faces;                  //保存人脸矩形框
        Mat saveMat;                   //保存grabBox中的图片
        public Form1()
        {
            faceDetect = new FaceDetect();
            cap = new VideoCapture();
            cap.Open(0);
            videoThread = new Thread(new ThreadStart(videoShow));
            //grabThread = new Thread(new ThreadStart(grabFunc));
            
            videoThread.Start();
           // grabThread.Start();

            videoThread.IsBackground = true;
            //grabThread.IsBackground = true;
            InitializeComponent();
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 用于全局检测异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show((e.ExceptionObject as Exception).ToString());
        }
        /// <summary>
        /// 该函数在picBox显示图像，本系统暂且没用到
        /// </summary>
        private void grabFunc()
        {
            while (true)
            {
                Mat im = new Mat();
                
                cap.Read(im);

                pictureBox.BeginInvoke(new Action<Mat>(t =>
                {
                    pictureBox.Image = t.ToBitmap();
                }), im);
               // im.Release();
            }
        }
        /// <summary>
        /// 获取1帧图片，用于之后的保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grab_button_Click(object sender, EventArgs e)
        {
            List<Mat> dstFaces = faceDetect.GetFaces(img, faces);
            if (dstFaces.Count > 0) {
                grabBox.Image = dstFaces[0].ToBitmap();
                saveMat = dstFaces[0];
            }
        }
        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_button_Click(object sender, EventArgs e)
        {
            string name = picName.Text.ToString();
            if (name.Equals(""))
            {
                MessageBox.Show("名字不能为空");
            }
            else
            {
                faceDetect.UpdateImagesInfos(name, saveMat);
               // MessageBox.Show("保存成功");
            }
        }

        private void train_button_Click(object sender, EventArgs e)
        {
            faceDetect.GetFaceRecognizer();
        }

        /// <summary>
        /// 该线程用于识别人脸并显示人脸对应的名字
        /// </summary>
        private void videoShow()
        {
            while (true)
            {
                //Mat img = new Mat();
                cap.Read(img);
                faces = faceDetect.GetFaceRects(img);
                List<Mat> dstFaces = faceDetect.GetFaces(img,faces);
                if (dstFaces.Count>0)
                {
                    //bool flag1 = true;
                    //grabBox.BeginInvoke(new Action<Mat>(t =>
                    //{
                    //    grabBox.Image = t.ToBitmap();
                    //    flag1 = false;
                    //}), dstFaces[0]);
                    //while (flag1)
                    //{
                    //    Thread.Sleep(10);
                    //}
                    List<string> names = faceDetect.PredictFace(dstFaces);
                    if (names.Count > 0)
                    {
                        grabBox.BeginInvoke(new Action<string>(t =>
                        {
                            label2.Text = t;
                        }), names[0]);                       
                    }
                    Bitmap bitmap = img.ToBitmap();
                    faceDetect.ShowFaceRects(faces,bitmap, names);
                    
                    bool flag2 = true;
                    pictureBox.BeginInvoke(new Action<Bitmap>(t =>
                    {
                        pictureBox.Image = t;
                        flag2 = false;

                    }), bitmap);
                    while (flag2)
                    {
                        Thread.Sleep(10);
                    }
                }
                //Cv2.WaitKey(100);
            }
        }

       
    }
}
