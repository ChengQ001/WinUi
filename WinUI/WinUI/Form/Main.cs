using CCWin;
using System;
using System.Windows.Forms;
using WinUI.Model;
using WinUI.拓展库;

namespace WinUI
{
   
    public partial class Main : BaseForm
    {
        
        public Main()
        {
            InitializeComponent();
            LoginLabel.Text = "欢迎" + UserModel.UserName + "!";
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow; //不允许拖动大小
            this.MaximizeBox = false;
        }

        //数字、小数点（最大到2位）、退格键、负号
     
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show("ad");
        }

        private void SkinButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
