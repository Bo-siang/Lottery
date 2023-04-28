
namespace Lottery
{
    partial class MainPage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btn選號 = new System.Windows.Forms.Button();
            this.lbl第一區 = new System.Windows.Forms.Label();
            this.lbl第二區 = new System.Windows.Forms.Label();
            this.listBox選號紀錄 = new System.Windows.Forms.ListBox();
            this.btn刪除所選選號 = new System.Windows.Forms.Button();
            this.btn刪除全部選號 = new System.Windows.Forms.Button();
            this.btn確認對獎 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl大小順序A2 = new System.Windows.Forms.Label();
            this.lbl開出順序A2 = new System.Windows.Forms.Label();
            this.lbl大小順序A1 = new System.Windows.Forms.Label();
            this.lbl開出順序A1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn選號
            // 
            this.btn選號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn選號.ForeColor = System.Drawing.Color.DarkRed;
            this.btn選號.Location = new System.Drawing.Point(386, 438);
            this.btn選號.Name = "btn選號";
            this.btn選號.Size = new System.Drawing.Size(124, 40);
            this.btn選號.TabIndex = 2;
            this.btn選號.Text = "選號";
            this.btn選號.UseVisualStyleBackColor = true;
            this.btn選號.Click += new System.EventHandler(this.btn加入組號_Click);
            // 
            // lbl第一區
            // 
            this.lbl第一區.AutoSize = true;
            this.lbl第一區.BackColor = System.Drawing.Color.Transparent;
            this.lbl第一區.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl第一區.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl第一區.Location = new System.Drawing.Point(28, 27);
            this.lbl第一區.Name = "lbl第一區";
            this.lbl第一區.Size = new System.Drawing.Size(86, 31);
            this.lbl第一區.TabIndex = 3;
            this.lbl第一區.Text = "第一區";
            // 
            // lbl第二區
            // 
            this.lbl第二區.AutoSize = true;
            this.lbl第二區.BackColor = System.Drawing.Color.Transparent;
            this.lbl第二區.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl第二區.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl第二區.Location = new System.Drawing.Point(28, 334);
            this.lbl第二區.Name = "lbl第二區";
            this.lbl第二區.Size = new System.Drawing.Size(86, 31);
            this.lbl第二區.TabIndex = 4;
            this.lbl第二區.Text = "第二區";
            // 
            // listBox選號紀錄
            // 
            this.listBox選號紀錄.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox選號紀錄.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox選號紀錄.ForeColor = System.Drawing.Color.DarkRed;
            this.listBox選號紀錄.FormattingEnabled = true;
            this.listBox選號紀錄.ItemHeight = 31;
            this.listBox選號紀錄.Location = new System.Drawing.Point(561, 69);
            this.listBox選號紀錄.Name = "listBox選號紀錄";
            this.listBox選號紀錄.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox選號紀錄.Size = new System.Drawing.Size(498, 345);
            this.listBox選號紀錄.TabIndex = 6;
            // 
            // btn刪除所選選號
            // 
            this.btn刪除所選選號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除所選選號.ForeColor = System.Drawing.Color.DarkRed;
            this.btn刪除所選選號.Location = new System.Drawing.Point(561, 438);
            this.btn刪除所選選號.Name = "btn刪除所選選號";
            this.btn刪除所選選號.Size = new System.Drawing.Size(178, 40);
            this.btn刪除所選選號.TabIndex = 7;
            this.btn刪除所選選號.Text = "刪除所選選號";
            this.btn刪除所選選號.UseVisualStyleBackColor = true;
            this.btn刪除所選選號.Click += new System.EventHandler(this.btn刪除所選選號_Click);
            // 
            // btn刪除全部選號
            // 
            this.btn刪除全部選號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除全部選號.ForeColor = System.Drawing.Color.DarkRed;
            this.btn刪除全部選號.Location = new System.Drawing.Point(746, 438);
            this.btn刪除全部選號.Name = "btn刪除全部選號";
            this.btn刪除全部選號.Size = new System.Drawing.Size(177, 40);
            this.btn刪除全部選號.TabIndex = 8;
            this.btn刪除全部選號.Text = "刪除全部選號";
            this.btn刪除全部選號.UseVisualStyleBackColor = true;
            this.btn刪除全部選號.Click += new System.EventHandler(this.btn刪除全部選號_Click);
            // 
            // btn確認對獎
            // 
            this.btn確認對獎.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn確認對獎.ForeColor = System.Drawing.Color.DarkRed;
            this.btn確認對獎.Location = new System.Drawing.Point(934, 438);
            this.btn確認對獎.Name = "btn確認對獎";
            this.btn確認對獎.Size = new System.Drawing.Size(124, 40);
            this.btn確認對獎.TabIndex = 9;
            this.btn確認對獎.Text = "確認對獎";
            this.btn確認對獎.UseVisualStyleBackColor = true;
            this.btn確認對獎.Click += new System.EventHandler(this.btn確認對獎_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl大小順序A2);
            this.groupBox1.Controls.Add(this.lbl開出順序A2);
            this.groupBox1.Controls.Add(this.lbl大小順序A1);
            this.groupBox1.Controls.Add(this.lbl開出順序A1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(308, 547);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 220);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lbl大小順序A2
            // 
            this.lbl大小順序A2.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbl大小順序A2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl大小順序A2.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl大小順序A2.Location = new System.Drawing.Point(554, 141);
            this.lbl大小順序A2.Name = "lbl大小順序A2";
            this.lbl大小順序A2.Size = new System.Drawing.Size(92, 44);
            this.lbl大小順序A2.TabIndex = 16;
            // 
            // lbl開出順序A2
            // 
            this.lbl開出順序A2.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbl開出順序A2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl開出順序A2.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl開出順序A2.Location = new System.Drawing.Point(554, 64);
            this.lbl開出順序A2.Name = "lbl開出順序A2";
            this.lbl開出順序A2.Size = new System.Drawing.Size(92, 44);
            this.lbl開出順序A2.TabIndex = 15;
            // 
            // lbl大小順序A1
            // 
            this.lbl大小順序A1.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbl大小順序A1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl大小順序A1.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl大小順序A1.Location = new System.Drawing.Point(164, 141);
            this.lbl大小順序A1.Name = "lbl大小順序A1";
            this.lbl大小順序A1.Size = new System.Drawing.Size(358, 44);
            this.lbl大小順序A1.TabIndex = 14;
            this.lbl大小順序A1.Text = "未開獎";
            // 
            // lbl開出順序A1
            // 
            this.lbl開出順序A1.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbl開出順序A1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl開出順序A1.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl開出順序A1.Location = new System.Drawing.Point(164, 64);
            this.lbl開出順序A1.Name = "lbl開出順序A1";
            this.lbl開出順序A1.Size = new System.Drawing.Size(358, 44);
            this.lbl開出順序A1.TabIndex = 13;
            this.lbl開出順序A1.Text = "未開獎";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(554, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "第二區";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(164, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "第一區";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "大小順序";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "開出順序";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Lottery.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1065, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::Lottery.Properties.Resources.MainPage1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1166, 802);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn確認對獎);
            this.Controls.Add(this.btn刪除全部選號);
            this.Controls.Add(this.btn刪除所選選號);
            this.Controls.Add(this.listBox選號紀錄);
            this.Controls.Add(this.lbl第二區);
            this.Controls.Add(this.lbl第一區);
            this.Controls.Add(this.btn選號);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "威力彩";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn選號;
        private System.Windows.Forms.Label lbl第一區;
        private System.Windows.Forms.Label lbl第二區;
        private System.Windows.Forms.ListBox listBox選號紀錄;
        private System.Windows.Forms.Button btn刪除所選選號;
        private System.Windows.Forms.Button btn刪除全部選號;
        private System.Windows.Forms.Button btn確認對獎;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl開出順序A1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl大小順序A2;
        private System.Windows.Forms.Label lbl開出順序A2;
        private System.Windows.Forms.Label lbl大小順序A1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

