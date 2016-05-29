namespace Shop
{
    partial class Cashier
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
            this.lblGrantTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtGrantTotal = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listProducts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblGrantTotal
            // 
            this.lblGrantTotal.AutoSize = true;
            this.lblGrantTotal.Location = new System.Drawing.Point(317, 319);
            this.lblGrantTotal.Name = "lblGrantTotal";
            this.lblGrantTotal.Size = new System.Drawing.Size(50, 23);
            this.lblGrantTotal.TabIndex = 13;
            this.lblGrantTotal.Text = "總計";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(317, 259);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(50, 23);
            this.lblSubTotal.TabIndex = 12;
            this.lblSubTotal.Text = "小計";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(317, 199);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(50, 23);
            this.lblNum.TabIndex = 11;
            this.lblNum.Text = "數量";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(317, 139);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(50, 23);
            this.lblUnitPrice.TabIndex = 10;
            this.lblUnitPrice.Text = "單價";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(317, 83);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(50, 23);
            this.lblProductName.TabIndex = 9;
            this.lblProductName.Text = "品名";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(212, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(135, 35);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "結帳畫面";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductName.Location = new System.Drawing.Point(373, 80);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(182, 31);
            this.txtProductName.TabIndex = 14;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(373, 136);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 31);
            this.txtUnitPrice.TabIndex = 15;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(373, 196);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 31);
            this.txtNum.TabIndex = 16;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(373, 256);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 31);
            this.txtSubTotal.TabIndex = 17;
            // 
            // txtGrantTotal
            // 
            this.txtGrantTotal.Location = new System.Drawing.Point(373, 316);
            this.txtGrantTotal.Name = "txtGrantTotal";
            this.txtGrantTotal.Size = new System.Drawing.Size(100, 31);
            this.txtGrantTotal.TabIndex = 18;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(306, 390);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 38);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "結帳";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(424, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 38);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "清除";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // listProducts
            // 
            this.listProducts.FormattingEnabled = true;
            this.listProducts.ItemHeight = 23;
            this.listProducts.Location = new System.Drawing.Point(12, 69);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(259, 372);
            this.listProducts.TabIndex = 21;
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 458);
            this.Controls.Add(this.listProducts);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtGrantTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblGrantTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrantTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtGrantTotal;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listProducts;
    }
}