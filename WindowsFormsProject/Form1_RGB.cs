using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsProject
{
    public partial class Form1_RGB : Form
    {
        Image mOriginal;

        private Point LastPoint;
        private List<Point> pointList;
        private List<List<Point>> curveList;
        private Bitmap img;
        String file_path = "";

        private double ratio = 1F;
        private Point imgPoint;
        private Rectangle imgRect;
        private Point clickPoint;

        public Form1_RGB()
        {
            InitializeComponent();

            pointList = new List<Point>();
            curveList = new List<List<Point>>();

            this.pictureBox1.MouseWheel
                += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseWheel);

            //imgPoint = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            //imgRect = new Rectangle(0, 0, img.Width, img.Height);
            //ratio = 1.0;
            //clickPoint = imgPoint;
            //vScrollBar1.Minimum = 0;
            //vScrollBar1.Maximum = imgRect.Height - pictureBox1.Height;
            //hScrollBar1.Minimum = 0;
            //hScrollBar1.Maximum = imgRect.Width - pictureBox1.Width;


            ////img = new Bitmap(WindowsFormsProject.Properties.Resources.friend);
            ////img = new Bitmap(pictureBox1.Load(@"C: \\Users\\moble\\Desktop\\C#자료");


            ////imgPoint = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            ////imgRect = new Rectangle(0,0,img.Width,img.Height);
            ////ratio = 1.0;
            ////clickPoint = imgPoint;

            ////hScrollBar1.Minimum = 0;
            ////hScrollBar1.Maximum = imgRect.Width - pictureBox1.Width;

            ////vScrollBar1.Minimum = 0;
            ////vScrollBar1.Maximum = imgRect.Height - pictureBox1.Height;

            ////pictureBox1.Invalidate();

        }

        private void but_Blow_Click(object sender, EventArgs e)
        {
            

            //오픈다이얼로그 초기화 경로
            openFileDialog1.InitialDirectory = "C: \\Users\\moble\\Desktop\\C#자료";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                file_path = openFileDialog1.FileName;

            //이미지 사이즈 모드 설정
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // 이미지 가져와 픽쳐박스에 대입
            pictureBox1.Image = Image.FromFile(file_path);

            mOriginal = pictureBox1.Image.Clone() as Image;
            //원본 데이터를 백업한다.
        }


        private Bitmap PicturBoxReset()
        {

            pictureBox1.Image.Dispose();
            //데이터를 드랍시킨다..
            pictureBox1.Image = mOriginal.Clone() as Image;
            //복사본을 가져온다.
            Bitmap tmp = pictureBox1.Image as Bitmap;
            //픽셀 정보를 알아오기 위하여 비트맵을 얻어온다.
            return tmp;
        }

        private void but_Black_Click(object sender, EventArgs e)
        {//흑색 변환
            Bitmap tmp = PicturBoxReset();

            int width = tmp.Width;
            int height = tmp.Height;

            Color colorData;
            //총 사이즈만큼 반복을 하면서 하나하나의 픽셀을 변경한다.
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorData = tmp.GetPixel(i, j);
                    BinaryConvert(ref colorData);
                    tmp.SetPixel(i, j, colorData);
                }
            }
        }

        private void BinaryConvert(ref Color src)
        {//흑색변환 조건 382란 수치는 (255*3)/2이다. 평균보다 어두우면 검정으로 바꿈.
            if ((src.R + src.G + src.B) < 382)
            {
                src = Color.FromArgb(0, 0, 0);
            }
            else
            {
                src = Color.FromArgb(255, 255, 255);
            }
        }

        private void but_MRad_Click(object sender, EventArgs e)
        {//R계열이 강한 색만 보기
            Bitmap tmp = PicturBoxReset();

            int width = tmp.Width;
            int height = tmp.Height;

            Color colorData;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorData = tmp.GetPixel(i, j);
                    RColorConvert(ref colorData);
                    tmp.SetPixel(i, j, colorData);
                }
            }
        }
        private void RColorConvert(ref Color src)
        {
            if ((src.R < src.G) || (src.R < src.B))
            {     //레드 성분이 상대적으로 적다면 회색화

                int res = (src.R + src.G + src.B) / 3;
                src = Color.FromArgb(res, res, res);
            }

        }

        private void btn_MGreen_Click(object sender, EventArgs e)
        {//G 계열이 강한 색만 보기
            Bitmap tmp = PicturBoxReset();

            int width = tmp.Width;
            int height = tmp.Height;

            Color colorData;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorData = tmp.GetPixel(i, j);
                    GColorConvert(ref colorData);
                    tmp.SetPixel(i, j, colorData);
                }
            }
        }
        private void GColorConvert(ref Color src)
        {
            if ((src.G < src.R) || (src.G < src.B))
            {//그린 성분이 상대적으로 적다면 회색화
                int res = (src.R + src.G + src.B) / 3;
                src = Color.FromArgb(res, res, res);
            }
        }

        private void btn_MBlue_Click(object sender, EventArgs e)
        {
            Bitmap tmp = PicturBoxReset();

            int width = tmp.Width;
            int height = tmp.Height;

            Color colorData;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorData = tmp.GetPixel(i, j);
                    BColorConvert(ref colorData);
                    tmp.SetPixel(i, j, colorData);
                }
            }
        }
        private void BColorConvert(ref Color src)
        {
            if ((src.B < src.R) || (src.B < src.G))
            {//블루 성분이 상대적으로 적다면 회색화
                int res = (src.R + src.G + src.B) / 3;
                src = Color.FromArgb(res, res, res);
            }
        }

        private void btn_Gray_Click(object sender, EventArgs e)
        {
            Bitmap tmp = PicturBoxReset();

            int width = tmp.Width;
            int height = tmp.Height;

            Color colorData;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorData = tmp.GetPixel(i, j);
                    GrayConvert(ref colorData);
                    tmp.SetPixel(i, j, colorData);
                }
            }
        }
        private void GrayConvert(ref Color src)
        {
            int res = (src.R + src.G + src.B) / 3;
            src = Color.FromArgb(res, res, res);
            //3개의 값의 평균으로 색상을 조정한다.
            //RGB간 색상의 격차가 없으면 없을수록 색감은 무채색을 띈다.

        }

        private void btn_Color_Change_Click(object sender, EventArgs e)
        {
            Bitmap tmp = PicturBoxReset();

            int width = tmp.Width;
            int height = tmp.Height;

            Color colorData;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorData = tmp.GetPixel(i, j);
                    Invert(ref colorData);
                    tmp.SetPixel(i, j, colorData);
                }
            }
        }
        private void Invert(ref Color src)
        {
            //0xFF(255)으로 XOR 연산하여 값을 반전시킨다.
            int r = src.R ^ 255;
            int g = src.G ^ 255;
            int b = src.B ^ 255;

            src = Color.FromArgb(r, g, b);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Dispose();    //데이터를 드랍시킨다.
            pictureBox1.Image = mOriginal.Clone() as Image;
            //복사본을 가져온다.
        }

        private void btn_Turn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = pictureBox1.Image;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                Image image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics g = Graphics.FromImage(image);
                g.Clear(Color.White);
                foreach (List<Point> curve in curveList)
                {
                    try
                    {
                        g.DrawLines(Pens.Black, curve.ToArray());
                    }
                    catch { }
                }
                image.Save("사진.png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            int lines = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
            PictureBox pb = (PictureBox)sender;
                                                         

            pictureBox1.Invalidate();

            if (lines > 0)
            {
                ratio *= 2F;
                if (ratio > 100.0) ratio = 100.0;
            }
            else if (lines < 0)
            {
                ratio *= 0.5F;
                if (ratio < 1) ratio = 1;
            }

            imgRect.Width = (int)Math.Round(img.Width * ratio);
            imgRect.Height = (int)Math.Round(img.Height * ratio);
            imgRect.X = (int)Math.Round(pb.Width / 2 - imgPoint.X * ratio);
            imgRect.Y = (int)Math.Round(pb.Height / 2 - imgPoint.Y * ratio);

            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = imgRect.Width - pb.Width;

            if (hScrollBar1.Minimum >= hScrollBar1.Maximum)
            {
                hScrollBar1.Value = hScrollBar1.Maximum;
            }
            else
            {
                hScrollBar1.Value = imgRect.X * (-1);
            }

            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = imgRect.Height - pb.Height;

            if (vScrollBar1.Minimum >= vScrollBar1.Maximum)
            {
                vScrollBar1.Value = vScrollBar1.Maximum;
            }
            else
            {
                vScrollBar1.Value = imgRect.Y * (-1);
            }

            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                clickPoint = new Point(
                    (int)Math.Round((e.X - imgRect.X) / ratio),
                    (int)Math.Round((e.Y - imgRect.Y) / ratio));
            }
            else if (e.Button == MouseButtons.Left)
            {
                clickPoint = new Point(e.X, e.Y);
            }

            pictureBox1.Invalidate();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if(img != null)
            {
                e.Graphics.InterpolationMode =
                    System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                e.Graphics.DrawImage(img, imgRect);
                pictureBox1.Focus();

                UpDown.Text = ratio.ToString();
                String Msg = String.Format("{0}, {1}", clickPoint.X,clickPoint.Y);
                Position.Text = Msg;
            }

            foreach(List<Point> curve in curveList)
            {
                try
                {
                    e.Graphics.DrawLines(Pens.Magenta, pointList.ToArray());
                }
                catch { }
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // 라인 그리기
            {
                LastPoint = new Point(e.Location.X, e.Location.Y);
                LastPoint = new Point(
                    (int)Math.Round((e.X - imgRect.X) / ratio),
                    (int)Math.Round((e.Y - imgRect.Y) / ratio));

                pointList.Add(imgPoint);
                Draw();
            }
            else if(e.Button == MouseButtons.Left) //이미지 이동
            {
                /*imgRect.X = imgRect.X + (e.X - clickPoint.X);
                이렇게 하면 이미지 스크롤 속도가 너무 빠르므로 마우스 움직임에 
                나누기 20정도 해준다.*/

                imgRect.X = imgRect.X + (int)Math.Round((double)(e.X - clickPoint.X) / (double)20);
                if (imgRect.X >= 0) imgRect.X = 0;
                if(Math.Abs(imgRect.X)>= Math.Abs(imgRect.Width - pictureBox1.Width)) 
                    imgRect.X = -(imgRect.Width-pictureBox1.Width);
                
                imgRect.Y = imgRect.Y + (int)Math.Round((double)(e.Y - clickPoint.Y) / (double)20);
                if (imgRect.Y >= 0) imgRect.Y = 0;
                if(Math.Abs(imgRect.Y) >= Math.Abs(imgRect.Height - pictureBox1.Height)) 
                    imgRect.Y = -(imgRect.Height-pictureBox1.Height);

                hScrollBar1.Value = Math.Abs(imgRect.X);
                vScrollBar1.Value = Math.Abs(imgRect.Y);

                label3.Text = String.Format("imgRect.X:{0} imgRect Y:{1}", imgRect.X, imgRect.Y);
            }
            else
            {
                LastPoint = e.Location;
            }

            pictureBox1.Invalidate();
            pictureBox2.Invalidate();
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                List<Point> curve = new List<Point>();
                curve.AddRange(pointList);
                curveList.Add(curve);
                Draw();
                pictureBox1.Invalidate();
            }
        }
        private void Draw()
        {
            if (pointList.Count >= 2)
            {
                using (Graphics g = Graphics.FromImage(img))
                {
                    g.DrawLines(Pens.Red, pointList.ToArray());
                }
            }
        }
      
        

    }
}
