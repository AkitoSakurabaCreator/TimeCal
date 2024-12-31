namespace TimeCal
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Month = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Now = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.最前面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.透明度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.Font = new System.Drawing.Font("メイリオ", 14F);
            this.Month.ForeColor = System.Drawing.Color.Orange;
            this.Month.Location = new System.Drawing.Point(12, 9);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(24, 28);
            this.Month.TabIndex = 1;
            this.Month.Text = "0";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("メイリオ", 14F);
            this.Result.ForeColor = System.Drawing.Color.Orange;
            this.Result.Location = new System.Drawing.Point(12, 37);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(24, 28);
            this.Result.TabIndex = 3;
            this.Result.Text = "0";
            // 
            // Now
            // 
            this.Now.AutoSize = true;
            this.Now.Font = new System.Drawing.Font("メイリオ", 14F);
            this.Now.ForeColor = System.Drawing.Color.Orange;
            this.Now.Location = new System.Drawing.Point(12, 65);
            this.Now.Name = "Now";
            this.Now.Size = new System.Drawing.Size(24, 28);
            this.Now.TabIndex = 5;
            this.Now.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 900000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.最前面ToolStripMenuItem,
            this.透明度ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 48);
            // 
            // 最前面ToolStripMenuItem
            // 
            this.最前面ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNToolStripMenuItem,
            this.oFFToolStripMenuItem});
            this.最前面ToolStripMenuItem.Name = "最前面ToolStripMenuItem";
            this.最前面ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.最前面ToolStripMenuItem.Text = "最前面";
            // 
            // oNToolStripMenuItem
            // 
            this.oNToolStripMenuItem.Name = "oNToolStripMenuItem";
            this.oNToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.oNToolStripMenuItem.Text = "ON";
            this.oNToolStripMenuItem.Click += new System.EventHandler(this.oNToolStripMenuItem_Click);
            // 
            // oFFToolStripMenuItem
            // 
            this.oFFToolStripMenuItem.Name = "oFFToolStripMenuItem";
            this.oFFToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.oFFToolStripMenuItem.Text = "OFF";
            this.oFFToolStripMenuItem.Click += new System.EventHandler(this.oFFToolStripMenuItem_Click);
            // 
            // 透明度ToolStripMenuItem
            // 
            this.透明度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripComboBox1});
            this.透明度ToolStripMenuItem.Name = "透明度ToolStripMenuItem";
            this.透明度ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.透明度ToolStripMenuItem.Text = "透明度";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "100",
            "90",
            "80",
            "70",
            "60",
            "50",
            "40",
            "30",
            "20",
            "10"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Text = "90";
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(386, 97);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.Now);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Month);
            this.Font = new System.Drawing.Font("メイリオ", 9F);
            this.Location = new System.Drawing.Point(1500, 10);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Month;
        internal System.Windows.Forms.Label Result;
        internal System.Windows.Forms.Label Now;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 最前面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 透明度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

