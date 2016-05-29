namespace Poker
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pbB = new System.Windows.Forms.PictureBox();
            this.pbA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(327, 86);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 50);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "洗牌";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(327, 166);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(90, 50);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "結束";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(93, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(130, 23);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "撲克牌比大小";
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(30, 263);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(387, 33);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "label2";
            // 
            // pbB
            // 
            this.pbB.Location = new System.Drawing.Point(175, 65);
            this.pbB.Name = "pbB";
            this.pbB.Size = new System.Drawing.Size(120, 175);
            this.pbB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbB.TabIndex = 1;
            this.pbB.TabStop = false;
            this.pbB.Click += new System.EventHandler(this.pbB_Click);
            // 
            // pbA
            // 
            this.pbA.Location = new System.Drawing.Point(34, 65);
            this.pbA.Name = "pbA";
            this.pbA.Size = new System.Drawing.Size(120, 175);
            this.pbA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbA.TabIndex = 0;
            this.pbA.TabStop = false;
            this.pbA.Click += new System.EventHandler(this.pbA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 304);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pbB);
            this.Controls.Add(this.pbA);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbA;
        private System.Windows.Forms.PictureBox pbB;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}

