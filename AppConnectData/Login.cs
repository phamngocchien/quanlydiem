using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConnectData
{
    public partial class Login : Form
    {
        SqlConnection connection; // mở kết nối với database
        SqlCommand command; // tạo ra các đối tượng để có thể thức thi câu lệnh sql
        string str = "Data Source=PNC;Initial Catalog=QLNganhHoc;Integrated Security=True";
        bool isLogin = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(str);
                connection.Open();
                string tk = txtTK.Text;
                string mk = txtMK.Text;
                string sql = "select * from Login where taikhoan = '"+ tk +"' and matkhau = '"+ mk +"'";
                command = new SqlCommand(sql, connection);
                SqlDataReader data = command.ExecuteReader();
                if(data.Read() == true)
                {
                    this.Hide();
                    quanLyNganhHoc f = new quanLyNganhHoc();
                    f.ShowDialog();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo");
                    txtTK.Clear();
                    txtMK.Clear();
                    txtTK.Focus();
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
