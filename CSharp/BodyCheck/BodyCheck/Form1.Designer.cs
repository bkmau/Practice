namespace BodyCheck
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
            this.txt_Tall_CM = new System.Windows.Forms.TextBox();
            this.txt_Weight = new System.Windows.Forms.TextBox();
            this.btn_Boy = new System.Windows.Forms.Button();
            this.btn_Girl = new System.Windows.Forms.Button();
            this.txt_Tall_Inch = new System.Windows.Forms.TextBox();
            this.btn_Tran = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 16F);
            this.lbl1.Location = new System.Drawing.Point(27, 43);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(122, 26);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "請輸入身高";
            // 
            // txt_Tall_CM
            // 
            this.txt_Tall_CM.Location = new System.Drawing.Point(32, 87);
            this.txt_Tall_CM.Name = "txt_Tall_CM";
            this.txt_Tall_CM.Size = new System.Drawing.Size(117, 27);
            this.txt_Tall_CM.TabIndex = 1;
            this.txt_Tall_CM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Tall_CM_KeyUp);
            // 
            // txt_Weight
            // 
            this.txt_Weight.Location = new System.Drawing.Point(32, 231);
            this.txt_Weight.Name = "txt_Weight";
            this.txt_Weight.Size = new System.Drawing.Size(235, 27);
            this.txt_Weight.TabIndex = 2;
            // 
            // btn_Boy
            // 
            this.btn_Boy.Location = new System.Drawing.Point(32, 283);
            this.btn_Boy.Name = "btn_Boy";
            this.btn_Boy.Size = new System.Drawing.Size(100, 38);
            this.btn_Boy.TabIndex = 3;
            this.btn_Boy.Text = "男生";
            this.btn_Boy.UseVisualStyleBackColor = true;
            this.btn_Boy.Click += new System.EventHandler(this.btn_Boy_Click);
            // 
            // btn_Girl
            // 
            this.btn_Girl.Location = new System.Drawing.Point(167, 283);
            this.btn_Girl.Name = "btn_Girl";
            this.btn_Girl.Size = new System.Drawing.Size(100, 38);
            this.btn_Girl.TabIndex = 4;
            this.btn_Girl.Text = "女生";
            this.btn_Girl.UseVisualStyleBackColor = true;
            this.btn_Girl.Click += new System.EventHandler(this.btn_Girl_Click);
            // 
            // txt_Tall_Inch
            // 
            this.txt_Tall_Inch.Location = new System.Drawing.Point(32, 182);
            this.txt_Tall_Inch.Name = "txt_Tall_Inch";
            this.txt_Tall_Inch.Size = new System.Drawing.Size(117, 27);
            this.txt_Tall_Inch.TabIndex = 5;
            this.txt_Tall_Inch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Tall_Inch_KeyUp);
            // 
            // btn_Tran
            // 
            this.btn_Tran.Image = global::BodyCheck.Properties.Resources.refresh_26;
            this.btn_Tran.Location = new System.Drawing.Point(167, 131);
            this.btn_Tran.Name = "btn_Tran";
            this.btn_Tran.Size = new System.Drawing.Size(32, 27);
            this.btn_Tran.TabIndex = 6;
            this.btn_Tran.UseVisualStyleBackColor = true;
            this.btn_Tran.Click += new System.EventHandler(this.btn_Tran_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16F);
            this.label1.Location = new System.Drawing.Point(155, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "公分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16F);
            this.label2.Location = new System.Drawing.Point(155, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "英吋";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 347);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Tran);
            this.Controls.Add(this.txt_Tall_Inch);
            this.Controls.Add(this.btn_Girl);
            this.Controls.Add(this.btn_Boy);
            this.Controls.Add(this.txt_Weight);
            this.Controls.Add(this.txt_Tall_CM);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt_Tall_CM;
        private System.Windows.Forms.TextBox txt_Weight;
        private System.Windows.Forms.Button btn_Boy;
        private System.Windows.Forms.Button btn_Girl;
        private System.Windows.Forms.TextBox txt_Tall_Inch;
        private System.Windows.Forms.Button btn_Tran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

