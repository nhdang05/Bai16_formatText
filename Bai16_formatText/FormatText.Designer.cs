namespace Bai16_formatText
{
    partial class FormatText
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
            this.txtNhapten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.raRed = new System.Windows.Forms.RadioButton();
            this.raGreen = new System.Windows.Forms.RadioButton();
            this.raBlue = new System.Windows.Forms.RadioButton();
            this.raBlack = new System.Windows.Forms.RadioButton();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.chkGachchan = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbllaptrinh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNhapten
            // 
            this.txtNhapten.Location = new System.Drawing.Point(137, 23);
            this.txtNhapten.Name = "txtNhapten";
            this.txtNhapten.Size = new System.Drawing.Size(205, 20);
            this.txtNhapten.TabIndex = 1;
            this.txtNhapten.Text = "HaiDang";
            this.txtNhapten.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập tên";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.raBlack);
            this.groupBox1.Controls.Add(this.raBlue);
            this.groupBox1.Controls.Add(this.raGreen);
            this.groupBox1.Controls.Add(this.raRed);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(30, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 207);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "color";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox2.Controls.Add(this.chkGachchan);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.chkItalic);
            this.groupBox2.Controls.Add(this.chkBold);
            this.groupBox2.Location = new System.Drawing.Point(219, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 206);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // raRed
            // 
            this.raRed.AutoSize = true;
            this.raRed.ForeColor = System.Drawing.Color.Red;
            this.raRed.Location = new System.Drawing.Point(21, 45);
            this.raRed.Name = "raRed";
            this.raRed.Size = new System.Drawing.Size(45, 17);
            this.raRed.TabIndex = 0;
            this.raRed.TabStop = true;
            this.raRed.Text = "Red";
            this.raRed.UseVisualStyleBackColor = true;
            this.raRed.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // raGreen
            // 
            this.raGreen.AutoSize = true;
            this.raGreen.ForeColor = System.Drawing.Color.Lime;
            this.raGreen.Location = new System.Drawing.Point(21, 87);
            this.raGreen.Name = "raGreen";
            this.raGreen.Size = new System.Drawing.Size(54, 17);
            this.raGreen.TabIndex = 0;
            this.raGreen.TabStop = true;
            this.raGreen.Text = "Green";
            this.raGreen.UseVisualStyleBackColor = true;
            this.raGreen.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // raBlue
            // 
            this.raBlue.AutoSize = true;
            this.raBlue.ForeColor = System.Drawing.Color.Blue;
            this.raBlue.Location = new System.Drawing.Point(21, 129);
            this.raBlue.Name = "raBlue";
            this.raBlue.Size = new System.Drawing.Size(46, 17);
            this.raBlue.TabIndex = 0;
            this.raBlue.TabStop = true;
            this.raBlue.Text = "Blue";
            this.raBlue.UseVisualStyleBackColor = true;
            this.raBlue.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // raBlack
            // 
            this.raBlack.AutoSize = true;
            this.raBlack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.raBlack.Location = new System.Drawing.Point(21, 167);
            this.raBlack.Name = "raBlack";
            this.raBlack.Size = new System.Drawing.Size(52, 17);
            this.raBlack.TabIndex = 0;
            this.raBlack.TabStop = true;
            this.raBlack.Text = "Black";
            this.raBlack.UseVisualStyleBackColor = true;
            this.raBlack.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(31, 58);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(72, 17);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "Đậm Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.Location = new System.Drawing.Point(31, 98);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(91, 17);
            this.chkItalic.TabIndex = 0;
            this.chkItalic.Text = "Nghiêng Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(31, 146);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "checkBox1";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // chkGachchan
            // 
            this.chkGachchan.AutoSize = true;
            this.chkGachchan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGachchan.Location = new System.Drawing.Point(31, 146);
            this.chkGachchan.Name = "chkGachchan";
            this.chkGachchan.Size = new System.Drawing.Size(80, 17);
            this.chkGachchan.TabIndex = 0;
            this.chkGachchan.Text = "Gạch Chân";
            this.chkGachchan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(62, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lập Trình Bởi:";
            // 
            // lbllaptrinh
            // 
            this.lbllaptrinh.Location = new System.Drawing.Point(141, 343);
            this.lbllaptrinh.Name = "lbllaptrinh";
            this.lbllaptrinh.Size = new System.Drawing.Size(156, 20);
            this.lbllaptrinh.TabIndex = 8;
            this.lbllaptrinh.Text = "adbcghhh";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormatText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(444, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbllaptrinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhapten);
            this.Name = "FormatText";
            this.Text = "FormatText";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNhapten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton raRed;
        private System.Windows.Forms.RadioButton raBlack;
        private System.Windows.Forms.RadioButton raBlue;
        private System.Windows.Forms.RadioButton raGreen;
        private System.Windows.Forms.CheckBox chkGachchan;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lbllaptrinh;
        private System.Windows.Forms.Button button1;
    }
}