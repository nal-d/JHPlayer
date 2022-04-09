
namespace JHPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.laftelBtn = new System.Windows.Forms.Button();
            this.youtubeBtn = new System.Windows.Forms.Button();
            this.watchaBtn = new System.Windows.Forms.Button();
            this.primeBtn = new System.Windows.Forms.Button();
            this.netflixBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.nSlider1 = new JHPlayer.NSlider();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.BackColor = System.Drawing.Color.White;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(475, 169);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(86, 25);
            this.webView.TabIndex = 3;
            this.webView.ZoomFactor = 1D;
            // 
            // laftelBtn
            // 
            this.laftelBtn.BackColor = System.Drawing.Color.Transparent;
            this.laftelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.laftelBtn.FlatAppearance.BorderSize = 0;
            this.laftelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.laftelBtn.Image = global::JHPlayer.res.laftel;
            this.laftelBtn.Location = new System.Drawing.Point(729, 308);
            this.laftelBtn.Name = "laftelBtn";
            this.laftelBtn.Size = new System.Drawing.Size(34, 30);
            this.laftelBtn.TabIndex = 9;
            this.laftelBtn.UseVisualStyleBackColor = true;
            this.laftelBtn.Click += new System.EventHandler(this.laftelBtn_Click);
            // 
            // youtubeBtn
            // 
            this.youtubeBtn.BackColor = System.Drawing.Color.Transparent;
            this.youtubeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.youtubeBtn.FlatAppearance.BorderSize = 0;
            this.youtubeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.youtubeBtn.Image = global::JHPlayer.res.youtube;
            this.youtubeBtn.Location = new System.Drawing.Point(691, 196);
            this.youtubeBtn.Name = "youtubeBtn";
            this.youtubeBtn.Size = new System.Drawing.Size(34, 30);
            this.youtubeBtn.TabIndex = 8;
            this.youtubeBtn.UseVisualStyleBackColor = false;
            this.youtubeBtn.Click += new System.EventHandler(this.youtubeBtn_Click);
            // 
            // watchaBtn
            // 
            this.watchaBtn.BackColor = System.Drawing.Color.Transparent;
            this.watchaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watchaBtn.FlatAppearance.BorderSize = 0;
            this.watchaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchaBtn.Image = global::JHPlayer.res.watcha;
            this.watchaBtn.Location = new System.Drawing.Point(729, 433);
            this.watchaBtn.Name = "watchaBtn";
            this.watchaBtn.Size = new System.Drawing.Size(34, 30);
            this.watchaBtn.TabIndex = 7;
            this.watchaBtn.UseVisualStyleBackColor = false;
            this.watchaBtn.Click += new System.EventHandler(this.watchaBtn_Click);
            // 
            // primeBtn
            // 
            this.primeBtn.BackColor = System.Drawing.Color.Transparent;
            this.primeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.primeBtn.FlatAppearance.BorderSize = 0;
            this.primeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primeBtn.Image = global::JHPlayer.res.prime;
            this.primeBtn.Location = new System.Drawing.Point(793, 388);
            this.primeBtn.Name = "primeBtn";
            this.primeBtn.Size = new System.Drawing.Size(34, 30);
            this.primeBtn.TabIndex = 6;
            this.primeBtn.UseVisualStyleBackColor = false;
            this.primeBtn.Click += new System.EventHandler(this.primeBtn_Click);
            // 
            // netflixBtn
            // 
            this.netflixBtn.BackColor = System.Drawing.Color.Transparent;
            this.netflixBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.netflixBtn.FlatAppearance.BorderSize = 0;
            this.netflixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.netflixBtn.Image = global::JHPlayer.res.netflix;
            this.netflixBtn.Location = new System.Drawing.Point(658, 372);
            this.netflixBtn.Name = "netflixBtn";
            this.netflixBtn.Size = new System.Drawing.Size(34, 30);
            this.netflixBtn.TabIndex = 5;
            this.netflixBtn.UseVisualStyleBackColor = false;
            this.netflixBtn.Click += new System.EventHandler(this.netflixBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Image = global::JHPlayer.res.cancel;
            this.closeBtn.Location = new System.Drawing.Point(877, -2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(34, 30);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // nSlider1
            // 
            this.nSlider1.BackColor = System.Drawing.Color.Transparent;
            this.nSlider1.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.nSlider1.DrawSemitransparentThumb = false;
            this.nSlider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.nSlider1.ForeColor = System.Drawing.Color.Black;
            this.nSlider1.LargeChange = ((uint)(5u));
            this.nSlider1.Location = new System.Drawing.Point(6, 2);
            this.nSlider1.Minimum = 40;
            this.nSlider1.Name = "nSlider1";
            this.nSlider1.OverlayColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.nSlider1.Size = new System.Drawing.Size(229, 30);
            this.nSlider1.SmallChange = ((uint)(1u));
            this.nSlider1.TabIndex = 2;
            this.nSlider1.Text = "nSlider1";
            this.nSlider1.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.nSlider1.ThumbSize = new System.Drawing.Size(8, 16);
            this.nSlider1.Value = 100;
            this.nSlider1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.nSlider1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(914, 522);
            this.Controls.Add(this.laftelBtn);
            this.Controls.Add(this.youtubeBtn);
            this.Controls.Add(this.watchaBtn);
            this.Controls.Add(this.primeBtn);
            this.Controls.Add(this.netflixBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.nSlider1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "JHPlayer";
            this.TopMost = true;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private NSlider nSlider1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button netflixBtn;
        private System.Windows.Forms.Button primeBtn;
        private System.Windows.Forms.Button watchaBtn;
        private System.Windows.Forms.Button youtubeBtn;
        private System.Windows.Forms.Button laftelBtn;
    }
}

