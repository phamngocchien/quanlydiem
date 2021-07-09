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
using ms =  Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace AppConnectData
{
    public partial class Form3 : Form
    {
        SqlConnection connection; // mở kết nối với database
        SqlCommand command; // tạo ra các đối tượng để có thể thức thi câu lệnh sql
        string str = "Data Source=PNC;Initial Catalog=QLNganhHoc;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadNH();
            loadMH();
            txtDiemTTK.Enabled = false;
            txtMSV.Enabled = false;
            txtTen.Enabled = false;

        }
        // load data - start
        void loadNH()
        {
            var cmdNH = new SqlDataAdapter("select MaNganhHoc, TenNganhHoc from NganhHoc", connection);
            var nh = new System.Data.DataTable();
            nh.Clear();
            cmdNH.Fill(nh);
            cbNganhHoc.DataSource = nh;
            cbNganhHoc.DisplayMember = "MaNganhHoc";
            cbNganhHoc.ValueMember = "TenNganhHoc";
            cbNganhHoc.DataSource = nh;
        }

        void loadMH()
        {
            var cmdNH = new SqlDataAdapter("select tenMH, maMH from MonHoc", connection);
            var mh = new DataTable();
            mh.Clear();
            cmdNH.Fill(mh);
            cbMonHoc.DisplayMember = "maMH";
            cbMonHoc.ValueMember = "tenMH";

            cbMonHoc.DataSource = mh;
        }

        void loadDataTT()
        {
            var TT = new SqlDataAdapter("select * from DiemMonHoc where maMH = '" + cbMonHoc.Text + "'", connection);
            DataTable table = new DataTable();
            table.Clear();
            TT.Fill(table);
            dataGridViewTTDiem.DataSource = table;
        }
        // load data - end


        // lựa chọn thêm, xóa sửa, tính điểm - start
        public bool ktraMaSV(string maSV, string maMH)
        {
            //connection.Open();
            string msv = "select MaSV from DiemMonHoc where MaSV = '" + maSV + "' AND maMH = '"+maMH+"'";
            //string mnh = "select MaNganhHoc from SinhVien where maSV = '" + maSV + "'";

            command = new SqlCommand(msv, connection);
            //command = new SqlCommand(mnh, connection);
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

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (cbNganhHoc.Text == "" || cbMonHoc.Text == "" || txtMSV.Text == "" || txtTen.Text == "" || txtDQT.Text == "" || txtDiemThi.Text == "" || txtDiemTTK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập các trường đầy đủ và nhấn tính điểm để thực hiện thêm điểm", "Thông báo");
            }
            else
            {
                if (ktraMaSV(txtMSV.Text, cbMonHoc.Text) == true /*&& ktraMaMH(cbMonHoc.Text) == true*/)
                {
                    connection.Open();

                    MessageBox.Show("Mã sinh viên này đã được chấm", "Thông báo");
                }
                else
                {
                    connection.Open();
                    var cmd = new SqlCommand();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "insert into DiemMonHoc values('" + cbMonHoc.Text + "', '" + txtMSV.Text + "', '" + txtDQT.Text + "', '" + txtDiemThi.Text + "', '" + txtDiemTTK.Text + "')";
                    cmd.ExecuteNonQuery();
                    loadDataTT();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtDQT.Text == "" || txtDiemThi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập các trường được nhập đầy đủ và nhấn tính điểm để thực hiện thêm điểm","Thông báo");
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "update DiemMonHoc set maMH = '" + cbMonHoc.Text + "', MaSV = '" + txtMSV.Text + "', diemQT = '" + txtDQT.Text + "', diemThi = '" + txtDiemThi.Text + "', diemTK = '" + txtDiemTTK.Text + "' where MaSV = '"+txtMSV.Text+"'";
                command.ExecuteNonQuery();
                loadDataTT();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtDQT.Text == "" || txtDiemThi.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên muốn xóa điểm", "Thông báo");
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn xóa điểm của sinh viên: " + txtTen.Text + "", "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    command = connection.CreateCommand();
                    command.CommandText = "delete from DiemMonHoc where maSV = '" + txtMSV.Text + "'";
                    command.ExecuteNonQuery();
                    loadDataTT();               
                }
            }
        }

        private void btnTinhDiem_Click(object sender, EventArgs e)
        {
            float diemQt = float.Parse(txtDQT.Text);
            float diemThi = float.Parse(txtDiemThi.Text);
            double diemTK = (0.3 * diemQt + 0.7 * diemThi);
            txtDiemTTK.Text = diemTK.ToString();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMSV.Text = "";
            txtTen.Text = "";
            txtDiemThi.Text = "";
            txtDQT.Text = "";
            txtDiemTTK.Text = "";
            cbMonHoc.Enabled = true;
        }
        // lựa chọn thêm, xóa sửa, tính điểm - end

        private void dataGridViewTTDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewTTDiem.CurrentRow.Index;
            cbMonHoc.Text = dataGridViewTTDiem.Rows[i].Cells[0].Value.ToString();
            txtMSV.Text = dataGridViewTTDiem.Rows[i].Cells[1].Value.ToString();
            txtTen.Text = dataGridViewTTDiem.Rows[i].Cells[2].Value.ToString();
            txtDQT.Text = dataGridViewTTDiem.Rows[i].Cells[3].Value.ToString();
            txtDiemThi.Text = dataGridViewTTDiem.Rows[i].Cells[4].Value.ToString();
            txtDiemTTK.Text = dataGridViewTTDiem.Rows[i].Cells[5].Value.ToString();
            cbMonHoc.Enabled = false;


        }
        private void dataGridViewSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewSV.CurrentRow.Index;
            txtMSV.Text = dataGridViewSV.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dataGridViewSV.Rows[i].Cells[1].Value.ToString();

        }


        // lấy danh sách sinh viên và điểm - start
        private void btnLayDSSV_Click(object sender, EventArgs e)
        {
            string nh = cbNganhHoc.Text;
            loadDataSV(nh);
            dataGridViewSV.AutoResizeRows();
            dataGridViewSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbNganhHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            string tenNH = "select TenNganhHoc from NganhHoc where MaNganhHoc = N'" + cbNganhHoc.Text + "'";
            command = new SqlCommand(tenNH, connection);
            using (SqlDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    txtTenNganhHoc.Text = (read["TenNganhHoc"].ToString());
                }
            }
        }

        void loadDataSV(string nh)
        {
            //var cmdNH = new SqlDataAdapter("select MaNganhHoc from NganhHoc where TenNganhHoc = '" + cbNganhHoc.Text + "'", connection);

            var b = new SqlDataAdapter("select maSV as 'Mã Sinh Viên', tenSV as 'Tên Sinh Viên' from SinhVien where MaNganhHoc = '" + nh + "'", connection);
            DataTable tableSV = new DataTable();
            tableSV.Clear();
            b.Fill(tableSV);
            dataGridViewSV.DataSource = tableSV;
        }
        private void btnDSDiem_Click(object sender, EventArgs e)
        {
            string maMH = cbMonHoc.Text;
            var b = new SqlDataAdapter("select maMH as 'Mã Môn Học', MaSV as 'Mã Sinh Viên', (select TenSV from SinhVien where MaSV = DiemMonHoc.MaSV) AS 'Tên Sinh Viên', diemQT as 'Điểm Quá Trình', diemThi as 'Điểm Thi', diemTK as 'Điểm Tổng Kết' from DiemMonHoc where maMH = '"+ maMH + "' order by diemTK", connection);
            DataTable tableSV = new DataTable();
            tableSV.Clear();
            b.Fill(tableSV);
            dataGridViewTTDiem.DataSource = tableSV;
            dataGridViewTTDiem.AutoResizeRows();
            dataGridViewTTDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = "select tenMH from MonHoc where maMH = N'" + cbMonHoc.Text + "'";
            command = new SqlCommand(a, connection);
            using (SqlDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    txtTenMonHoc.Text = (read["tenMH"].ToString());
                }
            }
        }
        // lấy danh sách sinh viên và điểm - end

        // In bảng điểm
        private void btnInDiem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application(); 
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing); 
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null; 
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet; 
            worksheet.Name = "Exported from gridview";
            for (int i = 1; i < dataGridViewTTDiem.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewTTDiem.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewTTDiem.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridViewTTDiem.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewTTDiem.Rows[i].Cells[j].Value.ToString();
                }
            }
            app.Quit();
            //Export2Excel(dataGridViewTTDiem);
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            string maMH = cbMonHoc.Text;
            var b = new SqlDataAdapter("select maMH as 'Mã Môn Học', MaSV as 'Mã Sinh Viên', (select TenSV from SinhVien where MaSV = DiemMonHoc.MaSV) AS 'Tên Sinh Viên', diemQT as 'Điểm Quá Trình', diemThi as 'Điểm Thi', diemTK as 'Điểm Tổng Kết' from DiemMonHoc where maMH = '" + maMH + "' order by MaSV", connection);
            DataTable tableSV = new DataTable();
            tableSV.Clear();
            b.Fill(tableSV);
            dataGridViewTTDiem.DataSource = tableSV;
            dataGridViewTTDiem.AutoResizeRows();
            dataGridViewTTDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }













        //public static void Export2Excel(DataGridView dgr)
        //{
        //    System.Globalization.CultureInfo old = System.Threading.Thread.CurrentThread.CurrentCulture;
        //    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        //    ms.Application exa = new ms.Application();
        //    ms.Workbook wb = exa.Application.Workbooks.Add(ms.XlSheetType.xlWorksheet);
        //    ms.Worksheet ws = (ms.Worksheet)exa.ActiveSheet;
        //    exa.Visible = true;
        //    for (int i = 0; i < dgr.Columns.Count; ++i)
        //    {
        //        ws.Cells[1, i + 1] = dgr.Columns[i].HeaderText;
        //    }
        //    ms.Range ran = ws.get_Range("a1", "z1");
        //    ran.Font.Bold = true;
        //    ran.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Navy);

        //    for (int i = 0; i < dgr.Rows.Count; ++i)
        //    {
        //        for (int j = 0; j < dgr.Columns.Count; ++j)
        //        {
        //             ws.Cells[i + 2, j + 1] = dgr[j, i].Value;
        //        }
        //    }
        //    ws.Columns.AutoFit();
        //    System.Threading.Thread.CurrentThread.CurrentCulture = old;
        //}
    }
}
