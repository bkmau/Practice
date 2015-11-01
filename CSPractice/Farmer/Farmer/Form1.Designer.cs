namespace Farmer
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
            this.lbRight = new System.Windows.Forms.ListBox();
            this.lbLeft = new System.Windows.Forms.ListBox();
            this.btnRtoL = new System.Windows.Forms.Button();
            this.btnLtoR = new System.Windows.Forms.Button();
            this.btnHow = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRight
            // 
            this.lbRight.FormattingEnabled = true;
            this.lbRight.ItemHeight = 23;
            this.lbRight.Location = new System.Drawing.Point(291, 64);
            this.lbRight.Name = "lbRight";
            this.lbRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbRight.Size = new System.Drawing.Size(120, 142);
            this.lbRight.TabIndex = 11;
            // 
            // lbLeft
            // 
            this.lbLeft.FormattingEnabled = true;
            this.lbLeft.ItemHeight = 23;
            this.lbLeft.Location = new System.Drawing.Point(21, 64);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbLeft.Size = new System.Drawing.Size(120, 142);
            this.lbLeft.TabIndex = 10;
            // 
            // btnRtoL
            // 
            this.btnRtoL.Location = new System.Drawing.Point(169, 140);
            this.btnRtoL.Name = "btnRtoL";
            this.btnRtoL.Size = new System.Drawing.Size(95, 40);
            this.btnRtoL.TabIndex = 9;
            this.btnRtoL.Text = "<------";
            this.btnRtoL.UseVisualStyleBackColor = true;
            this.btnRtoL.Click += new System.EventHandler(this.btnRtoL_Click);
            // 
            // btnLtoR
            // 
            this.btnLtoR.Location = new System.Drawing.Point(169, 84);
            this.btnLtoR.Name = "btnLtoR";
            this.btnLtoR.Size = new System.Drawing.Size(95, 40);
            this.btnLtoR.TabIndex = 8;
            this.btnLtoR.Text = "------>";
            this.btnLtoR.UseVisualStyleBackColor = true;
            this.btnLtoR.Click += new System.EventHandler(this.btnLtoR_Click);
            // 
            // btnHow
            // 
            this.btnHow.Location = new System.Drawing.Point(231, 17);
            this.btnHow.Name = "btnHow";
            this.btnHow.Size = new System.Drawing.Size(98, 33);
            this.btnHow.TabIndex = 7;
            this.btnHow.Text = "說明";
            this.btnHow.UseVisualStyleBackColor = true;
            this.btnHow.Click += new System.EventHandler(this.btnHow_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(78, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(101, 23);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "農夫Carry";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 240);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.lbLeft);
            this.Controls.Add(this.btnRtoL);
            this.Controls.Add(this.btnLtoR);
            this.Controls.Add(this.btnHow);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRight;
        private System.Windows.Forms.ListBox lbLeft;
        private System.Windows.Forms.Button btnRtoL;
        private System.Windows.Forms.Button btnLtoR;
        private System.Windows.Forms.Button btnHow;
        private System.Windows.Forms.Label lbl1;
    }
}

