namespace Score
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
            this.lblDisp = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisp
            // 
            this.lblDisp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDisp.Location = new System.Drawing.Point(12, 9);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(384, 320);
            this.lblDisp.TabIndex = 0;
            this.lblDisp.Text = "label1";
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(402, 25);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(145, 38);
            this.btnScore.TabIndex = 1;
            this.btnScore.Text = "原始成績";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(402, 81);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(145, 38);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "依成績排名";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(402, 138);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(145, 38);
            this.btnPass.TabIndex = 3;
            this.btnPass.Text = "查詢及格名單";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 338);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lblDisp);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnPass;
    }
}

