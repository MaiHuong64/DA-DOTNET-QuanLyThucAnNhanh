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

namespace giaodien
{
    public partial class frmOrder : Form
    {
        // Tạo delegate cho sự kiện
        public delegate void SKLoadDH(object sender, EventArgs e);
        // Khai báo
        public event SKLoadDH DH;

        // Gọi sự kiện khi có chi tiết đơn mới 
        public void LoadDH()
        {
            if (DH != null)
            {
                // Tạo sự kiện để truyền thông tin 
                DH(this, EventArgs.Empty);
            }

        }
        public void LoadData()
        {
            using (SqlConnection conn = Ketnoi.getConnection())
            {

                string query = @"select c.mactdh, c.makh, k.tenkh, k.diachi, k.sdt, da.mada, da.tenda, c.soluong, c.dongia, c.thanhtien, c.ghichu, c.loaidh
                                from chitietdonhang c inner join doan da on c.mada = da.mada
					            inner join donhang d on c.mactdh = d.madh
					            inner join khachhang k on c.makh = k.makh";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataOrders.DataSource = dataTable;
                dataOrders.Columns["mactdh"].HeaderText = "Mã đơn hàng";
                dataOrders.Columns["makh"].HeaderText = "Mã khách hàng";
                dataOrders.Columns["tenkh"].HeaderText = "Tên khách hàng";
                dataOrders.Columns["diachi"].HeaderText = "Dia chi";
                dataOrders.Columns["sdt"].HeaderText = "So dien thoai";
                dataOrders.Columns["mada"].HeaderText = "Mã sản phẩm";
                dataOrders.Columns["tenda"].HeaderText = "Tên sản phẩm";
                dataOrders.Columns["soluong"].HeaderText = "Số lượng";
                dataOrders.Columns["dongia"].HeaderText = "Đơn giá";
                dataOrders.Columns["thanhtien"].HeaderText = "Thành tiền";
                dataOrders.Columns["ghichu"].HeaderText = "Ghi chú";
                dataOrders.Columns["loaidh"].HeaderText = "Loại đơn hàng";

                dataOrders.Columns["makh"].Visible = false;
                dataOrders.Columns["mada"].Visible = false;
            }
        }

        public void loadCBBSP()
        {
            string query = @"select da.mada, da.tenda from doan da ";
            cbbSP.DataSource = Ketnoi.getData(query);
            cbbSP.DisplayMember = "tenda";
            cbbSP.ValueMember = "mada";

            txtMaSP.Text = cbbSP.SelectedValue.ToString();
            lbDongia.Text = DonGia(txtMaSP.Text).ToString();
        }
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadData();
            loadCBBSP();
            txtMaSP.ReadOnly = true;
            //txtTenNV.Text = Login.name;
            //txtMaNV.Text = Login.id;
            cmbLoaiDH.Items.Add("Tại quầy");
            cmbLoaiDH.Items.Add("Online");
            cmbLoaiDH.SelectedItem = "Tại quầy";
        }
        // Tính thành tiền
        public decimal Tinhtien(int sl, decimal dongia)
        {
            decimal total = 0;
            total = sl * dongia;
            return total;
        }

        // lấy giá tiền
        public decimal DonGia(string mada)
        {
            decimal price = 0;
            string query = @"select da.dongia
                             from doan da 
                             where da.mada = @mada";
            using (SqlConnection conn = Ketnoi.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mada", cbbSP.SelectedValue.ToString());
                conn.Open();
                //cmd.ExecuteNonQuery();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        price = reader.GetDecimal(0);
                    }
                }
                conn.Close();
            }
            return price;
        }
        //Kiểm tra trùng mã hóa đơn và mã sản phẩm
        public int ktTrung(string mactdh, string mada)
        {
            // Đếm số lượng masp và madh có trong data
            string query = @"select count(*)
                                from  chitietdonhang c
                             where c.mactdh = @mactdh and c.mada = @mada";
            using (SqlConnection conn = Ketnoi.getConnection())
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@mactdh", mactdh);
                command.Parameters.AddWithValue("@mada", mada);
                conn.Open();
                // Doc cot dau tien cua truy van
                int res = Convert.ToInt32(command.ExecuteScalar());
                //Console.WriteLine($"ktTrung({madh}, {masp}) = {res}");
                conn.Close();
                return res > 0 ? 1 : -1;
            }

        }
        //Lấy id khách hàng
        public string getIDCustomer(string name)
        {
            string query = @"select makh from khachhang where tenkh = @name";
            using (SqlConnection con = Ketnoi.getConnection())
            {

                SqlCommand sqlCommand = new SqlCommand(query, con);
                sqlCommand.Parameters.AddWithValue("@name", name);
                con.Open();
                var res = sqlCommand.ExecuteScalar();
                //Console.WriteLine(res);
                con.Close();
                if (res != null)
                    return res.ToString();
                return null;
            }
        }
        public void ThemKHMoi(string id, string name, string address, string phonnumber)
        {
            string queryThemKH = @"insert into khachhang values(@makh, @tenkh, @diachi, @sdt)";
            using (SqlConnection con = Ketnoi.getConnection())
            {
                SqlCommand cmd = new SqlCommand(queryThemKH, con);
                cmd.Parameters.AddWithValue("@makh", id);
                cmd.Parameters.AddWithValue("@tenkh", name);
                cmd.Parameters.AddWithValue("@diachi", address);
                cmd.Parameters.AddWithValue("@sdt", phonnumber);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thêm khách hàng mới vào hệ thống");
            }
        }
        public bool checkOrderExist(string madh)
        {
            string query = @"select count(*) from donhang where madh = @mactdh";
            using (SqlConnection conn = Ketnoi.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mactdh", madh);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();
                return count > 0;
            }
        }
        public void ThemDHMoi(string id)
        {
            string query = @"insert into donhang values (@madh)";
            using (SqlConnection conn = Ketnoi.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@madh", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaDH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã đơn hàng");
                txtMaDH.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng");
                txtTenKH.Focus();
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int soluong = (int)(numSL.Value);
            decimal dongia = DonGia(cbbSP.SelectedValue.ToString());
            decimal thanhtien = Tinhtien(soluong, dongia);

            string idKH = txtMaKH.Text;
            string tenkh = txtTenKH.Text;
            string diachi = txtDiachi.Text;
            string sdt = txtSDT.Text;

            if (!CheckInput()) return;

            try
            {
                if (!checkOrderExist(txtMaDH.Text))
                {
                    ThemDHMoi(txtMaDH.Text);
                    MessageBox.Show("Đơn hàng mới đã được tạo");
                }
                if (getIDCustomer(tenkh) == null)
                {
                    ThemKHMoi(idKH, tenkh, diachi, sdt);
                    //MessageBox.Show("Them khach hang moi thanh cong");
                }
                if (ktTrung(txtMaDH.Text, txtMaSP.Text) == -1)
                {
                    string query = @"insert into chitietdonhang values (@mactdh, @makh, @mada, @soluong, @dongia, @thanhtien, @ghichu, @loaidh)";

                    using (SqlConnection conn = Ketnoi.getConnection())
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@mactdh", txtMaDH.Text);
                            cmd.Parameters.AddWithValue("@makh", txtMaKH.Text);
                            cmd.Parameters.AddWithValue("@mada", txtMaSP.Text);
                            cmd.Parameters.AddWithValue("@soluong", soluong);
                            cmd.Parameters.AddWithValue("@dongia", dongia);
                            cmd.Parameters.AddWithValue("@thanhtien", thanhtien);
                            cmd.Parameters.AddWithValue("@ghichu", txtNote.Text);
                            cmd.Parameters.AddWithValue("@loaidh", cmbLoaiDH.SelectedItem.ToString());
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            LoadData();
                            MessageBox.Show("Thêm đơn mới thành công");
                            LoadDH();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message); Console.WriteLine(ex.Message);
                        }
                    }
                }
                else
                {
                    string query = @"update chitietdonhang
                                set soluong = soluong + @soluong, dongia = @dongia, thanhtien = @thanhtien
                                where mactdh = @mactdh and mada = @mada";
                    using (SqlConnection conn = Ketnoi.getConnection())
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@mactdh", txtMaDH.Text);
                            cmd.Parameters.AddWithValue("@mada", txtMaSP.Text);
                            cmd.Parameters.AddWithValue("@soluong", soluong);
                            cmd.Parameters.AddWithValue("@dongia", dongia);
                            cmd.Parameters.AddWithValue("@thanhtien", thanhtien);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            LoadData();
                            MessageBox.Show("Đơn hàng đã được cập nhật");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co muon xoa khong ", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                string query = @"delete from chitietdonhang  where mactdh = @mactdh and mada = @mada";
                using (SqlConnection conn = Ketnoi.getConnection())
                {
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@mactdh", txtMaDH.Text);
                    command.Parameters.AddWithValue("@mada", txtMaSP.Text);
                    conn.Open();
                    command.ExecuteNonQuery();
                    LoadData();
                }
            }
        }

        private void cbbSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSP.SelectedValue != null)
            {
                txtMaSP.Text = cbbSP.SelectedValue.ToString();
                lbDongia.Text = DonGia(txtMaSP.Text).ToString();
            }
        }

        private void numSL_ValueChanged(object sender, EventArgs e)
        {
            int sl = (int)numSL.Value;
            decimal dg = DonGia(txtMaSP.Text);
            lbTT.Text = Tinhtien(sl, dg).ToString();
        }

        private void dataOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataOrders.Rows[e.RowIndex];
            if (row != null)
            {
                txtMaDH.Text = row.Cells["mactdh"].Value.ToString();
                txtMaKH.Text = row.Cells["makh"].Value.ToString();
                txtTenKH.Text = row.Cells["tenkh"].Value.ToString();
                txtDiachi.Text = row.Cells["diachi"].Value.ToString();
                txtMaSP.Text = row.Cells["mada"].Value.ToString();
                cbbSP.SelectedItem = row.Cells["tenda"].Value.ToString();
                numSL.Value = Convert.ToInt32(row.Cells["soluong"].Value.ToString());
                lbDongia.Text = row.Cells["dongia"].Value.ToString();
                lbTT.Text = row.Cells["thanhtien"].Value.ToString();
                txtNote.Text = row.Cells["ghichu"].Value.ToString();
            }
        }
    }
}
