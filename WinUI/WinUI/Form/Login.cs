using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinUI.HelpClass;
using WinUI.Model;
using WinUI.拓展库;
using WinUI.资源文件;

namespace WinUI.Form
{
    public partial class Login : BaseForm
    {
        public Login()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Text = "我的记账小屋登录";
            this.BackgroundImage = Doc.bg1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow; //不允许拖动大小
            this.AcceptButton = this.LoginBtn;
        }







        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var userNmae = TextUser.Text.Trim();
            var userPwd = TestPwd.Text.Trim();
            if (!(userNmae == "admin" && userPwd == "123456"))
            {
                MessageBoxEx.Show("账号密码不正确");
                return;
            }
            UserModel.UserName = userNmae;
            this.DialogResult = DialogResult.OK;
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
