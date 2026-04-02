namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_title = new Label();
            txt_id = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("맑은 고딕", 30F);
            lbl_title.Location = new Point(153, 47);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(245, 106);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Login";
            // 
            // txt_id
            // 
            txt_id.Font = new Font("맑은 고딕", 15F);
            txt_id.Location = new Point(75, 187);
            txt_id.Name = "txt_id";
            txt_id.PlaceholderText = "아이디";
            txt_id.Size = new Size(429, 61);
            txt_id.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("맑은 고딕", 15F);
            txt_password.Location = new Point(75, 306);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.PlaceholderText = "비밀번호";
            txt_password.Size = new Size(429, 61);
            txt_password.TabIndex = 2;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("맑은 고딕", 12F);
            btn_login.Location = new Point(192, 421);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(150, 61);
            btn_login.TabIndex = 3;
            btn_login.Text = "로그인";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 608);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_id);
            Controls.Add(lbl_title);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private TextBox txt_id;
        private TextBox txt_password;
        private Button btn_login;
    }
}
