using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JHPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            webView.Location = new Point(2, 32);
            webView.DefaultBackgroundColor = Color.Transparent;
            webView.Width = ClientSize.Width-4;
            webView.Height = ClientSize.Height - 34;
            this.SetStyle(ControlStyles.ResizeRedraw , true);
            InitializeAsync();
            
        }


        private async void InitializeAsync()
        {

            string _cacheFolderPath = System.IO.Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location, "\\cache");
            var webView2Environment = await CoreWebView2Environment.CreateAsync(null, _cacheFolderPath);
            await webView.EnsureCoreWebView2Async(webView2Environment);
            webView.CoreWebView2.Navigate("https://netflix.com");
        }
        private void nSlider1_Scroll(object sender, ScrollEventArgs e)
        {
            Opacity = nSlider1.Value / 100.0;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            closeBtn.Location = new Point(ClientSize.Width - 31, 1);
            watchaBtn.Location = new Point(ClientSize.Width - 61, 1);
            primeBtn.Location = new Point(ClientSize.Width - 91, 1);
            netflixBtn.Location = new Point(ClientSize.Width - 121, 1);
            youtubeBtn.Location = new Point(ClientSize.Width - 151, 1);
            laftelBtn.Location = new Point(ClientSize.Width - 181, 1);

            webView.Width = ClientSize.Width - 4;
            webView.Height = ClientSize.Height - 34;
            Update();

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void netflixBtn_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("https://netflix.com");
        }

        private void primeBtn_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("https://www.primevideo.com/");
        }

        private void watchaBtn_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("https://watcha.com");
        }

        private void youtubeBtn_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("https://youtube.com");
        }

        private const int cCaption = 32;
        private readonly ReSize resize = new ReSize();
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle bgrc = new Rectangle(2, 2, this.ClientSize.Width-4, ClientSize.Height-4);
            Brush bg = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            e.Graphics.FillRectangle(bg, bgrc);
            Color theColor = Color.FromArgb(255, 150, 150, 150);
            Brush brush = new SolidBrush(theColor);
            Brush hBrush = new SolidBrush(Color.FromArgb(255, 190, 190, 190));
            int BORDER_SIZE = 1;
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                         theColor, BORDER_SIZE, ButtonBorderStyle.Solid,
                                         theColor, BORDER_SIZE, ButtonBorderStyle.Solid,
                                         theColor, BORDER_SIZE, ButtonBorderStyle.Solid,
                                         theColor, BORDER_SIZE, ButtonBorderStyle.Solid);


            Rectangle rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(brush, rc);

            if (btnIndex != -1)
            {
                e.Graphics.FillRectangle(hBrush, ClientSize.Width - (32 * btnIndex), 0, 32, 32);
            }

            base.OnPaint(e);


        }
        int btnIndex = -1;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);


                switch (resize.GetMosuePosition(pos, this))
                {
                    case "l": m.Result = (IntPtr)10; return;  // the Mouse on Left Form
                    case "r": m.Result = (IntPtr)11; return;  // the Mouse on Right Form
                    case "a": m.Result = (IntPtr)12; return;
                    case "la": m.Result = (IntPtr)13; return;
                    case "ra": m.Result = (IntPtr)14; return;
                    case "u": m.Result = (IntPtr)15; return;
                    case "lu": m.Result = (IntPtr)16; return;
                    case "ru": m.Result = (IntPtr)17; return; // the Mouse on Right_Under Form
                    case "": m.Result = pos.Y < cCaption /*mouse on title Bar*/ ? (IntPtr)2 : (IntPtr)1; return;

                }
            }
            else if (m.Msg == 0x20)
            {  // Trap WM_SETCUROR
                if ((m.LParam.ToInt32() & 0xffff) == 5)
                { // Trap HTCAPTION
                    Cursor.Current = Cursors.Hand;
                    m.Result = (IntPtr)1;  // Processed
                    return;
                }
                else if ((m.LParam.ToInt32() & 0xffff) == 1 || (m.LParam.ToInt32() & 0xffff) == 2)
                {
                    Cursor.Current = Cursors.Default;
                    m.Result = (IntPtr)1;  // Processed
                    return;
                }
            }
            else if (m.Msg == 0xA2)
            {
                if (btnIndex == 1)
                    Application.Exit();
                else if (btnIndex == 2)
                {
                    webView.CoreWebView2.Navigate("https://watcha.com");
                }
                else if (btnIndex == 3)
                {
                    webView.CoreWebView2.Navigate("https://primevideo.com");
                }
                else if (btnIndex == 4)
                {
                    webView.CoreWebView2.Navigate("https://netflix.com");
                }
            }
            base.WndProc(ref m);
        }


        class ReSize
        {

            private bool Above, Right, Under, Left, Right_above, Right_under, Left_under, Left_above;
            readonly int Thickness = 3;  //Thickness of border  u can cheang it
            readonly int Area = 3;     //Thickness of Angle border 


            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="thickness">set thickness of form border</param>
            public ReSize(int thickness)
            {
                Thickness = thickness;
            }

            /// <summary>
            /// Constructor set thickness of form border=1
            /// </summary>
            public ReSize()
            {
                Thickness = 2;
            }

            //Get Mouse Position
            public string GetMosuePosition(Point mouse, Form form)
            {
                bool above_underArea = mouse.X > Area && mouse.X < form.ClientRectangle.Width - Area; /* |\AngleArea(Left_Above)\(=======above_underArea========)/AngleArea(Right_Above)/| */ //Area===>(==)
                bool right_left_Area = mouse.Y > Area && mouse.Y < form.ClientRectangle.Height - Area;

                bool _Above = mouse.Y <= Thickness;  //Mouse in Above All Area
                bool _Right = mouse.X >= form.ClientRectangle.Width - Thickness;
                bool _Under = mouse.Y >= form.ClientRectangle.Height - Thickness;
                bool _Left = mouse.X <= Thickness;

                Above = _Above && (above_underArea); if (Above) return "a";   /*Mouse in Above All Area WithOut Angle Area */
                Right = _Right && (right_left_Area); if (Right) return "r";
                Under = _Under && (above_underArea); if (Under) return "u";
                Left = _Left && (right_left_Area); if (Left) return "l";


                Right_above =/*Right*/ (_Right && (!right_left_Area)) && /*Above*/ (_Above && (!above_underArea)); if (Right_above) return "ra";     /*if Mouse  Right_above */
                Right_under =/* Right*/((_Right) && (!right_left_Area)) && /*Under*/(_Under && (!above_underArea)); if (Right_under) return "ru";     //if Mouse  Right_under 
                Left_under = /*Left*/((_Left) && (!right_left_Area)) && /*Under*/ (_Under && (!above_underArea)); if (Left_under) return "lu";      //if Mouse  Left_under
                Left_above = /*Left*/((_Left) && (!right_left_Area)) && /*Above*/(_Above && (!above_underArea)); if (Left_above) return "la";      //if Mouse  Left_above

                return "";

            }


        }

        private void laftelBtn_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("https://laftel.net/");
        }
    }
}
