using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{
    internal class Ketnoi
    {
        public static string connect = @"Data Source=ADMIN-PC\H;Initial Catalog=H;Integrated Security=True";

        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(connect);
            return conn;
        }
        public static DataTable getData(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = getConnection())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    adapter.Fill(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return data;
        }
    }
}
