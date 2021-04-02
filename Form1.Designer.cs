namespace LastOne
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.player1Name = new System.Windows.Forms.Label();
            this.player1Image = new System.Windows.Forms.PictureBox();
            this.player1Button = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.player2Name = new System.Windows.Forms.Label();
            this.player2Image = new System.Windows.Forms.PictureBox();
            this.player2Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1Image)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2Image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Waiting Start...";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.player1Name);
            this.panel2.Controls.Add(this.player1Image);
            this.panel2.Controls.Add(this.player1Button);
            this.panel2.Location = new System.Drawing.Point(521, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 195);
            this.panel2.TabIndex = 1;
            // 
            // player1Name
            // 
            this.player1Name.AutoSize = true;
            this.player1Name.Location = new System.Drawing.Point(39, 142);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(47, 12);
            this.player1Name.TabIndex = 7;
            this.player1Name.Text = "Player1";
            this.player1Name.Click += new System.EventHandler(this.Player_Submit);
            // 
            // player1Image
            // 
            this.player1Image.Image = global::LastOne.Properties.Resources.portrait1;
            this.player1Image.Location = new System.Drawing.Point(10, 14);
            this.player1Image.Name = "player1Image";
            this.player1Image.Size = new System.Drawing.Size(103, 120);
            this.player1Image.TabIndex = 5;
            this.player1Image.TabStop = false;
            // 
            // player1Button
            // 
            this.player1Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.player1Button.Location = new System.Drawing.Point(11, 160);
            this.player1Button.Name = "player1Button";
            this.player1Button.Size = new System.Drawing.Size(103, 25);
            this.player1Button.TabIndex = 4;
            this.player1Button.Text = "Done";
            this.player1Button.UseVisualStyleBackColor = true;
            this.player1Button.Visible = false;
            this.player1Button.Click += new System.EventHandler(this.Player_Submit);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.player2Name);
            this.panel3.Controls.Add(this.player2Image);
            this.panel3.Controls.Add(this.player2Button);
            this.panel3.Location = new System.Drawing.Point(521, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 199);
            this.panel3.TabIndex = 2;
            // 
            // player2Name
            // 
            this.player2Name.AutoSize = true;
            this.player2Name.Location = new System.Drawing.Point(39, 142);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(47, 12);
            this.player2Name.TabIndex = 8;
            this.player2Name.Text = "Player2";
            this.player2Name.Click += new System.EventHandler(this.Player_Submit);
            // 
            // player2Image
            // 
            this.player2Image.Image = global::LastOne.Properties.Resources.portrait1;
            this.player2Image.Location = new System.Drawing.Point(10, 15);
            this.player2Image.Name = "player2Image";
            this.player2Image.Size = new System.Drawing.Size(103, 120);
            this.player2Image.TabIndex = 5;
            this.player2Image.TabStop = false;
            // 
            // player2Button
            // 
            this.player2Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.player2Button.Location = new System.Drawing.Point(11, 164);
            this.player2Button.Name = "player2Button";
            this.player2Button.Size = new System.Drawing.Size(103, 25);
            this.player2Button.TabIndex = 4;
            this.player2Button.Text = "Done";
            this.player2Button.UseVisualStyleBackColor = true;
            this.player2Button.Visible = false;
            this.player2Button.Click += new System.EventHandler(this.Player_Submit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Count for row";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "3,5,7";
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(521, 490);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Start Game";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Who First";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Player1",
            "Player2"});
            this.comboBox1.Location = new System.Drawing.Point(568, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(521, 519);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Reset Game";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(412, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 21);
            this.textBox2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Each time can take";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 554);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LastOne";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1Image)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button player1Button;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox player1Image;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox player2Image;
        private System.Windows.Forms.Button player2Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}

