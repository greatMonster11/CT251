namespace Giai_PTB2
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
            this.labelA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.btnRelv = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(68, 37);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(103, 20);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "Nhập hệ số a";
            this.labelA.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(188, 39);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 3;
            this.txtA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(188, 100);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(188, 74);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 5;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.Location = new System.Drawing.Point(68, 103);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(102, 20);
            this.labelC.TabIndex = 6;
            this.labelC.Text = "Nhập hệ số c";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(68, 72);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(103, 20);
            this.labelB.TabIndex = 7;
            this.labelB.Text = "Nhập hệ số b";
            // 
            // btnRelv
            // 
            this.btnRelv.Location = new System.Drawing.Point(72, 139);
            this.btnRelv.Name = "btnRelv";
            this.btnRelv.Size = new System.Drawing.Size(128, 24);
            this.btnRelv.TabIndex = 8;
            this.btnRelv.Text = "Giải";
            this.btnRelv.UseVisualStyleBackColor = true;
            this.btnRelv.Click += new System.EventHandler(this.btnRelv_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(212, 139);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(76, 24);
            this.btnClr.TabIndex = 9;
            this.btnClr.Text = "Xóa";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nghiệm là";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(154, 172);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(134, 29);
            this.result.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 224);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnRelv);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.labelA);
            this.Name = "Form1";
            this.Text = "Giai Phuong Trinh Bac 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Button btnRelv;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox result;
    }
}

