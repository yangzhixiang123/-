using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 飞行棋
{
    public partial class 骰子 : UserControl
    {
        public int TouZi()
        {
            Random rand = new Random();
            int i = rand.Next() % 6 + 1;
            return i;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using(System.Drawing.Drawing2D.GraphicsPath path=new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddRectangle(new RectangleF(0,0,40,40));
                //先画背景色
                using (SolidBrush b = new SolidBrush(Color.Red))
                {
                    e.Graphics.FillPath(b, path);
                }
                //再画边框
                using(Pen p=new Pen(Color.Black))
                {
                    e.Graphics.DrawPath(p, path);
                }
                //考虑点数 
                int point = this.TouZi();
                if (point == 1)
                {
                    RectangleF rect = new RectangleF(5,5, 30, 30);
                    using (SolidBrush b = new SolidBrush(Color.White))
                    {
                        e.Graphics.FillEllipse(b, rect);
                    }
                }
                else if (point == 2)
                {
                    RectangleF rect1 = new RectangleF(15,6,10,10);
                    RectangleF rect2 = new RectangleF(15,24,10,10);
                    using (SolidBrush b = new SolidBrush(Color.White))
                    {
                        e.Graphics.FillEllipse(b, rect1);
                        e.Graphics.FillEllipse(b, rect2);
                    }
                }
                else if (point == 3)
                {
                    RectangleF rect1 = new RectangleF(15,3,10,10);
                    RectangleF rect2 = new RectangleF(15,15,10,10);
                    RectangleF rect3 = new RectangleF(15,27,10,10);
                    using(SolidBrush b=new SolidBrush(Color.White))
                    {
                        e.Graphics.FillEllipse(b, rect1);
                        e.Graphics.FillEllipse(b, rect2);
                        e.Graphics.FillEllipse(b, rect3);
                    }
                }
                else if (point == 4)
                {
                    using(SolidBrush b=new SolidBrush(Color.White))
                    {
                        e.Graphics.FillEllipse(b, new RectangleF(6,6,10,10));
                        e.Graphics.FillEllipse(b, new RectangleF(24,6,10,10));
                        e.Graphics.FillEllipse(b, new RectangleF(6,24,10,10));
                        e.Graphics.FillEllipse(b, new RectangleF(24,24,10,10));
                    }
                }
                else if (point == 5)
                {
                    using (SolidBrush b = new SolidBrush(Color.White))
                    {
                        e.Graphics.FillEllipse(b, new RectangleF(6, 6, 10, 10));
                        e.Graphics.FillEllipse(b, new RectangleF(24, 6, 10, 10));
                        e.Graphics.FillEllipse(b, new RectangleF(6, 24, 10, 10));
                        e.Graphics.FillEllipse(b, new RectangleF(24, 24, 10, 10));
                        e.Graphics.FillEllipse(b, new RectangleF(15,15,10,10));
                    }
                }
                else
                {
                    using(SolidBrush b=new SolidBrush(Color.White))
                    {
                        e.Graphics.FillEllipse(b, new RectangleF(8,3,10,10));
                        e.Graphics.FillEllipse(b, new RectangleF(8,15,10,10));
                        e.Graphics.FillEllipse(b, new RectangleF(8,27,10,10));
                        e.Graphics.FillEllipse(b, new RectangleF(24, 3, 10, 10));
                        e.Graphics.FillEllipse(b, new RectangleF(24, 15, 10, 10));
                        e.Graphics.FillEllipse(b, new RectangleF(24, 27, 10, 10));
                    }
                }
            }
        }

      
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.Invalidate();
        }
        public 骰子()
        {
            InitializeComponent();
        }
    }
}
