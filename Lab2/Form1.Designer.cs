namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.matrix1 = new System.Windows.Forms.TextBox();
            this.matrix2 = new System.Windows.Forms.TextBox();
            this.matrix3 = new System.Windows.Forms.TextBox();
            this.matrix4 = new System.Windows.Forms.TextBox();
            this.matrix8 = new System.Windows.Forms.TextBox();
            this.matrix7 = new System.Windows.Forms.TextBox();
            this.matrix6 = new System.Windows.Forms.TextBox();
            this.matrix5 = new System.Windows.Forms.TextBox();
            this.matrix16 = new System.Windows.Forms.TextBox();
            this.matrix15 = new System.Windows.Forms.TextBox();
            this.matrix14 = new System.Windows.Forms.TextBox();
            this.matrix13 = new System.Windows.Forms.TextBox();
            this.matrix12 = new System.Windows.Forms.TextBox();
            this.matrix11 = new System.Windows.Forms.TextBox();
            this.matrix10 = new System.Windows.Forms.TextBox();
            this.matrix9 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 24);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 79);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 24);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(242, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Density";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Draw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(48, 354);
            this.trackBar1.Maximum = 360;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(48, 209);
            this.trackBar2.Maximum = 360;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 10;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 26);
            this.button4.TabIndex = 11;
            this.button4.Text = "Load ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(82, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 26);
            this.button5.TabIndex = 12;
            this.button5.Text = "Save ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Y";
            // 
            // matrix1
            // 
            this.matrix1.Location = new System.Drawing.Point(46, 260);
            this.matrix1.Name = "matrix1";
            this.matrix1.Size = new System.Drawing.Size(36, 24);
            this.matrix1.TabIndex = 15;
            // 
            // matrix2
            // 
            this.matrix2.Location = new System.Drawing.Point(81, 260);
            this.matrix2.Name = "matrix2";
            this.matrix2.Size = new System.Drawing.Size(36, 24);
            this.matrix2.TabIndex = 16;
            // 
            // matrix3
            // 
            this.matrix3.Location = new System.Drawing.Point(116, 260);
            this.matrix3.Name = "matrix3";
            this.matrix3.Size = new System.Drawing.Size(36, 24);
            this.matrix3.TabIndex = 17;
            // 
            // matrix4
            // 
            this.matrix4.Location = new System.Drawing.Point(151, 260);
            this.matrix4.Name = "matrix4";
            this.matrix4.Size = new System.Drawing.Size(36, 24);
            this.matrix4.TabIndex = 18;
            // 
            // matrix8
            // 
            this.matrix8.Location = new System.Drawing.Point(151, 281);
            this.matrix8.Name = "matrix8";
            this.matrix8.Size = new System.Drawing.Size(36, 24);
            this.matrix8.TabIndex = 22;
            // 
            // matrix7
            // 
            this.matrix7.Location = new System.Drawing.Point(116, 281);
            this.matrix7.Name = "matrix7";
            this.matrix7.Size = new System.Drawing.Size(36, 24);
            this.matrix7.TabIndex = 21;
            // 
            // matrix6
            // 
            this.matrix6.Location = new System.Drawing.Point(81, 281);
            this.matrix6.Name = "matrix6";
            this.matrix6.Size = new System.Drawing.Size(36, 24);
            this.matrix6.TabIndex = 20;
            // 
            // matrix5
            // 
            this.matrix5.Location = new System.Drawing.Point(46, 281);
            this.matrix5.Name = "matrix5";
            this.matrix5.Size = new System.Drawing.Size(36, 24);
            this.matrix5.TabIndex = 19;
            // 
            // matrix16
            // 
            this.matrix16.Location = new System.Drawing.Point(151, 324);
            this.matrix16.Name = "matrix16";
            this.matrix16.Size = new System.Drawing.Size(36, 24);
            this.matrix16.TabIndex = 30;
            // 
            // matrix15
            // 
            this.matrix15.Location = new System.Drawing.Point(116, 324);
            this.matrix15.Name = "matrix15";
            this.matrix15.Size = new System.Drawing.Size(36, 24);
            this.matrix15.TabIndex = 29;
            // 
            // matrix14
            // 
            this.matrix14.Location = new System.Drawing.Point(81, 324);
            this.matrix14.Name = "matrix14";
            this.matrix14.Size = new System.Drawing.Size(36, 24);
            this.matrix14.TabIndex = 28;
            // 
            // matrix13
            // 
            this.matrix13.Location = new System.Drawing.Point(46, 324);
            this.matrix13.Name = "matrix13";
            this.matrix13.Size = new System.Drawing.Size(36, 24);
            this.matrix13.TabIndex = 27;
            // 
            // matrix12
            // 
            this.matrix12.Location = new System.Drawing.Point(151, 303);
            this.matrix12.Name = "matrix12";
            this.matrix12.Size = new System.Drawing.Size(36, 24);
            this.matrix12.TabIndex = 26;
            // 
            // matrix11
            // 
            this.matrix11.Location = new System.Drawing.Point(116, 303);
            this.matrix11.Name = "matrix11";
            this.matrix11.Size = new System.Drawing.Size(36, 24);
            this.matrix11.TabIndex = 25;
            // 
            // matrix10
            // 
            this.matrix10.Location = new System.Drawing.Point(81, 303);
            this.matrix10.Name = "matrix10";
            this.matrix10.Size = new System.Drawing.Size(36, 24);
            this.matrix10.TabIndex = 24;
            // 
            // matrix9
            // 
            this.matrix9.Location = new System.Drawing.Point(46, 303);
            this.matrix9.Name = "matrix9";
            this.matrix9.Size = new System.Drawing.Size(36, 24);
            this.matrix9.TabIndex = 23;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(910, 628);
            this.Controls.Add(this.matrix16);
            this.Controls.Add(this.matrix15);
            this.Controls.Add(this.matrix14);
            this.Controls.Add(this.matrix13);
            this.Controls.Add(this.matrix12);
            this.Controls.Add(this.matrix11);
            this.Controls.Add(this.matrix10);
            this.Controls.Add(this.matrix9);
            this.Controls.Add(this.matrix8);
            this.Controls.Add(this.matrix7);
            this.Controls.Add(this.matrix6);
            this.Controls.Add(this.matrix5);
            this.Controls.Add(this.matrix4);
            this.Controls.Add(this.matrix3);
            this.Controls.Add(this.matrix2);
            this.Controls.Add(this.matrix1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Projection&Rotation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox matrix1;
        private System.Windows.Forms.TextBox matrix2;
        private System.Windows.Forms.TextBox matrix3;
        private System.Windows.Forms.TextBox matrix4;
        private System.Windows.Forms.TextBox matrix8;
        private System.Windows.Forms.TextBox matrix7;
        private System.Windows.Forms.TextBox matrix6;
        private System.Windows.Forms.TextBox matrix5;
        private System.Windows.Forms.TextBox matrix16;
        private System.Windows.Forms.TextBox matrix15;
        private System.Windows.Forms.TextBox matrix14;
        private System.Windows.Forms.TextBox matrix13;
        private System.Windows.Forms.TextBox matrix12;
        private System.Windows.Forms.TextBox matrix11;
        private System.Windows.Forms.TextBox matrix10;
        private System.Windows.Forms.TextBox matrix9;
    }
}

