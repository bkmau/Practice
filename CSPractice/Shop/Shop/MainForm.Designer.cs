namespace Shop
{
    partial class MainForm
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
            this.btnSell = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(12, 12);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(106, 41);
            this.btnSell.TabIndex = 0;
            this.btnSell.Text = "結帳";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnInv
            // 
            this.btnInv.Location = new System.Drawing.Point(124, 12);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(106, 41);
            this.btnInv.TabIndex = 1;
            this.btnInv.Text = "庫存";
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.btnInv_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 67);
            this.Controls.Add(this.btnInv);
            this.Controls.Add(this.btnSell);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnInv;
    }
}

