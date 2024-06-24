namespace CSharp_DoiColor
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhapten = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radxanhla = new System.Windows.Forms.RadioButton();
            this.radxanhbien = new System.Windows.Forms.RadioButton();
            this.radden = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkblold = new System.Windows.Forms.CheckBox();
            this.chkitalic = new System.Windows.Forms.CheckBox();
            this.chkchan = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLapTrinh = new System.Windows.Forms.Label();
            this.radred = new System.Windows.Forms.RadioButton();
            this.txtLapTrinh = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(145, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên:";
            // 
            // txtnhapten
            // 
            this.txtnhapten.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhapten.Location = new System.Drawing.Point(270, 52);
            this.txtnhapten.Name = "txtnhapten";
            this.txtnhapten.Size = new System.Drawing.Size(100, 33);
            this.txtnhapten.TabIndex = 1;
            this.txtnhapten.TextChanged += new System.EventHandler(this.txtnhapten_TextChanged);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(390, 285);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 33);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.radden);
            this.groupBox1.Controls.Add(this.radxanhbien);
            this.groupBox1.Controls.Add(this.radxanhla);
            this.groupBox1.Controls.Add(this.radred);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(105, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 131);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Màu";
            // 
            // radxanhla
            // 
            this.radxanhla.AutoSize = true;
            this.radxanhla.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radxanhla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radxanhla.Location = new System.Drawing.Point(6, 48);
            this.radxanhla.Name = "radxanhla";
            this.radxanhla.Size = new System.Drawing.Size(66, 17);
            this.radxanhla.TabIndex = 1;
            this.radxanhla.TabStop = true;
            this.radxanhla.Text = "Xanh lá";
            this.radxanhla.UseVisualStyleBackColor = true;
            this.radxanhla.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radxanhbien
            // 
            this.radxanhbien.AutoSize = true;
            this.radxanhbien.ForeColor = System.Drawing.Color.Blue;
            this.radxanhbien.Location = new System.Drawing.Point(6, 71);
            this.radxanhbien.Name = "radxanhbien";
            this.radxanhbien.Size = new System.Drawing.Size(89, 20);
            this.radxanhbien.TabIndex = 2;
            this.radxanhbien.TabStop = true;
            this.radxanhbien.Text = "Xanh biển";
            this.radxanhbien.UseVisualStyleBackColor = true;
            this.radxanhbien.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radden
            // 
            this.radden.AutoSize = true;
            this.radden.Location = new System.Drawing.Point(6, 97);
            this.radden.Name = "radden";
            this.radden.Size = new System.Drawing.Size(51, 20);
            this.radden.TabIndex = 3;
            this.radden.TabStop = true;
            this.radden.Text = "Đen";
            this.radden.UseVisualStyleBackColor = true;
            this.radden.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.chkchan);
            this.groupBox2.Controls.Add(this.chkitalic);
            this.groupBox2.Controls.Add(this.chkblold);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(324, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 131);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chkblold
            // 
            this.chkblold.AutoSize = true;
            this.chkblold.ForeColor = System.Drawing.Color.Blue;
            this.chkblold.Location = new System.Drawing.Point(6, 23);
            this.chkblold.Name = "chkblold";
            this.chkblold.Size = new System.Drawing.Size(89, 20);
            this.chkblold.TabIndex = 0;
            this.chkblold.Text = "Đậm Blold";
            this.chkblold.UseVisualStyleBackColor = true;
            this.chkblold.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkitalic
            // 
            this.chkitalic.AutoSize = true;
            this.chkitalic.ForeColor = System.Drawing.Color.Blue;
            this.chkitalic.Location = new System.Drawing.Point(6, 49);
            this.chkitalic.Name = "chkitalic";
            this.chkitalic.Size = new System.Drawing.Size(105, 20);
            this.chkitalic.TabIndex = 1;
            this.chkitalic.Text = "Ngiêng Italic";
            this.chkitalic.UseVisualStyleBackColor = true;
            this.chkitalic.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkchan
            // 
            this.chkchan.AutoSize = true;
            this.chkchan.ForeColor = System.Drawing.Color.Blue;
            this.chkchan.Location = new System.Drawing.Point(6, 81);
            this.chkchan.Name = "chkchan";
            this.chkchan.Size = new System.Drawing.Size(93, 20);
            this.chkchan.TabIndex = 2;
            this.chkchan.Text = "Gạch Chân";
            this.chkchan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(45, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lập Trình Bởi:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLapTrinh
            // 
            this.lblLapTrinh.AutoSize = true;
            this.lblLapTrinh.BackColor = System.Drawing.Color.Gray;
            this.lblLapTrinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLapTrinh.Location = new System.Drawing.Point(220, 341);
            this.lblLapTrinh.Name = "lblLapTrinh";
            this.lblLapTrinh.Size = new System.Drawing.Size(30, 16);
            this.lblLapTrinh.TabIndex = 6;
            this.lblLapTrinh.Text = "Tên";
            this.lblLapTrinh.Click += new System.EventHandler(this.lblLapTrinh_Click);
            // 
            // radred
            // 
            this.radred.AutoSize = true;
            this.radred.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radred.ForeColor = System.Drawing.Color.Red;
            this.radred.Location = new System.Drawing.Point(6, 22);
            this.radred.Name = "radred";
            this.radred.Size = new System.Drawing.Size(43, 20);
            this.radred.TabIndex = 0;
            this.radred.TabStop = true;
            this.radred.Text = "Đỏ";
            this.radred.UseVisualStyleBackColor = true;
            this.radred.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtLapTrinh
            // 
            this.txtLapTrinh.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLapTrinh.Location = new System.Drawing.Point(223, 285);
            this.txtLapTrinh.Name = "txtLapTrinh";
            this.txtLapTrinh.Size = new System.Drawing.Size(100, 33);
            this.txtLapTrinh.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLapTrinh);
            this.Controls.Add(this.lblLapTrinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtnhapten);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhapten;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radden;
        private System.Windows.Forms.RadioButton radxanhbien;
        private System.Windows.Forms.RadioButton radxanhla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkchan;
        private System.Windows.Forms.CheckBox chkitalic;
        private System.Windows.Forms.CheckBox chkblold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radred;
        private System.Windows.Forms.Label lblLapTrinh;
        private System.Windows.Forms.TextBox txtLapTrinh;
    }
}

