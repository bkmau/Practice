namespace ScoreAvg
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
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnCalAvg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl1.Location = new System.Drawing.Point(26, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(189, 23);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "label1";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(221, 19);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 31);
            this.txtScore.TabIndex = 1;
            this.txtScore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtScore_MouseDown);
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMsg.Location = new System.Drawing.Point(26, 67);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(299, 314);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "label2";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(339, 19);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(110, 45);
            this.btnInput.TabIndex = 3;
            this.btnInput.Text = "輸入成績";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnCalAvg
            // 
            this.btnCalAvg.Location = new System.Drawing.Point(339, 82);
            this.btnCalAvg.Name = "btnCalAvg";
            this.btnCalAvg.Size = new System.Drawing.Size(110, 45);
            this.btnCalAvg.TabIndex = 4;
            this.btnCalAvg.Text = "計算平均";
            this.btnCalAvg.UseVisualStyleBackColor = true;
            this.btnCalAvg.Click += new System.EventHandler(this.btnCalAvg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 400);
            this.Controls.Add(this.btnCalAvg);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnCalAvg;
    }
}

