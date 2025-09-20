using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Buoi3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbThanhToan.SelectedIndex = 0;
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            string listSP = "";
            foreach (var item in libSanPham.SelectedItems)
            {
                listSP += "\r\n - " + item.ToString();
            }
            txtThongTin.Clear();
            txtThongTin.Text = "Thông tin đơn hàng:" +
                "\r\nKhách hàng: " + txtKhachHang.Text +
                "\r\nSố điện thoại: " + txtSDT.Text +
                "\r\nSản phẩm đặt mua: " + listSP +
                "\r\nCách thanh toán: " + cmbThanhToan.SelectedItem.ToString()
            ;
        }

     
    }
}