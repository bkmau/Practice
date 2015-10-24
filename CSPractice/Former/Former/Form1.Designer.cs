namespace Former
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
            this.btnHow = new System.Windows.Forms.Button();
            this.btnLtoR = new System.Windows.Forms.Button();
            this.btnRtoL = new System.Windows.Forms.Button();
            this.lbLeft = new System.Windows.Forms.ListBox();
            this.lbRight = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(69, 27);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(101, 23);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "農夫Carry";
            // 
            // btnHow
            // 
            this.btnHow.Location = new System.Drawing.Point(222, 22);
            this.btnHow.Name = "btnHow";
            this.btnHow.Size = new System.Drawing.Size(98, 33);
            this.btnHow.TabIndex = 1;
            this.btnHow.Text = "說明";
            this.btnHow.UseVisualStyleBackColor = true;
            this.btnHow.Click += new System.EventHandler(this.btnHow_Click);
            // 
            // btnLtoR
            // 
            this.btnLtoR.Location = new System.Drawing.Point(160, 89);
            this.btnLtoR.Name = "btnLtoR";
            this.btnLtoR.Size = new System.Drawing.Size(95, 40);
            this.btnLtoR.TabIndex = 2;
            this.btnLtoR.Text = "------>";
            this.btnLtoR.UseVisualStyleBackColor = true;
            this.btnLtoR.Click += new System.EventHandler(this.btnLtoR_Click);
            // 
            // btnRtoL
            // 
            this.btnRtoL.Location = new System.Drawing.Point(160, 145);
            this.btnRtoL.Name = "btnRtoL";
            this.btnRtoL.Size = new System.Drawing.Size(95, 40);
            this.btnRtoL.TabIndex = 3;
            this.btnRtoL.Text = "<------";
            this.btnRtoL.UseVisualStyleBackColor = true;
            this.btnRtoL.Click += new System.EventHandler(this.btnRtoL_Click);
            // 
            // lbLeft
            // 
            this.lbLeft.FormattingEnabled = true;
            this.lbLeft.ItemHeight = 23;
            this.lbLeft.Items.AddRange(new object[] {
            "農夫",
            "小羊",
            "蔬菜",
            "野狼"});
            this.lbLeft.Location = new System.Drawing.Point(12, 69);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(120, 142);
            this.lbLeft.TabIndex = 4;
            // 
            // lbRight
            // 
            this.lbRight.FormattingEnabled = true;
            this.lbRight.ItemHeight = 23;
            this.lbRight.Location = new System.Drawing.Point(282, 69);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(120, 142);
            this.lbRight.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 231);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.lbLeft);
            this.Controls.Add(this.btnRtoL);
            this.Controls.Add(this.btnLtoR);
            this.Controls.Add(this.btnHow);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnHow;
        private System.Windows.Forms.Button btnLtoR;
        private System.Windows.Forms.Button btnRtoL;
        private System.Windows.Forms.ListBox lbLeft;
        private System.Windows.Forms.ListBox lbRight;
    }
}

