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
    public partial class frmLogin : Form
    {
        public static string name = "";
        public static string id = "";
        public frmLogin()
        {
            InitializeComponent();
        }
        public string getName(string user)
        {
            string name = "";
            string query = @"select n.tennv
                             from nhanvien n, taikhoan t
                             where n.manv = t.matk and t.tentk = @user";
            using (SqlConnection conn = Ketnoi.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", user);
                conn.Open();
                name = (string)cmd.ExecuteScalar();
                Console.WriteLine(name);
            }
            return name;
        }
        public string getID(string user)
        {
            string id = "";
            string query = @"select n.manv
                             from nhanvien n, taikhoan t
                             where n.manv = t.matk and t.tentk = @user";
            using (SqlConnection conn = Ketnoi.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", user);
                conn.Open();
                id = (string)cmd.ExecuteScalar();
                Console.WriteLine(id);
            }
            return id;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string log = @"select tk.vaitro from taikhoan tk 
                           where tk.tentk = @user";
            string role = null;
            using (SqlConnection conn = Ketnoi.getConnection())
            {
                SqlCommand cmd = new SqlCommand(log, conn);
                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@pass", txtPass.Text);

                conn.Open();
                role = (string)cmd.ExecuteScalar();
                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                    txtUser.Focus();
                    return;
                }
                if (role == "admin")
                {
                    MessageBox.Show("Đăng nhập với vai trò admin");
                    frmHome home = new frmHome();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập với vai trò user");
                    frmHome home = new frmHome();
                    home.Show();
                    name = getName(txtUser.Text);
                    id = getID(txtUser.Text);
                    this.Hide();
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát chương trình","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if ( res  == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
