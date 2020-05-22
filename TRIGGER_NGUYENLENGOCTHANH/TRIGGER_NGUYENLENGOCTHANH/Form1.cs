using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRIGGER_NGUYENLENGOCTHANH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ds_QLVT.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'ds_QLVT.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Fill(this.ds_QLVT.CTPN);
            // TODO: This line of code loads data into the 'ds_QLVT.PHIEUNHAP' table. You can move, or remove it, as needed.
                this.pHIEUNHAPTableAdapter.Fill(this.ds_QLVT.PHIEUNHAP);

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            bdsCTPN.AddNew();
        }

        private void BtnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                bdsCTPN.EndEdit();
                bdsCTPN.ResetCurrentItem();
                this.cTPNTableAdapter.Update(this.ds_QLVT.CTPN);
                MessageBox.Show("Ghi thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Câu hỏi. " + ex.Message, "Thông báo", MessageBoxButtons.OK);
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
