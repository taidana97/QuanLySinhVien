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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        string err;

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            BLQuanLy blPassCu = new BLQuanLy();
            string strLayPass = blPassCu.SelectPassCu(frmDangNhap.strTenDangNhap, ref err);
            if (frmMain.bIsLogin == true)
            {
                if (txtPassCu.Text == strLayPass)
                {
                    if (txtPassNew.Text == txtConfirmNewPass.Text)
                    {
                        BLQuanLy blQL = new BLQuanLy();
                        blQL.DoiMatKhauQuanLy(frmDangNhap.strTenDangNhap, txtPassNew.Text, ref err);

                        lbThongBao.Text = "Bạn đã đổi mật khẩu thành công!";
                        txtPassCu.ResetText();
                        txtPassNew.ResetText();
                        txtConfirmNewPass.ResetText();
                    }
                    else
                    {
                        lbThongBao.Text = "Mật khẩu mới và Gõ lại mật khẩu mới không trùng khớp";
                    }

                }
                else
                {
                    lbThongBao.Text = "Mật khẩu cũ sai";
                }
            }
        }
    }
}