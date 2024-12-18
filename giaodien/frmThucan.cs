using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{
    public partial class frmThucan : Form
    {
        public frmThucan()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = Ketnoi.getConnection())
                {
                    string query = @"select d.mada, d.tenda, l.tenloai, d.dongia, d.soluong, l.maloai
                             from doan d, loaidoan l
                             where d.maloai = l.maloai";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataFood.DataSource = dt;
                    LoadTable();
                    //dataFood.Columns["mada"].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadCBBSP()
        {
            try
            {
                using (SqlConnection con = Ketnoi.getConnection())
                {
                    string query = @"select *
                                    from loaidoan";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cbbLoai.DataSource = dt;
                    cbbLoai.DisplayMember = "tenloai";
                    cbbLoai.ValueMember = "maloai";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadTable()
        {
            dataFood.Columns["mada"].HeaderText = "Ma do an";
            dataFood.Columns["tenda"].HeaderText = "Ten do an";
            dataFood.Columns["tenloai"].HeaderText = "Loai do an";
            dataFood.Columns["dongia"].HeaderText = "Don gia";
            dataFood.Columns["mada"].HeaderText = "Ma do an";
            dataFood.Columns["soluong"].HeaderText = "So luong ton";
            dataFood.Columns["maloai"].HeaderText = "Ma loai";
        }
        private void frmThucan_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCBBSP();
        }
        public bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaDA.Text))
            {
                MessageBox.Show("Vui lonh nhapp ma");
                txtMaDA.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenDA.Text))
            {
                MessageBox.Show("Vui lonh nhapp ma ten");
                txtTenDA.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDG.Text))
            {
                MessageBox.Show("Vui lonh dongia");
                txtDG.Focus();
                return false;
            }
            return true;
        }
        public bool checkPrice(decimal price)
        {
            if (price <= 0)
            {
                MessageBox.Show("Vui long nhap don gia > 0");
                return false;
            }
            return true;
        }
        public bool checkIsNum(string num)
        {
            if (Regex.IsMatch(num, @"^\d+$"))
            {
                if (checkPrice(decimal.Parse(num)))
                    return true;
            }
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            if (!checkIsNum(txtDG.Text)) return;

            //Kiem tra do an ton tai
            try
            {
                string checkquery = @"select count(*) from doan where tenda = @tenda";
                using (SqlConnection con = Ketnoi.getConnection())
                {
                    SqlCommand cmd = new SqlCommand(checkquery, con);
                    cmd.Parameters.AddWithValue("tenda", txtTenDA.Text);
                    con.Open();
                    int res = (int)cmd.ExecuteScalar();
                    if (res > 0)
                    {
                        string update = @"update doan 
                                        set soluong = soluong + @soluong
                                        where tenda = @tenda";
                        SqlCommand command = new SqlCommand(update, con);
                        command.Parameters.AddWithValue("@tenda", txtTenDA.Text);
                        command.Parameters.AddWithValue("@soluong", (int)numSL.Value);
                        //con.Open();
                        command.ExecuteNonQuery();
                        LoadData();
                        MessageBox.Show("So luong da duoc cap nhat ");
                    }
                    else
                    {
                        string query = @"insert into doan values (@mada, @tenda, @dongia, @soluong, @maloai)";
                        SqlCommand command = new SqlCommand(query, con);
                        command.Parameters.AddWithValue("@mada", txtMaDA.Text);
                        command.Parameters.AddWithValue("@tenda", txtTenDA.Text);
                        command.Parameters.AddWithValue("@dongia", decimal.Parse(txtDG.Text));
                        command.Parameters.AddWithValue("@soluong", (int)numSL.Value);
                        command.Parameters.AddWithValue("@maloai", cbbLoai.SelectedValue);
                        //con.Open();
                        command.ExecuteNonQuery();
                        LoadData();
                        MessageBox.Show("Them mon thanh cong");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"update doan 
                                    set tenda = @tenda, dongia = @dongia, soluong = @soluong
                                    where mada = @mada";
                using (SqlConnection conn = Ketnoi.getConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@mada", txtMaDA.Text);
                    cmd.Parameters.AddWithValue("@tenda", txtTenDA.Text);
                    cmd.Parameters.AddWithValue("@dongia", txtDG.Text);
                    cmd.Parameters.AddWithValue("@soluong", (int)numSL.Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"select d.mada, d.tenda, l.tenloai, d.dongia, d.soluong, l.maloai
                             from doan d, loaidoan l
                             where d.maloai = l.maloai and d.tenda like @tenda";
                using (SqlConnection conn = Ketnoi.getConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tenda", "%" + txtTimkiem.Text + "%");
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataFood.DataSource = dataTable;
                    LoadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataFood.Rows[e.RowIndex];
            if (row != null)
            {
                txtMaDA.Text = row.Cells["mada"].Value.ToString();
                txtTenDA.Text = row.Cells["tenda"].Value.ToString();
                cbbLoai.SelectedItem = row.Cells["tenloai"].Value.ToString();
                txtDG.Text = row.Cells["dongia"].Value.ToString();
                numSL.Value = Int32.Parse(row.Cells["soluong"].Value.ToString());
            }
        }

        private void txtTimkiem_Leave(object sender, EventArgs e)
        {
            if (!txtTimkiem.Focused && txtTimkiem.Text.Trim() == string.Empty)
                txtTimkiem.Text = "Nhập tên món";
        }
    }
}
