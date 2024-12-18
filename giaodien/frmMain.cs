using System;
using System.Windows.Forms;

namespace giaodien
{
    public partial class frmMain : Form
    {
        frmHoadon hoadon;
        frmOrder order;
        frmThucan sp;
        frmHome home;
        public frmMain()
        {
            InitializeComponent();
            DisplayForm();  
        }
        public void DisplayForm()
        {
            hoadon = new frmHoadon();
            order = new frmOrder();
            sp = new frmThucan();
            home = new frmHome();

            hoadon.TopLevel = false;
            order.TopLevel = false;
            sp.TopLevel = false;
            home.TopLevel = false;

            pnDisplay.Controls.Add(hoadon);
            pnDisplay.Controls.Add(order);
            pnDisplay.Controls.Add(sp);
            pnDisplay.Controls.Add(home);

            hoadon.FormBorderStyle = FormBorderStyle.None;
            order.FormBorderStyle = FormBorderStyle.None;
            sp.FormBorderStyle = FormBorderStyle.None;
            home.FormBorderStyle = FormBorderStyle.None;

            hoadon.Dock = DockStyle.Fill;
            order.Dock = DockStyle.Fill;
            sp.Dock = DockStyle.Fill;
            home.Dock = DockStyle.Fill;
        }
        public void HiddenForm()
        {
            hoadon.Hide();
            order.Hide();
            sp.Hide();
            home.Hide();
        }
        private void lbHome_Click(object sender, EventArgs e)
        {
            HiddenForm();
            home.Show();
        }

        private void lbHD_Click(object sender, EventArgs e)
        {
            HiddenForm();
            hoadon.Show();
        }

        private void lbThucan_Click(object sender, EventArgs e)
        {
            HiddenForm();
            sp.Show();
        }
        private void lbOrder_Click(object sender, EventArgs e)
        {
            HiddenForm();
            order.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            home.Show();
        }
    }
}
