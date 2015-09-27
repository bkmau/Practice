namespace Tax
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(15, 40);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(139, 23);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "請輸入總收入:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(18, 91);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(136, 23);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "稅           率:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(18, 134);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(136, 23);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "稅           金:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(160, 91);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(68, 23);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "label4";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(160, 134);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(68, 23);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "label5";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(336, 40);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(50, 23);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "萬元";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(160, 37);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(170, 31);
            this.txt1.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(68, 182);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 41);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(187, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 41);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "結束";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 245);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
    }
}

