using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BNT
{
    class MapBtn
    {

        static Bitmap bg = global::BNT.Properties.Resources.button_green;
        static Bitmap bgSmall = global::BNT.Properties.Resources.button_green_small;
        static Bitmap bp = global::BNT.Properties.Resources.button_purple;
        Rectangle pozycja;
        bool czyMaly = true;
        TransparentPictureBox pictureBox = new TransparentPictureBox();

        private class TransparentPictureBox : Control
        {
            private Timer refresher;
            private Image _image = null;
            public TransparentPictureBox()
            {
                refresher = new Timer();
                refresher.Tick += new EventHandler(this.TimerOnTick);
                refresher.Interval = 50;
                refresher.Start();
            }

            protected override CreateParams CreateParams
            {
                get
                {
                    CreateParams cp = base.CreateParams;
                    cp.ExStyle |= 0x20;
                    return cp;
                }
            }

            protected override void OnMove(EventArgs e)
            {
                base.RecreateHandle();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                if (_image != null)
                    e.Graphics.DrawImage(_image, (Width / 2) - (_image.Width / 2), (Height / 2) - (_image.Height / 2));
            }

            protected override void OnPaintBackground(PaintEventArgs e)
            {
            }

            private void TimerOnTick(object source, EventArgs e)
            {
                base.RecreateHandle();
                refresher.Stop();
            }

            public Image Image
            {
                get
                {
                    return _image;
                }
                set
                {
                    _image = value;
                    base.RecreateHandle();
                }
            }
        }

        public MapBtn(TabPage tab)
        {
            pozycja = new Rectangle(50, 50, bg.Width-5, bg.Height-5);
            this.pictureBox.Image = bgSmall;
            this.pictureBox.Location = new Point(pozycja.X, pozycja.Y);
            this.pictureBox.Name = "pictureBoxMapa";
            this.pictureBox.Size = new System.Drawing.Size(pozycja.Width, pozycja.Height);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.BringToFront();
            this.pictureBox.MouseEnter += new System.EventHandler(this.MyszNad);
            this.pictureBox.MouseLeave += new System.EventHandler(this.MyszPoza);
            this.pictureBox.MouseClick += new MouseEventHandler(this.MyszClick);
            
            tab.Controls.Add(pictureBox);

            MyszPoza(null, null);
        }

        void MyszClick(object sender, MouseEventArgs e)
        {
            this.pictureBox.Image = bp;
        }

        private void MyszNad(object sender, EventArgs e)
        {
            this.pictureBox.Location = new Point(pictureBox.Location.X - 7, pictureBox.Location.Y - 7);
            this.pictureBox.Size = new System.Drawing.Size(bg.Width, bg.Height);
            this.pictureBox.Image = bg;
        }

        private void MyszPoza(object sender, EventArgs e)
        {
            this.pictureBox.Image = bgSmall;
            this.pictureBox.Location = new Point(pictureBox.Location.X + 7, pictureBox.Location.Y + 7);
            this.pictureBox.Size = new System.Drawing.Size(bgSmall.Width, bgSmall.Height); 
        }
    }
}
