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

namespace lienket_sql_qlnv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            textBox_idnv.Text = GenerateID();
        }
        private void LoadData()
        {
            try
            {
                SqlConnection con = Connection.getSqlConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from ttnhanvien", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại "+ex);
            }
        }
        private string GenerateID()
        {
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day.ToString();
            string hour = DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second.ToString();
            return year +month+day+hour+minute+second;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            try
            {
                textBox_idnv.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
                textBox_tennv.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
                textBox_luongnv.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                textBox_idnv.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            }
        }
        private void button_them_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connection.getSqlConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into ttnhanvien values (@ID , @Name, @Luong)",con);
            cmd.Parameters.AddWithValue("@ID",textBox_idnv.Text);
            cmd.Parameters.AddWithValue("@Name", textBox_tennv.Text);
            cmd.Parameters.AddWithValue("@Luong", double.Parse(textBox_luongnv.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            textBox_idnv.Text = GenerateID();
            MessageBox.Show("Thêm thành công");
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connection.getSqlConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Update ttnhanvien Set tennv = @Name,luong = @Luong Where idnv = @ID",con);
            cmd.Parameters.AddWithValue("@ID",textBox_idnv.Text);
            cmd.Parameters.AddWithValue("@Name", textBox_tennv.Text);
            cmd.Parameters.AddWithValue("@Luong", double.Parse(textBox_luongnv.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sửa thành công");
            LoadData();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connection.getSqlConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete ttnhanvien Where idnv = @ID",con);
            cmd.Parameters.AddWithValue("@ID",textBox_idnv.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Xóa thành công");
            LoadData();
        }

        private void button_tailai_Click(object sender, EventArgs e)
        {
            LoadData();
            textBox_idnv.Text = GenerateID();
            textBox_tennv.Clear();
            textBox_luongnv.Clear();
        }
    }
}
