using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
 
using BUS_BH;
using System.Data.SqlClient;

namespace banahng3
{
    public partial class GDBanHang : Form
    {

        public GDBanHang()
        {
            InitializeComponent();
            hienthisanpham();
           // textBox5.Text = "1";
            //textBox3.Text = "1";
        }
        BUS_MATHANG sp = new BUS_MATHANG();
        MAT_HANG sp1 = new MAT_HANG();
        BUS_HOADON hd = new BUS_HOADON();
        HOA_DON hd1 = new HOA_DON();
        BUS_CHITIETHD ct = new BUS_CHITIETHD();
        CT_HOA_DON ct1 = new CT_HOA_DON();

        DataTable sp2 = new DataTable();

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView1.DataSource = sp.GetData("");
        }
        private void hienthisanpham()
        {
            dataGridView1.DataSource = sp.GetData("");
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox4.Text))
            {
                MessageBox.Show("Tạo hóa đơn mới ik rùi thêm");
                return;
            }
            else
            {
                ct1.MaHD = textBox4.Text;
                ct1.MaSP = textBox1.Text;
                ct1.SLBan = Convert.ToInt32(numericUpDown1.Value);
                try
                {
                    ct.AddData(ct1);
                 
                    MessageBox.Show("Lưu rùi !");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Không thể lưu được !");
                    MessageBox.Show(ex.Message);
                    
                    // fail = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "050-" + DateTime.Now.ToString("MMddHHmm");
            hd1.MaHD = textBox4.Text;
            hd1.NgayBan = DateTime.Now;
            try
            {
                hd.AddData(hd1);
                MessageBox.Show("Đã tạo !");
            }
            catch
            {
                MessageBox.Show("Không thể lưu được !");
                // fail = true;
            }
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            hd1.MaHD = textBox4.Text;
            hd1.NgayBan = DateTime.Now;
            try
            {
                hd.AddData(hd1);
                MessageBox.Show("Lưu rùi !");
            }
            catch
            {
                MessageBox.Show("Không thể lưu được !");
               // fail = true;
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hd.XemHoaDon(textBox4.Text);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView2.DataSource = hd.XemHoaDonThanhToan(textBox4.Text);
            textBox5.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sp.GetData("");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //tructiep
            hd.ThemTrucTiep(textBox4.Text);
            dataGridView2.DataSource = hd.XemHoaDonThanhToan(textBox4.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hd.ThemQuaThe(textBox4.Text);
            dataGridView2.DataSource = hd.XemHoaDonThanhToan(textBox4.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //textBox5.Text = hd.GetTongHoaDon(textBox4.Text).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            hd.HuyDon(textBox4.Text);
            hd.HuyChiTiet(textBox4.Text);
            MessageBox.Show("Đã Hủy Đơn");
        }
    }
}
