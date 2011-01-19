using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace BNT
{
    class MapBtn
    {

        static Bitmap bg = global::BNT.Properties.Resources.button_green;
        static Bitmap bgSmall = global::BNT.Properties.Resources.button_green_small;
        static Bitmap bp = global::BNT.Properties.Resources.button_purple;
        Rectangle pozycja;
        TransparentPictureBox ikona = new TransparentPictureBox();
        TransparentLabel nazwaMiasta = new TransparentLabel();
        Panel panelMiasto;
        TabPage tabPage;

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
        private class TransparentLabel : Label
        {
            public TransparentLabel()
            {
                this.borderSize = 1f;
                this.borderColor = Color.White;
                this.drawPath = new GraphicsPath();
                this.drawPen = new Pen(new SolidBrush(this.borderColor), borderSize);
                this.forecolorBrush = new SolidBrush(this.ForeColor);
    
                this.Invalidate();
                this.SetStyle(ControlStyles.Opaque, true);
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
            }
            protected override CreateParams CreateParams
            {
                get
                {
                    CreateParams parms = base.CreateParams;
                    parms.ExStyle |= 0x20;  // Włączenie flagi stylu WS_EX_TRANSPARENT
                    return parms;
                }
            }


            //dodatkowo dla borderu
            private float borderSize;
            private Color borderColor;

            private PointF point;
            private SizeF drawSize;
            private Pen drawPen;
            private GraphicsPath drawPath;
            private SolidBrush forecolorBrush;

            // Constructor
            //-----------------------------------------------------

            // Public Properties
            //-----------------------------------------------------

            #region Public Properties
            /// <summary>
            ///   The border's thickness
            /// </summary>
            [Browsable(true)]
            [Category("Appearance")]
            [Description("The border's thickness")]
            [DefaultValue(1f)]
            public float BorderSize
            {
                get { return this.borderSize; }
                set
                {
                    this.borderSize = value;
                    if (value == 0)
                    {
                        //If border size equals zero, disable the
                        // border by setting it as transparent
                        this.drawPen.Color = Color.Transparent;
                    }
                    else
                    {
                        this.drawPen.Color = this.BorderColor;
                        this.drawPen.Width = value;
                    }

                    this.OnTextChanged(EventArgs.Empty);
                }
            }

            /// <summary>
            ///   The border color of this component
            /// </summary>
            [Browsable(true)]
            [Category("Appearance")]
            [DefaultValue(typeof(Color), "White")]
            [Description("The border color of this component")]
            public Color BorderColor
            {
                get { return this.borderColor; }
                set
                {
                    this.borderColor = value;
            
                    if (this.BorderSize != 0)
                        this.drawPen.Color = value;
        
                    this.Invalidate();
                }
            }
            #endregion

            // Event Handling
            //-----------------------------------------------------
    
            #region Event Handling
            protected override void OnFontChanged(EventArgs e)
            {
                base.OnFontChanged(e);
                this.Invalidate();
            }

            protected override void OnTextAlignChanged(EventArgs e)
            {
                base.OnTextAlignChanged(e);
                this.Invalidate();
            }

            protected override void OnTextChanged(EventArgs e)
            {
                base.OnTextChanged(e);
            }

            protected override void OnForeColorChanged(EventArgs e)
            {
                this.forecolorBrush.Color = base.ForeColor;
                base.OnForeColorChanged(e);
                this.Invalidate();
            }
            #endregion

            // Drawning Events
            //-----------------------------------------------------

            #region Drawning
            protected override void OnPaint(PaintEventArgs e)
            {
                // First let's check if we indeed have text to draw.
                //  if we have no text, then we have nothing to do.
                if (this.Text.Length == 0)
                    return;

                // Secondly, let's begin setting the smoothing mode to AntiAlias, to
                // reduce image sharpening and compositing quality to HighQuality,
                // to improve our drawnings and produce a better looking image.

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

                // Next, we measure how much space our drawning will use on the control.
                //  this is important so we can determine the correct position for our text.
                this.drawSize = e.Graphics.MeasureString(this.Text, this.Font, new PointF(),
                            StringFormat.GenericTypographic);

                // Now, we can determine how we should align our text in the control
                //  area, both horizontally and vertically. If the control is set to auto
                //  size itself, then it should be automatically drawn to the standard position.

                if (this.AutoSize)
                {
                    this.point.X = this.Padding.Left;
                    this.point.Y = this.Padding.Top;
                }
                else
                {
                    // Text is Left-Aligned:
                    if (this.TextAlign == ContentAlignment.TopLeft ||
                        this.TextAlign == ContentAlignment.MiddleLeft ||
                        this.TextAlign == ContentAlignment.BottomLeft)
                        this.point.X = this.Padding.Left;

                    // Text is Center-Aligned
                    else if (this.TextAlign == ContentAlignment.TopCenter ||
                        this.TextAlign == ContentAlignment.MiddleCenter ||
                        this.TextAlign == ContentAlignment.BottomCenter)
                        point.X = (this.Width - this.drawSize.Width) / 2;

                    // Text is Right-Aligned
                    else point.X = this.Width - (this.Padding.Right + this.drawSize.Width);

                    // Text is Top-Aligned
                    if (this.TextAlign == ContentAlignment.TopLeft ||
                        this.TextAlign == ContentAlignment.TopCenter ||
                        this.TextAlign == ContentAlignment.TopRight)
                        point.Y = this.Padding.Top;

                    // Text is Middle-Aligned
                    else if (this.TextAlign == ContentAlignment.MiddleLeft ||
                        this.TextAlign == ContentAlignment.MiddleCenter ||
                        this.TextAlign == ContentAlignment.MiddleRight)
                        point.Y = (this.Height - this.drawSize.Height) / 2;

                    // Text is Bottom-Aligned
                    else point.Y = this.Height - (this.Padding.Bottom + this.drawSize.Height);
                }

                // Now we can draw our text to a graphics path.
                //  
                //   PS: this is a tricky part: AddString() expects float emSize in pixel, 
                //   but Font.Size measures it as points.
                //   So, we need to convert between points and pixels, which in
                //   turn requires detailed knowledge of the DPI of the device we are drawing on. 
                //
                //   The solution was to get the last value returned by the 
                //   Graphics.DpiY property and
                //   divide by 72, since point is 1/72 of an inch, 
                //   no matter on what device we draw.
                //
                //   The source of this solution can be seen on CodeProject's article
                //   'OSD window with animation effect' - 
                //   http://www.codeproject.com/csharp/OSDwindow.asp

                float fontSize = e.Graphics.DpiY * this.Font.SizeInPoints / 72;

                this.drawPath.Reset();
                this.drawPath.AddString(this.Text, this.Font.FontFamily,
                                (int)this.Font.Style, fontSize,
                                    point, StringFormat.GenericTypographic);

                // And finally, using our pen, all we have to do now
                //  is draw our graphics path to the screen. Voila!
                e.Graphics.FillPath(this.forecolorBrush, this.drawPath);
                e.Graphics.DrawPath(this.drawPen, this.drawPath);
            }

            #endregion

            /// <summary>
            ///   Releases all resources used by this control
            /// </summary>
            /// <param name="disposing">True to release both managed and unmanaged resources.
            /// </param>
            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    if (this.forecolorBrush != null)
                        this.forecolorBrush.Dispose();

                    if (this.drawPath != null)
                        this.drawPath.Dispose();

                    if (this.drawPen != null)
                        this.drawPen.Dispose();
                }
                base.Dispose(disposing);
            }
        }

        public MapBtn(TabPage tab, Panel panelMiasto, string nazwa, short wspX, short wspY)
        {
            pozycja = new Rectangle(wspX - bg.Width/2, wspY - bg.Height/2, bg.Width-5, bg.Height-5);
            this.panelMiasto = panelMiasto;
            this.panelMiasto.Visible = false;
            this.ikona.Image = bgSmall;
            this.ikona.Location = new Point(pozycja.X, pozycja.Y);
            this.ikona.Name = "pictureBoxMapa";
            this.ikona.Size = new System.Drawing.Size(pozycja.Width, pozycja.Height);
            this.ikona.TabIndex = 0;
            this.ikona.TabStop = false;
            this.ikona.MouseEnter += new System.EventHandler(this.MyszNad);
            this.ikona.MouseLeave += new System.EventHandler(this.MyszPoza);
            this.ikona.MouseClick += new MouseEventHandler(this.MyszClick);
            this.nazwaMiasta.Text = nazwa;
            this.nazwaMiasta.Location = new Point(pozycja.X + 30, pozycja.Y - 25);
            this.nazwaMiasta.Font = new Font(new FontFamily("Arial Black"), 30);
            this.nazwaMiasta.ForeColor = Color.White;
            this.nazwaMiasta.BorderColor = Color.Black;
            this.nazwaMiasta.BorderSize = 3;
            this.nazwaMiasta.AutoSize = true;
            this.nazwaMiasta.Visible = false;
            this.tabPage = tab;
            tab.Controls.Add(ikona);
            tab.Controls.Add(nazwaMiasta);

            MyszPoza(null, null);
        }

        private void WypelnijPanel()
        {
            nazwaMiasta.Visible = false;
            panelMiasto.Location = nazwaMiasta.Location;
            panelMiasto.Controls["labelMiasto"].Text = nazwaMiasta.Text;
            panelMiasto.Visible = true;
            SQL sql = new SQL();
            int[] dane = sql.Ilosci(nazwaMiasta.Text);
            panelMiasto.Controls["labelSlupy"].Text = dane[0].ToString();
            panelMiasto.Controls["labelNadajniki"].Text = dane[1].ToString();
            panelMiasto.Controls["labelFirmy"].Text = dane[2].ToString();

        }

        void MyszClick(object sender, MouseEventArgs e)
        {
            if (ikona.Image != bp)
            {
                foreach (Control c in tabPage.Controls) //odlikniecie pozostalych ikon
                {
                    if (c is TransparentPictureBox)
                    {
                        TransparentPictureBox pb = ((TransparentPictureBox)c);
                        if (pb.Image == bp) //tylko jesli nie klikniety
                        {
                            pb.Image = bgSmall;
                        }
                    }
                }

                ikona.Image = bp;
                WypelnijPanel();
                nazwaMiasta.Visible = false;
            }
            else
            {
                //mysz nad przyciskiem
                ikona.Image = bg;
                nazwaMiasta.Visible = true;
                panelMiasto.Visible = false;
            }
            
        }

        private void MyszNad(object sender, EventArgs e)
        {
            if (ikona.Image != bp)
            {
                ikona.Location = new Point(pozycja.X - 7, pozycja.Y - 7);
                ikona.Size = new System.Drawing.Size(bg.Width, bg.Height);
                ikona.Image = bg;
                nazwaMiasta.Visible = true;
            }
        }

        private void MyszPoza(object sender, EventArgs e)
        {
            if (ikona.Image != bp) //tylko jesli nie klikniety
            {
                ikona.Image = bgSmall; 
                ikona.Location = new Point(pozycja.X, pozycja.Y);                
                ikona.Size = new System.Drawing.Size(bgSmall.Width, bgSmall.Height);
                nazwaMiasta.Visible = false;
            }
        }
    }
}
