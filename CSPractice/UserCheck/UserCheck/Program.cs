using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UserCheck
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /*DialogResult result = DialogResult.Cancel;
            while (result == DialogResult.Cancel)
            {
                string city = Microsoft.VisualBasic.Interaction.InputBox("請輸入居住城市", "居住地", "公園");
                result = MessageBox.Show("你輸入的是:" + city + "\r\n是否結束程式?", "打招呼",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }*/
        }
    }
}
