namespace Quota
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.cbSeason = new System.Windows.Forms.ComboBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(603, 188);
            this.txtDisplay.TabIndex = 0;
            // 
            // cbCompany
            // 
            this.cbCompany.AutoCompleteCustomSource.AddRange(new string[] {
            "0. 請選擇",
            "1. 台北總公司",
            "2. 台中分公司",
            "3. 台南分公司"});
            this.cbCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Items.AddRange(new object[] {
            "0. 請選擇",
            "1. 台北總公司",
            "2. 台中分公司",
            "3. 台南分公司"});
            this.cbCompany.Location = new System.Drawing.Point(12, 217);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(176, 31);
            this.cbCompany.TabIndex = 1;
            this.cbCompany.Text = "0. 請選擇";
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(321, 217);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(100, 31);
            this.txtProfit.TabIndex = 2;
            // 
            // cbSeason
            // 
            this.cbSeason.AutoCompleteCustomSource.AddRange(new string[] {
            "0. 請選擇",
            "1. 第一季",
            "2. 第二季",
            "3. 第三季",
            "3. 第四季"});
            this.cbSeason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbSeason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSeason.FormattingEnabled = true;
            this.cbSeason.Items.AddRange(new object[] {
            "0. 請選擇",
            "1. 第一季",
            "2. 第二季",
            "3. 第三季",
            "3. 第四季"});
            this.cbSeason.Location = new System.Drawing.Point(194, 218);
            this.cbSeason.Name = "cbSeason";
            this.cbSeason.Size = new System.Drawing.Size(121, 31);
            this.cbSeason.TabIndex = 3;
            this.cbSeason.Text = "0. 請選擇";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(427, 217);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(108, 31);
            this.btnInput.TabIndex = 4;
            this.btnInput.Text = "輸入";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 260);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.cbSeason);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.cbCompany);
            this.Controls.Add(this.txtDisplay);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.ComboBox cbSeason;
        private System.Windows.Forms.Button btnInput;
    }
}

