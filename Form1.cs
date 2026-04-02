namespace LoginScreen
{
    public partial class Form1 : Form
    {
        // 컨트롤 변수 선언
        TextBox txtId, txtPassword;
        Button btnLogin;

        String id = "admin";
        String password = "password";
        public Form1()
        {
            InitializeComponent();
            // 생성자에서 컨트롤 변수 초기화
            txtId = txt_id;
            txtPassword = txt_password;
            btnLogin = btn_login;
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txtId.Text == id && txtPassword.Text == password)
            {
                MessageBox.Show("로그인 성공");
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 다릅니다");
            }
        }
        
    }
}
