using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WinUI.Form;

namespace WinUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main());

            Login lg = new Login();

            DialogResult dr = lg.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Application.Run(new Main());
            }
        }
    }
}
