using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace TRIGGER_NGUYENLENGOCTHANH
{
    public partial class formPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public formPhieuNhap()
        {
            InitializeComponent();
        }

        private Boolean isAddNew = false;

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_QLVT.VATTU' table. You can move, or remove it, as needed.
            this.vATTUTableAdapter.Fill(this.ds_QLVT.VATTU);
            ds_QLVT.EnforceConstraints = false;
            this.cTPNTableAdapter.Fill(this.ds_QLVT.CTPN);
            this.pHIEUNHAPTableAdapter.Fill(this.ds_QLVT.PHIEUNHAP);
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView2.OptionsBehavior.ReadOnly = true;
        }
        public Boolean validationInput()
        {
            if (txtMAVT.Text.Trim() == "")
            {
                MessageBox.Show("Mã VT không được thiếu.\n", "", MessageBoxButtons.OK);
                txtMAVT.Focus();
                return false;
            }
            if (txtDonGia.Text.Trim() == "")
            {
                MessageBox.Show("Đơn giá không được thiếu.\n", "", MessageBoxButtons.OK);
                txtDonGia.Focus();
                return false;
            }
            if (txtSL.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng không được thiếu.\n", "", MessageBoxButtons.OK);
                txtSL.Focus();
                return false;
            }
            return true;
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            this.bdsCTPN.AddNew();
            txtMAVT.ReadOnly = false;
            isAddNew = true;
        }

        private void BtnGhi_Click(object sender, EventArgs e)
        {
            if (isAddNew)
            {
                SqlConnection conn = new SqlConnection();
                SqlCommand sqlcmd = new SqlCommand();
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                try
                {
                    conn.ConnectionString = @"Data Source=THANH;Initial Catalog=QLVT;User ID=sa;Password=1234";
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + ex.Message, "", MessageBoxButtons.OK);
                }

                String str = "dbo.SP_CheckMaVTisExist";
                sqlcmd = conn.CreateCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = str;
                sqlcmd.Parameters.Add("@MAVT", SqlDbType.NChar).Value = txtMAVT.Text.Trim();
                sqlcmd.Parameters.Add("@LOAI", SqlDbType.NChar).Value = "PN";
                sqlcmd.Parameters.Add("@RET", SqlDbType.NChar).Direction = ParameterDirection.ReturnValue;
                sqlcmd.ExecuteNonQuery();
                String ret = sqlcmd.Parameters["@RET"].Value.ToString();

                if (ret == "1")
                {
                    txtMAVT.Focus();
                    MessageBox.Show("Mã vật tư không tồn tại, vui lòng nhập đúng", "Lỗi Ghi!", MessageBoxButtons.OK);
                    return;
                }
                if (ret == "2")
                {
                    txtMAVT.Focus();
                    MessageBox.Show("Mã vật tư đã tồn tại trong CTPN, vui lòng kiểm tra lại", "Lỗi Ghi!", MessageBoxButtons.OK);
                    return;
                }
            }
            if (MessageBox.Show("Bạn có chắc muốn ghi không?", "Ghi vào CTPN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Boolean checkValidation = validationInput();
                if (!checkValidation)
                {
                    return;
                }
                try
                {
                    bdsCTPN.EndEdit();
                    bdsCTPN.ResetCurrentItem();
                    this.cTPNTableAdapter.Update(this.ds_QLVT.CTPN);
                    if (isAddNew)
                    {
                        txtMAVT.ReadOnly = true;
                        isAddNew = false;
                    }
                    MessageBox.Show("Ghi thành công", "Thông báo ", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn vui lòng kiểm tra lại thông tin trứơc khi ghi \n" + "Lỗi: *" + ex.Message, "Lỗi Ghi!", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa không? ", "Thông báo ", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                try
                {
                    bdsCTPN.RemoveCurrent();
                    this.cTPNTableAdapter.Update(this.ds_QLVT.CTPN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo ", MessageBoxButtons.OK);
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            bdsCTPN.CancelEdit();
            this.pHIEUNHAPTableAdapter.Fill(this.ds_QLVT.PHIEUNHAP);
        }
    }
}