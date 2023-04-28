
namespace Lottery
{
    partial class ResultPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultPage));
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl中獎明細 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl中獎總額 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl消費總額 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(50, 49);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(134, 36);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "消費總額:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Maroon;
            this.lbl3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl3.ForeColor = System.Drawing.Color.SeaShell;
            this.lbl3.Location = new System.Drawing.Point(50, 119);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(134, 36);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "中獎明細:";
            // 
            // lbl中獎明細
            // 
            this.lbl中獎明細.BackColor = System.Drawing.Color.Transparent;
            this.lbl中獎明細.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl中獎明細.ForeColor = System.Drawing.Color.SeaShell;
            this.lbl中獎明細.Location = new System.Drawing.Point(50, 188);
            this.lbl中獎明細.Name = "lbl中獎明細";
            this.lbl中獎明細.Size = new System.Drawing.Size(865, 353);
            this.lbl中獎明細.TabIndex = 2;
            this.lbl中獎明細.Text = "銘謝惠顧，無中獎記錄。";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(368, 49);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(134, 36);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "中獎總額:";
            // 
            // lbl中獎總額
            // 
            this.lbl中獎總額.AutoSize = true;
            this.lbl中獎總額.BackColor = System.Drawing.Color.Transparent;
            this.lbl中獎總額.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl中獎總額.ForeColor = System.Drawing.Color.White;
            this.lbl中獎總額.Location = new System.Drawing.Point(507, 49);
            this.lbl中獎總額.Name = "lbl中獎總額";
            this.lbl中獎總額.Size = new System.Drawing.Size(60, 36);
            this.lbl中獎總額.TabIndex = 5;
            this.lbl中獎總額.Text = "0元";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Lottery.Properties.Resources.eto_usagi_daruma;
            this.pictureBox1.Location = new System.Drawing.Point(842, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbl消費總額
            // 
            this.lbl消費總額.AutoSize = true;
            this.lbl消費總額.BackColor = System.Drawing.Color.Transparent;
            this.lbl消費總額.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl消費總額.ForeColor = System.Drawing.Color.White;
            this.lbl消費總額.Location = new System.Drawing.Point(186, 49);
            this.lbl消費總額.Name = "lbl消費總額";
            this.lbl消費總額.Size = new System.Drawing.Size(60, 36);
            this.lbl消費總額.TabIndex = 7;
            this.lbl消費總額.Text = "0元";
            // 
            // ResultPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::Lottery.Properties.Resources.ResultPage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1166, 802);
            this.Controls.Add(this.lbl消費總額);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl中獎總額);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl中獎明細);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultPage";
            this.Text = "結果公佈";
            this.Load += new System.EventHandler(this.ResultPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbl中獎明細;
        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Label lbl中獎總額;
        public System.Windows.Forms.Label lbl消費總額;
    }
}