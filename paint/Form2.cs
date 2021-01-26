using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        } 
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Width = 980;
            this.Height = 600;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
           

            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
           Image dog = Image.FromFile(@"C:\dog.png");
            graph.FillRectangle(Brushes.Aquamarine, 0, 0, 980, 400);
            
            graph.FillRectangle(Brushes.Blue, 450, 200, 250, 200);
            graph.FillRectangle(Brushes.White, 490, 250, 50, 50);
            graph.FillRectangle(Brushes.White, 615, 250, 50, 50);
            graph.FillRectangle(Brushes.Black, 560, 324, 40, 75);
        
            PointF point1 = new PointF(450,200);
            PointF point2 = new PointF(580, 100);
            PointF point3 = new PointF(700, 200);
            PointF[] curvePoints = { point1, point2, point3 };
            graph.FillPolygon(Brushes.Violet, curvePoints);
            
            graph.FillRectangle(Brushes.Green, 0, 400, 980 , 200); 
            graph.DrawImage(dog, 680, 400, 120, 120);
            graph.FillRectangle(Brushes.Brown, 220, 200, 30, 200);
            graph.FillEllipse(Brushes.Green, 143, 50, 185, 200);
           
            graph.FillEllipse(Brushes.Yellow, 670, 10, 150, 150);
          
            graph.FillEllipse(Brushes.White, 750, 10, 130, 100);
            graph.FillEllipse(Brushes.White, 820, 30, 130, 100);  
            graph.FillEllipse(Brushes.White, 770, 70, 130, 90);
            graph.FillEllipse(Brushes.White, 700, 80, 130, 90);

            Font font = new Font("Times New Roman", 20, FontStyle.Bold |
FontStyle.Italic);
            Point point = new Point(10, 500);
            graph.DrawString("Выполнил: Саранцев Егор - 425 группа", font, Brushes.Black, point);

            picture.Image = bmp;
        }

      
    }
}
