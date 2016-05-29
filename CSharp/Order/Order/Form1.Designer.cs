namespace Order
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblToal = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_FrenchFries = new System.Windows.Forms.CheckBox();
            this.cb_Coke = new System.Windows.Forms.CheckBox();
            this.cb_CornChowder = new System.Windows.Forms.CheckBox();
            this.radioBtn_Chicken = new System.Windows.Forms.RadioButton();
            this.radioBtn_Fish = new System.Windows.Forms.RadioButton();
            this.radioBtn_Nugget = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(187, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(90, 23);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "點餐系統";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(8, 237);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(99, 23);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "消費金額:";
            // 
            // lblToal
            // 
            this.lblToal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblToal.Location = new System.Drawing.Point(113, 237);
            this.lblToal.Name = "lblToal";
            this.lblToal.Size = new System.Drawing.Size(87, 23);
            this.lblToal.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(311, 228);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(116, 40);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "確定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_Nugget);
            this.groupBox1.Controls.Add(this.radioBtn_Fish);
            this.groupBox1.Controls.Add(this.radioBtn_Chicken);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 147);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主餐";
            // 
            // cb_FrenchFries
            // 
            this.cb_FrenchFries.AutoSize = true;
            this.cb_FrenchFries.Location = new System.Drawing.Point(19, 74);
            this.cb_FrenchFries.Name = "cb_FrenchFries";
            this.cb_FrenchFries.Size = new System.Drawing.Size(131, 27);
            this.cb_FrenchFries.TabIndex = 0;
            this.cb_FrenchFries.Text = "薯條(30元)";
            this.cb_FrenchFries.UseVisualStyleBackColor = true;
            // 
            // cb_Coke
            // 
            this.cb_Coke.AutoSize = true;
            this.cb_Coke.Location = new System.Drawing.Point(19, 39);
            this.cb_Coke.Name = "cb_Coke";
            this.cb_Coke.Size = new System.Drawing.Size(131, 27);
            this.cb_Coke.TabIndex = 1;
            this.cb_Coke.Text = "可樂(20元)";
            this.cb_Coke.UseVisualStyleBackColor = true;
            // 
            // cb_CornChowder
            // 
            this.cb_CornChowder.AutoSize = true;
            this.cb_CornChowder.Location = new System.Drawing.Point(19, 107);
            this.cb_CornChowder.Name = "cb_CornChowder";
            this.cb_CornChowder.Size = new System.Drawing.Size(171, 27);
            this.cb_CornChowder.TabIndex = 2;
            this.cb_CornChowder.Text = "玉米濃湯(40元)";
            this.cb_CornChowder.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Chicken
            // 
            this.radioBtn_Chicken.AutoSize = true;
            this.radioBtn_Chicken.Location = new System.Drawing.Point(19, 39);
            this.radioBtn_Chicken.Name = "radioBtn_Chicken";
            this.radioBtn_Chicken.Size = new System.Drawing.Size(162, 27);
            this.radioBtn_Chicken.TabIndex = 0;
            this.radioBtn_Chicken.TabStop = true;
            this.radioBtn_Chicken.Text = "麥香雞(100元)";
            this.radioBtn_Chicken.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Fish
            // 
            this.radioBtn_Fish.AutoSize = true;
            this.radioBtn_Fish.Location = new System.Drawing.Point(19, 74);
            this.radioBtn_Fish.Name = "radioBtn_Fish";
            this.radioBtn_Fish.Size = new System.Drawing.Size(150, 27);
            this.radioBtn_Fish.TabIndex = 1;
            this.radioBtn_Fish.TabStop = true;
            this.radioBtn_Fish.Text = "麥香魚(99元)";
            this.radioBtn_Fish.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Nugget
            // 
            this.radioBtn_Nugget.AutoSize = true;
            this.radioBtn_Nugget.Location = new System.Drawing.Point(19, 107);
            this.radioBtn_Nugget.Name = "radioBtn_Nugget";
            this.radioBtn_Nugget.Size = new System.Drawing.Size(182, 27);
            this.radioBtn_Nugget.TabIndex = 2;
            this.radioBtn_Nugget.TabStop = true;
            this.radioBtn_Nugget.Text = "麥克雞塊(110元)";
            this.radioBtn_Nugget.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_Coke);
            this.groupBox2.Controls.Add(this.cb_CornChowder);
            this.groupBox2.Controls.Add(this.cb_FrenchFries);
            this.groupBox2.Location = new System.Drawing.Point(264, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 147);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "副餐";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(200, 235);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(30, 23);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "元";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 291);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblToal);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblToal;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_CornChowder;
        private System.Windows.Forms.CheckBox cb_Coke;
        private System.Windows.Forms.CheckBox cb_FrenchFries;
        private System.Windows.Forms.RadioButton radioBtn_Fish;
        private System.Windows.Forms.RadioButton radioBtn_Chicken;
        private System.Windows.Forms.RadioButton radioBtn_Nugget;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl3;
    }
}

