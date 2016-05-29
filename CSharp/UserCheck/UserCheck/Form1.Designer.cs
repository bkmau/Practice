namespace UserCheck
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
            this.btn_VB = new System.Windows.Forms.Button();
            this.btn_CS = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_VB
            // 
            this.btn_VB.Location = new System.Drawing.Point(12, 12);
            this.btn_VB.Name = "btn_VB";
            this.btn_VB.Size = new System.Drawing.Size(153, 53);
            this.btn_VB.TabIndex = 0;
            this.btn_VB.Text = "VB版";
            this.btn_VB.UseVisualStyleBackColor = true;
            this.btn_VB.Click += new System.EventHandler(this.btn_VB_Click);
            // 
            // btn_CS
            // 
            this.btn_CS.Location = new System.Drawing.Point(182, 12);
            this.btn_CS.Name = "btn_CS";
            this.btn_CS.Size = new System.Drawing.Size(153, 53);
            this.btn_CS.TabIndex = 1;
            this.btn_CS.Text = "C#版";
            this.btn_CS.UseVisualStyleBackColor = true;
            this.btn_CS.Click += new System.EventHandler(this.btn_CS_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 84);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(99, 23);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "你輸入了:";
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(117, 84);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(218, 27);
            this.lblResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 136);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btn_CS);
            this.Controls.Add(this.btn_VB);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "訊息方塊";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_VB;
        private System.Windows.Forms.Button btn_CS;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblResult;
    }
}

