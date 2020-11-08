using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using QuanLySinhVien.BS_layer;

namespace QuanLySinhVien
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {

        string err;
        public static string strTenDangNhap = "";

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.ResetText();    
            }
            txtPass.Properties.UseSystemPasswordChar = true;
            if (txtUser.Text.Trim() == "")
            {
                
                txtUser.Text  = "Username";
            }
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.ResetText();
            }            
            if (txtPass.Text.Trim() == "")
            {
                txtPass.Properties.UseSystemPasswordChar = false;
                txtPass.Text = "Password";
            }
        }

        private void btnReHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // lấy class ở tầng kết nối
            BLQuanLy blND = new BLQuanLy();
            // lấy dữ liệu từ tầng nghiệp vụ từ class kiểm trả tài khoản có đúng hay không
            int value = blND.DangNhapQuanLy(this.txtUser.Text.Trim(), this.txtPass.Text.Trim(), ref err);
            if (value == 1)
            {
                frmMain.bIsLogin = true;
                strTenDangNhap = txtUser.Text.Trim();
                Close();
            }
            else
            {
                MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!",
                    "Thông báo");
                this.txtUser.Focus();
            }
        }

        private void txtUser_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(null, null);
            }
        }
    }
}