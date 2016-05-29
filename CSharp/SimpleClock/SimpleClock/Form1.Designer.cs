namespace SimpleClock
{
    partial class MainF
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
            this.Btn_DateTime = new System.Windows.Forms.Button();
            this.Btn_Text = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_DateTime
            // 
            this.Btn_DateTime.Location = new System.Drawing.Point(83, 249);
            this.Btn_DateTime.Name = "Btn_DateTime";
            this.Btn_DateTime.Size = new System.Drawing.Size(121, 55);
            this.Btn_DateTime.TabIndex = 0;
            this.Btn_DateTime.Text = "顯示日期時間";
            this.Btn_DateTime.UseVisualStyleBackColor = true;
            this.Btn_DateTime.Click += new System.EventHandler(this.Btn_DateTime_Click);
            // 
            // Btn_Text
            // 
            this.Btn_Text.Location = new System.Drawing.Point(320, 249);
            this.Btn_Text.Name = "Btn_Text";
            this.Btn_Text.Size = new System.Drawing.Size(121, 55);
            this.Btn_Text.TabIndex = 1;
            this.Btn_Text.Text = "顯示文字";
            this.Btn_Text.UseVisualStyleBackColor = true;
            this.Btn_Text.Click += new System.EventHandler(this.Btn_Text_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F);
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 197);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Text);
            this.Controls.Add(this.Btn_DateTime);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainF";
            this.Text = "簡單時鐘";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_DateTime;
        private System.Windows.Forms.Button Btn_Text;
        private System.Windows.Forms.Label label1;
    }
}

