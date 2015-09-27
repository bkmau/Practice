using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace UserCheck
{
    class InputBox
    {
        static TextBox txt1;
        static Label lbl1;
        static Button btnOK, btnCancel;
        static Form form;
        static bool CanClose;
        
        public static string Show(string prompt, string title, string defStr)
        {
            form = new Form();
            InitializeComponent(form, prompt, title, defStr);
            while (!CanClose)
            {
                form.ShowDialog();
            }
            return txt1.Text;
        }

        private static void InitializeComponent(Form form, string prompt, string title, string defStr)
        {
            lbl1 = new System.Windows.Forms.Label();
            txt1 = new System.Windows.Forms.TextBox();
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();

            lbl1.Location = new System.Drawing.Point(16, 23);
            lbl1.AutoSize = true;
            lbl1.Text = prompt;
            lbl1.TabIndex = 0;

            txt1.Location = new System.Drawing.Point(21, 67);
            txt1.Size = new System.Drawing.Size(330, 33);
            txt1.Text = defStr;
            txt1.SelectAll();
            txt1.TabIndex = 1;

            btnOK.Location = new System.Drawing.Point(21, 116);
            btnOK.Size = new System.Drawing.Size(164, 34);
            btnOK.Text = "確定";
            btnOK.TabIndex = 2;
            btnOK.Click += new System.EventHandler(btnOK_Click);

            btnCancel.Location = new System.Drawing.Point(187, 116);
            btnCancel.Size = new System.Drawing.Size(164, 34);
            btnCancel.Text = "放棄";
            btnCancel.TabIndex = 3;
            btnCancel.Click += new System.EventHandler(btnCancel_Click);

            form.ClientSize = new System.Drawing.Size(371, 166);
            form.Controls.Add(btnCancel);
            form.Controls.Add(btnOK);
            form.Controls.Add(txt1);
            form.Controls.Add(lbl1);
            form.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            form.Text = title;
            
            CanClose = false;
        }

        private static void btnOK_Click(object sender, EventArgs e)
        {
            CanClose = true;
            form.Visible = false;
        }

        private static void btnCancel_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            CanClose = true;
            form.Visible = false;
        }
    }
}
