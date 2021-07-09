using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppConnectData
{
    public partial class quanLyNganhHoc : Form
    {
        SqlConnection connection; // mở kết nối với database
        SqlCommand command; // tạo ra các đối tượng để có thể thức thi câu lệnh sql
        
        string str = "Data Source=PNC;Initial Catalog=QLNganhHoc;Integrated Security=True";
        //SqlDataAdapter adapter = new SqlDataAdapter();//đối tượng chứa dữ liệu,tên, dòng, cột của một bảng (Table) của CSDL.
        //DataTable table = new DataTable();//dữ liệu db sẽ đẩy xuống table

        public quanLyNganhHoc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Login login = new Login();
            //Application.Run(login);
            //if (login.isLogin == true){
            //    Application.Run(new quanLyNganhHoc());
            //}

            connection = new SqlConnection(str);
            connection.Open();
            var cmdd = new SqlDataAdapter("select MaNganhHoc from NganhHoc", connection);
            var dt = new DataTable();
            dt.Clear();
            cmdd.Fill(dt);
            cbNganhHoc.DisplayMember = "MaNganhHoc";
            cbNganhHoc.DataSource = dt;
            loadDataNH();
            loadDataAllSV();

            // căn chỉnh dataGridView
            //dataGridViewNH.AutoResizeColumns();
            dataGridViewNH.AutoResizeRows();
            dataGridViewNH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSV.AutoResizeRows();
            dataGridViewSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }

        // load data Sinh Viên, Ngành Học - start
        void loadDataAllSV()
        {
            var b = new SqlDataAdapter("select MaSV as 'Mã Sinh Viên', TenSV as 'Tên Sinh Viên', MaNganhHoc as 'Mã Ngành Học' from SinhVien", connection);
            DataTable tableSV = new DataTable();
            tableSV.Clear();
            b.Fill(tableSV);
            dataGridViewSV.DataSource = tableSV;
        }
        void loadDataNH()
        {

            var a = new SqlDataAdapter("select MaNganhHoc as 'Mã Ngành Học', TenNganhHoc as 'Tên Ngành Học' from NganhHoc", connection);
            DataTable table = new DataTable();
            table.Clear();
            a.Fill(table);
            dataGridViewNH.DataSource = table;
        }
        void loadDataSV()
        {
            int i;
            i = dataGridViewNH.CurrentRow.Index;
            var maNganh = dataGridViewNH.Rows[i].Cells[0].Value.ToString();
            var a = new SqlDataAdapter("select MaSV as 'Mã Sinh Viên', TenSV as 'Tên Sinh Viên', MaNganhHoc as 'Mã Ngành Học' from SinhVien where MaNganhhoc = '" + maNganh + "'", connection);
            DataTable tableSv = new DataTable();
            tableSv.Clear();
            a.Fill(tableSv);
            dataGridViewSV.DataSource = tableSv;
        }
        // load data Sinh Viên, Ngành Học - end



        // Lựa chọn thêm sửa, xóa, xóa trắng Ngành Học - start
        public bool ktraMaNH(string maNH)
        {
            connection.Open();
            string sql = "select MaNganhhoc as 'Mã Ngành Học' from NganhHoc where MaNganhhoc = '" + maNH + "'";
            command = new SqlCommand(sql, connection);
            SqlDataReader dr = command.ExecuteReader();
            if(dr.Read() == true)
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

        private void btnAddNH_Click(object sender, EventArgs e)
        {
            connection.Close();
            if (txtIDNganhHoc.Text == "" || txtTenNganhHoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường", "Thông báo");
            }

            else
            {
                if (ktraMaNH(txtIDNganhHoc.Text) == true)
                {
                    MessageBox.Show("Mã ngành đã tồn tại", "Thông báo");

                }
                else
                {
                    connection.Open();
                    var cmdNH = new SqlCommand();
                    cmdNH = connection.CreateCommand();
                    cmdNH.CommandText = "insert into NganhHoc values(N'" + txtIDNganhHoc.Text + "', N'" + txtTenNganhHoc.Text + "')";
                    cmdNH.ExecuteNonQuery();

                    loadDataNH();
                }
            }
        }

        private void btnDeleteNH_Click(object sender, EventArgs e)
        {
            if (txtIDNganhHoc.Text == "" || txtTenNganhHoc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên muốn xóa","Thông báo");
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn xóa ngành học: " + txtTenNganhHoc.Text + " ", "Xác nhận",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    command = connection.CreateCommand();
                    command.CommandText = "delete from NganhHoc where MaNganhhoc = '" + txtIDNganhHoc.Text + "'";
                    command.ExecuteNonQuery();
                    txtIDNganhHoc.Text = "";
                    txtTenNganhHoc.Text = "";
                    loadDataNH();
                }
            }

        }

        private void btnRepairNH_Click(object sender, EventArgs e)
        {
            if (txtIDNganhHoc.Text == "" || txtTenNganhHoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường", "Thông báo");
            }

            else
            {
                int k;
                k = dataGridViewNH.CurrentRow.Index;
                var mnh = dataGridViewNH.Rows[k].Cells[0].Value.ToString();
                if (mnh == txtIDNganhHoc.Text)
                {
                    command = connection.CreateCommand();
                    command.CommandText = "update NganhHoc set MaNganhhoc = N'" + txtIDNganhHoc.Text + "', TenNganhHoc = N'" + txtTenNganhHoc.Text + "' where MaNganhhoc = N'" + txtIDNganhHoc.Text + "'";
                    command.ExecuteNonQuery();
                    loadDataNH();
                }
                else
                {
                    MessageBox.Show("Mã ngành không được thay đổi", "Thông báo");
                }
            }
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            txtIDNganhHoc.ReadOnly = false;
            txtTenNganhHoc.ReadOnly = false;
            txtIDNganhHoc.Text = "";
            txtTenNganhHoc.Text = "";
        }

        private void dataGridViewNH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtIDNganhHoc.ReadOnly = true;
            //txtTenNganhHoc.ReadOnly = true;
            int i;
            i = dataGridViewNH.CurrentRow.Index;
            txtIDNganhHoc.Text = dataGridViewNH.Rows[i].Cells[0].Value.ToString();
            txtTenNganhHoc.Text = dataGridViewNH.Rows[i].Cells[1].Value.ToString();
            cbNganhHoc.Text = dataGridViewNH.Rows[i].Cells[0].Value.ToString();
            loadDataSV();
        }
        // Lựa chọn thêm sửa, xóa, xóa trắng Ngành Học - end


        // Lựa chọn thêm sửa, xóa, xóa trắng, thêm điểm, quản lý sinh viên - start
        public bool ktraMaSV(string maSV)
        {
            connection.Open();
            string sql = "select MaSV from SinhVien where maSV = '" + maSV + "'";
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

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            if (txtMSV.Text == "" || txtTenSV.Text == "" || cbNganhHoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường", "Thông báo");
            }

            else
            {
                connection.Close();
                if (ktraMaSV(txtMSV.Text) == true)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại", "Thông báo");

                }
                else
                {
                    connection.Open();
                    var cmd = new SqlCommand();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "insert into SinhVien values(N'" + txtMSV.Text + "', N'" + txtTenSV.Text + "', N'" + cbNganhHoc.Text + "', '" + null + "')";
                    cmd.ExecuteNonQuery();
                    loadDataSV();
                }
            }
        }

        private void btnRepairSV_Click(object sender, EventArgs e)
        {
            if (txtMSV.Text == "" || txtTenSV.Text == "" || cbNganhHoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường", "Thông báo");
            }

            else
            {
                var cmd = new SqlCommand();
                cmd = connection.CreateCommand();
                cmd.CommandText = "update  SinhVien set TenSV = N'" + txtTenSV.Text + "' where MaSV = N'" + txtMSV.Text + "'";
                cmd.ExecuteNonQuery();
                loadDataSV();
            }
        }

        private void btnDeleteSV_Click(object sender, EventArgs e)
        {
            if (txtMSV.Text == "" || txtTenSV.Text == "" || cbNganhHoc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa", "Thông báo");
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn xóa sinh viên: " + txtTenSV.Text + " ", "Xác nhận",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    var cmd = new SqlCommand();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "delete from SinhVien where MaSV = N'" + txtMSV.Text + "'";
                    cmd.ExecuteNonQuery();
                    loadDataSV();
                }
            }
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            txtMSV.Enabled = true;
            cbNganhHoc.Enabled = true;
            txtMSV.Text = "";
            txtTenSV.Text = "";
        }

        private void btnThemDiem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnQLDiem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void btnAllStudents_Click(object sender, EventArgs e)
        {
            loadDataAllSV();
        }

        private void dataGridViewSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbNganhHoc.Enabled = false;
            txtMSV.Enabled = false;
            int j;
            j = dataGridViewSV.CurrentRow.Index;
            txtMSV.Text = dataGridViewSV.Rows[j].Cells[0].Value.ToString();
            txtTenSV.Text = dataGridViewSV.Rows[j].Cells[1].Value.ToString();
            cbNganhHoc.Text = dataGridViewSV.Rows[j].Cells[0].Value.ToString();
        }
        // Lựa chọn thêm sửa, xóa, xóa trắng, thêm điểm, quản lý sinh viên - end

        private void quanLyNganhHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Restart();
        }
    }
}
