using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ManHinhChinh : Form
    {
        ManHinhQuanLyDonDatHang _QLDDH = null;
        ManHinhQuanLyHoaDon _QLHD = null;
        ManHinhQuanLyLanNhapHang _QLLNH = null;
        ManHinhQuanLyNhaCungCap _QLNCC = null;
        ManHinhQuanLyNhanVien _QLNV = null;
        ManHinhQuanLyPhieuBaoHanh _QLPBH = null;
        ManHinhQuanLyDoiTra _QLDT = null;
        ManHinhQuanLyPhieuGiaoHang _QLPGH = null;
        ManHinhQuanLySanPham _QLSP = null;
        ManHinhQuanLyThanhVien _QLTV = null;
        ManHinhThongKe _TK = null;

        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void quanLyDonDatHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_QLDDH == null||!_QLDDH.Created)
            {
                _QLDDH = new ManHinhQuanLyDonDatHang();
                _QLDDH.MdiParent = this;
                _QLDDH.Show();
                return;
            }
            _QLDDH.Focus();
        }

        private void quanLyHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_QLHD == null || !_QLHD.Created)
            {
                _QLHD = new ManHinhQuanLyHoaDon();
                _QLHD.MdiParent = this;
                _QLHD.Show();
                return;
            }
            _QLHD.Focus();
        }

        private void quanLyLanNhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_QLLNH == null || !_QLLNH.Created)
            {
                _QLLNH = new ManHinhQuanLyLanNhapHang();
                _QLLNH.MdiParent = this;
                _QLLNH.Show();
                return;
            }
            _QLLNH.Focus();
        }

        private void quanLyNhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_QLNCC == null || !_QLNCC.Created)
            {
                _QLNCC = new ManHinhQuanLyNhaCungCap();
                _QLNCC.MdiParent = this;
                _QLNCC.Show();
                return;
            }
            _QLNCC.Focus();
        }

        private void quanLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_QLNV == null || !_QLNV.Created)
            {
                _QLNV = new ManHinhQuanLyNhanVien();
                _QLNV.MdiParent = this;
                _QLNV.Show();
                return;
            }
            _QLNV.Focus();
        }

        private void quanLyPhieuBaoHanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_QLPBH == null || !_QLPBH.Created)
            {
                _QLPBH = new ManHinhQuanLyPhieuBaoHanh();
                _QLPBH.MdiParent = this;
                _QLPBH.Show();
                return;
            }
            _QLPBH.Focus();
        }


        private void quanLyPhieuDoiTraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_QLDT == null || !_QLDT.Created)
            {
                _QLDT = new ManHinhQuanLyDoiTra();
                _QLDT.MdiParent = this;
                _QLDT.Show();
                return;
            }
            _QLDT.Focus();
        }

        private void quanLyPhieuGiaoHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_QLPGH == null || !_QLPGH.Created)
            {
                _QLPGH = new ManHinhQuanLyPhieuGiaoHang();
                _QLPGH.MdiParent = this;
                _QLPGH.Show();
                return;
            }
            _QLPGH.Focus();
        }

        private void quanLySanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_QLSP == null || !_QLSP.Created)
            {
                _QLSP = new ManHinhQuanLySanPham();
                _QLSP.MdiParent = this;
                _QLSP.Show();
                return;
            }
            _QLSP.Focus();
        }

        private void quanLyThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_QLTV == null || !_QLTV.Created)
            {
                _QLTV = new ManHinhQuanLyThanhVien();
                _QLTV.MdiParent = this;
                _QLTV.Show();
                return;
            }
            _QLTV.Focus();
        }

        private void thongKeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_TK == null || !_TK.Created)
            {
                _TK = new ManHinhThongKe();
                _TK.MdiParent = this;
                _TK.Show();
                return;
            }
            _TK.Focus();
        }
    }
}
