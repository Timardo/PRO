using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRO
{
    public partial class FormPaint : Form
    {
        private bool drawing = false;
        private bool smajliky;
        private Point lastLoc;

        public FormPaint(bool smajliky)
        {
            InitializeComponent();
            this.smajliky = smajliky;
            PaintBox.Image = new Bitmap(PaintBox.Size.Width, PaintBox.Size.Height);
        }

        private void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (!drawing || smajliky) return;

            using (Graphics graphics = PaintBox.CreateGraphics())
            {
                graphics.DrawLine(new Pen(Color.Turquoise, 1), e.Location, lastLoc);
                lastLoc = e.Location;
            }
        }

        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            if (smajliky)
            {
                Bitmap oldImg = new Bitmap(PaintBox.Image);

                using (Graphics graphics = Graphics.FromImage(oldImg))
                {
                    graphics.DrawImage(new Bitmap(Application.StartupPath + "/smajliky.png"), new Point(e.X - 38, e.Y - 35));
                }
                
                PaintBox.Image = oldImg;
                return;
            }

            drawing = true;
            lastLoc = e.Location;
        }

        private void MouseReleaseEvent(object sender, MouseEventArgs e)
        {
            drawing = false;
        }
    }
}
