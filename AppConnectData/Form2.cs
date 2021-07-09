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
    public partial class Form2 : Form
    {
        SqlConnection connection; // mở kết nối với database
        SqlCommand command; // tạo ra các đối tượng để có thể thức thi câu lệnh sql
        string str = "Data Source=PNC;Initial Catalog=QLNganhHoc;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadDataMH();
            dataGridViewMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMH.AutoResizeRows();
        }
        // load data Môn Hoc - start
        void loadDataMH()
        {
            var a = new SqlDataAdapter("select maMH as 'Mã Ngành Học', tenMH as 'Tên Ngành Học', soTinChi as 'Số Tín Chỉ' from MonHoc", connection);
            DataTable table = new DataTable();
            table.Clear();
            a.Fill(table);
            dataGridViewMH.DataSource = table;
        }
        // load data Môn Hoc - end

        // lựa chọn thêm, sửa, xóa, xóa trắng môn học - start
        private void btnThemMH_Click(object sender, EventArgs e)
        {
            connection.Close();
            if(txtMMH.Text =="" || txtTMH.Text == "" || txtSTC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập các trường đầy đủ", "Thông báo");
            }
            else
            {
                if(ktraMaMH(txtMMH.Text) == true)
                {
                    MessageBox.Show("Mã môn học đã tồn tại", "Thông báo");
                }
                else
                {
                    connection.Open();
                    var cmdMH = new SqlCommand();
                    cmdMH = connection.CreateCommand();
                    cmdMH.CommandText = "insert into MonHoc values(N'" + txtMMH.Text + "', N'" + txtTMH.Text + "', N'" + txtSTC.Text + "')";
                    cmdMH.ExecuteNonQuery();
                    loadDataMH();
                }
            }

        }
        public bool ktraMaMH(string maMH)
        {
            connection.Open();
            string sql = "select maMH from MonHoc where mamh = '" + maMH + "'";
            command = new SqlCommand(sql, connection);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read() == true)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            if (txtMMH.Text == "" || txtTMH.Text == "" || txtSTC.Text == "")
            {
                MessageBox.Show("Vui lòng chọn môn học muốn xóa", "Thông báo");
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn xóa môn học: " + txtTMH.Text + " ", "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    command = connection.CreateCommand();
                    command.CommandText = "delete from MonHoc where maMH = N'" + txtMMH.Text + "'";
                    command.ExecuteNonQuery();
                    txtTMH.Text = "";
                    txtMMH.Text = "";
                    txtSTC.Text = "";
                    loadDataMH();
                }
            }

        }

        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            if (txtMMH.Text == "" || txtTMH.Text == "" || txtSTC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập các trường đầy đủ", "Thông báo");
            }
            else
            {
                var cmd = new SqlCommand();
                cmd = connection.CreateCommand();
                cmd.CommandText = "update MonHoc set TenMH = N'"  +txtTMH.Text + "', soTinChi = N'" + txtSTC.Text + "' where maMH = N'" + txtMMH.Text + "'";
                cmd.ExecuteNonQuery();
                loadDataMH();
            }
        }

        private void btnXoaTrangMH_Click(object sender, EventArgs e)
        {
            txtMMH.Enabled = true;
            txtMMH.Text = "";
            txtTMH.Text = "";
            txtSTC.Text = "";
        }

        private void dataGridViewMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMMH.Enabled = false;
            int j;
            j = dataGridViewMH.CurrentRow.Index;
            txtMMH.Text = dataGridViewMH.Rows[j].Cells[0].Value.ToString();
            txtTMH.Text = dataGridViewMH.Rows[j].Cells[1].Value.ToString();
            txtSTC.Text = dataGridViewMH.Rows[j].Cells[2].Value.ToString();
        }
        // lựa chọn thêm, sửa, xóa, xóa trắng môn học - end
    }
}
