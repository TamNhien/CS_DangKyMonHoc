using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_DangKyMonHoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 2020; i <= 2025;  i++)
            {
                cbxNienKhoa.Items.Add(i.ToString());
            }
            cbxNienKhoa.SelectedIndex = 5;

            string[] lopArray =  ["Ứng dụng phần mềm 1", "Ứng dụng phần mềm 2", "Ứng dụng phần mềm 3", "Thiết kế đồ họa 1", "Thiết kế đồ họa 2", "Quản trị mạng 1", "Quản trị mạng 2"];

            foreach (var item in lopArray)
            {
                comboBox1.Items.Add(item);
            }
            rad1.Checked = true;
            clbMonHoc.Items.Add("Lập trình Win", CheckState.Checked);
            clbMonHoc.Items.Add("Lập trình Internet", CheckState.Checked);
            clbMonHoc.Items.Add("Mạng máy tính", CheckState.Unchecked);
            clbMonHoc.Items.Add("UML", CheckState.Checked);
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            string thongtin;
            thongtin = "Mã Số Sinh Viên: " + txtMSSV.Text;
            thongtin += "\nHọ và Tên: " + txtHovaTen.Text;
            thongtin += "\nNiên Khóa: " + cbxNienKhoa.SelectedItem;
            thongtin += "\nLớp: " + comboBox1.SelectedItem;

            string hocki = "";
            if (rad1.Checked)
            {
                hocki = rad1.Text;
            }
            else if (rad2.Checked)
            {
                hocki = rad2.Text;
            }
            else if (rad3.Checked)
            {
                hocki = rad3.Text;
            }
            else if (rad4.Checked)
            {
                hocki = rad4.Text;
            }
            thongtin += "\nĐã đăng kí hoc ki " + hocki + " các môn học sau:";

            int stt = 1;
            foreach (var item in clbMonHoc.CheckedItems)
            {
                thongtin += "\n" + stt + ". " + item.ToString();
                stt++;
            }
            MessageBox.Show(thongtin, "Thông tin sinh viên");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtHovaTen.ResetText();
            txtMSSV.ResetText();
            cbxLop.ResetText();
            comboBox1.ResetText();
            cbxNienKhoa.ResetText();
        }
    }
}
