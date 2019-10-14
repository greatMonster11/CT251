namespace TinhDiem
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNN = new System.Windows.Forms.TextBox();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXL = new System.Windows.Forms.TextBox();
            this.chkFeMale = new System.Windows.Forms.RadioButton();
            this.chkMale = new System.Windows.Forms.RadioButton();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDKQ = new System.Windows.Forms.TextBox();
            this.txtDTN = new System.Windows.Forms.TextBox();
            this.btnClr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(131, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(228, 110);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(31, 20);
            this.label.TabIndex = 5;
            this.label.Text = "AV";
            this.label.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Van";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Toan";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNN
            // 
            this.txtNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNN.Location = new System.Drawing.Point(219, 133);
            this.txtNN.Name = "txtNN";
            this.txtNN.Size = new System.Drawing.Size(59, 23);
            this.txtNN.TabIndex = 8;
            // 
            // txtNV
            // 
            this.txtNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNV.Location = new System.Drawing.Point(140, 133);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(59, 23);
            this.txtNV.TabIndex = 9;
            // 
            // txtToan
            // 
            this.txtToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToan.Location = new System.Drawing.Point(54, 133);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(59, 23);
            this.txtToan.TabIndex = 10;
            this.txtToan.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Xep loai";
            // 
            // txtXL
            // 
            this.txtXL.Enabled = false;
            this.txtXL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXL.Location = new System.Drawing.Point(309, 195);
            this.txtXL.Multiline = true;
            this.txtXL.Name = "txtXL";
            this.txtXL.Size = new System.Drawing.Size(90, 42);
            this.txtXL.TabIndex = 12;
            this.txtXL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkFeMale
            // 
            this.chkFeMale.AutoSize = true;
            this.chkFeMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFeMale.Location = new System.Drawing.Point(127, 77);
            this.chkFeMale.Name = "chkFeMale";
            this.chkFeMale.Size = new System.Drawing.Size(37, 24);
            this.chkFeMale.TabIndex = 13;
            this.chkFeMale.TabStop = true;
            this.chkFeMale.Text = "F";
            this.chkFeMale.UseVisualStyleBackColor = true;
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMale.Location = new System.Drawing.Point(185, 77);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(40, 24);
            this.chkMale.TabIndex = 14;
            this.chkMale.TabStop = true;
            this.chkMale.Text = "M";
            this.chkMale.UseVisualStyleBackColor = true;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(309, 28);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(90, 35);
            this.btnTinh.TabIndex = 15;
            this.btnTinh.Text = "Tinh";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(309, 125);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 35);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "=====>>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(192, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ket Qua";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Thap Nhat";
            // 
            // txtDKQ
            // 
            this.txtDKQ.Enabled = false;
            this.txtDKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDKQ.Location = new System.Drawing.Point(196, 195);
            this.txtDKQ.Name = "txtDKQ";
            this.txtDKQ.Size = new System.Drawing.Size(59, 23);
            this.txtDKQ.TabIndex = 20;
            // 
            // txtDTN
            // 
            this.txtDTN.Enabled = false;
            this.txtDTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDTN.Location = new System.Drawing.Point(94, 195);
            this.txtDTN.Name = "txtDTN";
            this.txtDTN.Size = new System.Drawing.Size(59, 23);
            this.txtDTN.TabIndex = 21;
            // 
            // btnClr
            // 
            this.btnClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.Location = new System.Drawing.Point(309, 77);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(90, 35);
            this.btnClr.TabIndex = 22;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 240);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.txtDTN);
            this.Controls.Add(this.txtDKQ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.chkMale);
            this.Controls.Add(this.chkFeMale);
            this.Controls.Add(this.txtXL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToan);
            this.Controls.Add(this.txtNV);
            this.Controls.Add(this.txtNN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tinh Diem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNN;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXL;
        private System.Windows.Forms.RadioButton chkFeMale;
        private System.Windows.Forms.RadioButton chkMale;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDKQ;
        private System.Windows.Forms.TextBox txtDTN;
        private System.Windows.Forms.Button btnClr;
    }
}

