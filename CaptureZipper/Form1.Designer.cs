namespace CaptureZipper
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BaseNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rightBottomXComboBox = new System.Windows.Forms.ComboBox();
            this.leftTopXComboBox = new System.Windows.Forms.ComboBox();
            this.rightBottomYNumericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.leftTopYNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightBottomYNumericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftTopYNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(562, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "C:\\User\\Book\\Capture001.zip";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BaseNameTextBox
            // 
            this.BaseNameTextBox.Location = new System.Drawing.Point(66, 77);
            this.BaseNameTextBox.Name = "BaseNameTextBox";
            this.BaseNameTextBox.Size = new System.Drawing.Size(167, 25);
            this.BaseNameTextBox.TabIndex = 2;
            this.BaseNameTextBox.Text = "Capture_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "タイマー";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(86, 138);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(133, 25);
            this.numericUpDown5.TabIndex = 5;
            this.numericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown5.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rightBottomXComboBox);
            this.groupBox1.Controls.Add(this.leftTopXComboBox);
            this.groupBox1.Controls.Add(this.rightBottomYNumericUpDown4);
            this.groupBox1.Controls.Add(this.leftTopYNumericUpDown2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(274, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 138);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "キャプチャ範囲";
            // 
            // rightBottomXComboBox
            // 
            this.rightBottomXComboBox.FormattingEnabled = true;
            this.rightBottomXComboBox.Items.AddRange(new object[] {
            "1920",
            "1782",
            "1738"});
            this.rightBottomXComboBox.Location = new System.Drawing.Point(61, 83);
            this.rightBottomXComboBox.Name = "rightBottomXComboBox";
            this.rightBottomXComboBox.Size = new System.Drawing.Size(134, 26);
            this.rightBottomXComboBox.TabIndex = 14;
            // 
            // leftTopXComboBox
            // 
            this.leftTopXComboBox.FormattingEnabled = true;
            this.leftTopXComboBox.Items.AddRange(new object[] {
            "0",
            "138",
            "182"});
            this.leftTopXComboBox.Location = new System.Drawing.Point(61, 28);
            this.leftTopXComboBox.Name = "leftTopXComboBox";
            this.leftTopXComboBox.Size = new System.Drawing.Size(134, 26);
            this.leftTopXComboBox.TabIndex = 13;
            // 
            // rightBottomYNumericUpDown4
            // 
            this.rightBottomYNumericUpDown4.Location = new System.Drawing.Point(201, 84);
            this.rightBottomYNumericUpDown4.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.rightBottomYNumericUpDown4.Name = "rightBottomYNumericUpDown4";
            this.rightBottomYNumericUpDown4.Size = new System.Drawing.Size(133, 25);
            this.rightBottomYNumericUpDown4.TabIndex = 11;
            this.rightBottomYNumericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rightBottomYNumericUpDown4.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // leftTopYNumericUpDown2
            // 
            this.leftTopYNumericUpDown2.Location = new System.Drawing.Point(201, 29);
            this.leftTopYNumericUpDown2.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.leftTopYNumericUpDown2.Name = "leftTopYNumericUpDown2";
            this.leftTopYNumericUpDown2.Size = new System.Drawing.Size(133, 25);
            this.leftTopYNumericUpDown2.TabIndex = 10;
            this.leftTopYNumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "右下";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "左上";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(88, 195);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(133, 25);
            this.numericUpDown6.TabIndex = 11;
            this.numericUpDown6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown6.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "回数";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 34);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 327);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BaseNameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "CaptureZipper";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightBottomYNumericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftTopYNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BaseNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown rightBottomYNumericUpDown4;
        private System.Windows.Forms.NumericUpDown leftTopYNumericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox rightBottomXComboBox;
        private System.Windows.Forms.ComboBox leftTopXComboBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    }
}

