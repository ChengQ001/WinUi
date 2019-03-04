namespace WinUI.Form
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.LoginBtn = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.TextUser = new CCWin.SkinControl.SkinTextBox();
            this.TestPwd = new CCWin.SkinControl.SkinTextBox();
            this.QuitBtn = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.LoginBtn.DownBack = null;
            this.LoginBtn.Location = new System.Drawing.Point(65, 172);
            this.LoginBtn.MouseBack = null;
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.NormlBack = null;
            this.LoginBtn.Size = new System.Drawing.Size(75, 28);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "登录";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("方正粗黑宋简体", 9F, System.Drawing.FontStyle.Bold);
            this.skinLabel1.Location = new System.Drawing.Point(45, 76);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(37, 15);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "账号:";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("方正粗黑宋简体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(45, 122);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(37, 15);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "密码:";
            // 
            // TextUser
            // 
            this.TextUser.BackColor = System.Drawing.Color.Transparent;
            this.TextUser.DownBack = null;
            this.TextUser.Icon = null;
            this.TextUser.IconIsButton = false;
            this.TextUser.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextUser.IsPasswordChat = '\0';
            this.TextUser.IsSystemPasswordChar = false;
            this.TextUser.Lines = new string[] {
        "admin"};
            this.TextUser.Location = new System.Drawing.Point(94, 71);
            this.TextUser.Margin = new System.Windows.Forms.Padding(0);
            this.TextUser.MaxLength = 32767;
            this.TextUser.MinimumSize = new System.Drawing.Size(28, 28);
            this.TextUser.MouseBack = null;
            this.TextUser.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextUser.Multiline = false;
            this.TextUser.Name = "TextUser";
            this.TextUser.NormlBack = null;
            this.TextUser.Padding = new System.Windows.Forms.Padding(5);
            this.TextUser.ReadOnly = false;
            this.TextUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextUser.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.TextUser.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextUser.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextUser.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.TextUser.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.TextUser.SkinTxt.Name = "BaseText";
            this.TextUser.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.TextUser.SkinTxt.TabIndex = 0;
            this.TextUser.SkinTxt.Text = "admin";
            this.TextUser.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextUser.SkinTxt.WaterText = "";
            this.TextUser.TabIndex = 2;
            this.TextUser.Tag = "";
            this.TextUser.Text = "admin";
            this.TextUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextUser.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextUser.WaterText = "";
            this.TextUser.WordWrap = true;
            // 
            // TestPwd
            // 
            this.TestPwd.BackColor = System.Drawing.Color.Transparent;
            this.TestPwd.DownBack = null;
            this.TestPwd.Icon = null;
            this.TestPwd.IconIsButton = false;
            this.TestPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TestPwd.IsPasswordChat = '●';
            this.TestPwd.IsSystemPasswordChar = true;
            this.TestPwd.Lines = new string[] {
        "123456"};
            this.TestPwd.Location = new System.Drawing.Point(94, 112);
            this.TestPwd.Margin = new System.Windows.Forms.Padding(0);
            this.TestPwd.MaxLength = 32767;
            this.TestPwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.TestPwd.MouseBack = null;
            this.TestPwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TestPwd.Multiline = false;
            this.TestPwd.Name = "TestPwd";
            this.TestPwd.NormlBack = null;
            this.TestPwd.Padding = new System.Windows.Forms.Padding(5);
            this.TestPwd.ReadOnly = false;
            this.TestPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TestPwd.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.TestPwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TestPwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestPwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.TestPwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.TestPwd.SkinTxt.Name = "BaseText";
            this.TestPwd.SkinTxt.PasswordChar = '●';
            this.TestPwd.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.TestPwd.SkinTxt.TabIndex = 0;
            this.TestPwd.SkinTxt.Text = "123456";
            this.TestPwd.SkinTxt.UseSystemPasswordChar = true;
            this.TestPwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TestPwd.SkinTxt.WaterText = "";
            this.TestPwd.TabIndex = 3;
            this.TestPwd.Text = "123456";
            this.TestPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TestPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TestPwd.WaterText = "";
            this.TestPwd.WordWrap = true;
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackColor = System.Drawing.Color.Transparent;
            this.QuitBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.QuitBtn.DownBack = null;
            this.QuitBtn.Location = new System.Drawing.Point(190, 172);
            this.QuitBtn.MouseBack = null;
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.NormlBack = null;
            this.QuitBtn.Size = new System.Drawing.Size(75, 28);
            this.QuitBtn.TabIndex = 0;
            this.QuitBtn.Text = "退出";
            this.QuitBtn.UseVisualStyleBackColor = false;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 230);
            this.Controls.Add(this.TestPwd);
            this.Controls.Add(this.TextUser);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.LoginBtn);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton LoginBtn;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox TextUser;
        private CCWin.SkinControl.SkinTextBox TestPwd;
        private CCWin.SkinControl.SkinButton QuitBtn;
    }
}