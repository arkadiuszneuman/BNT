using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace BNT
{
    class MapButton
    {
        static Bitmap bg = global::BNT.Properties.Resources.button_green;
        static Bitmap bp = global::BNT.Properties.Resources.button_purple;
        Bitmap malowana = bg;
        PictureBox pictureBox;
        Rectangle pozycja;
        bool czyMaly = true;

        public MapButton(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            pozycja = new Rectangle(50, 50, bg.Width, bg.Height);
        }

        public void Maluj()
        {
            //
            using (Graphics g = pictureBox.CreateGraphics())
            {
                if (czyMaly)
                    pozycja = new Rectangle(pozycja.X, pozycja.Y, bg.Width, bg.Height);
                else
                    pozycja = new Rectangle(pozycja.X, pozycja.Y, bg.Width - 5, bg.Height - 5);

                g.DrawImage(malowana, pozycja);
            }
        }

        public void Odswiez(MouseEventArgs m)
        {
            if (m.X > pozycja.X) //&& m.Y > pozycja.Y && m.Y < pozycja.Height)
            {
                if (czyMaly)
                {
                    czyMaly = false;
                    pictureBox.Invalidate(pozycja);
                    Maluj();
                }
            }
            else
            {
                if (!czyMaly)
                {
                    czyMaly = true;
                    pictureBox.Invalidate(pozycja);
                    Maluj();
                }
            }
        }
    }
}
