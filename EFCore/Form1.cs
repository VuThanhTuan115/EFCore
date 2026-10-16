
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace EFCore
{
    public partial class Form1 : Form
    {
        private SinhVienBLL bll = new SinhVienBLL();

        public Form1()
        {
            InitializeComponent();
        }

        // Tải danh sách khi mở form
        private async void Form1_Load(object sender, EventArgs e)
        {
            await TaiDanhSach();
        }

        // Hiển thị danh sách sinh viên
        private Task TaiDanhSach()
        {
            try
            {
                dgvSinhVien.AutoGenerateColumns = true;
                dgvSinhVien.DataSource = bll.DanhSach();

                lblQLySV.Text = "Danh sách sinh viên";
                lblQLySV.ForeColor = System.Drawing.Color.DarkGreen;
            }
            catch (Exception ex)
            {
                lblQLySV.Text = "Lỗi tải danh sách!";
                lblQLySV.ForeColor = System.Drawing.Color.Red;

                MessageBox.Show(
                    "Không tải được danh sách sinh viên!\n" + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return Task.CompletedTask;
        }

        // Chọn dòng để đưa dữ liệu lên ô nhập
        private void dgvSinhVien_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                txtHoTen.Text =
                    Convert.ToString(row.Cells["FullName"].Value);

                txtDiem.Text =
                    Convert.ToString(row.Cells["Grade"].Value);
            }
        }

        // Tải lại danh sách
        private async void btnTaiLai_Click(object sender, EventArgs e)
        {
            await TaiDanhSach();
        }

        // Thêm sinh viên
        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDiem.Text, out double diem))
            {
                MessageBox.Show("Điểm không hợp lệ!");
                return;
            }

            try
            {
                bll.Them(txtHoTen.Text, diem);

                MessageBox.Show("Thêm sinh viên thành công!");

                txtHoTen.Clear();
                txtDiem.Clear();

                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sinh viên: " + ex.Message);
            }
        }

        // Sửa sinh viên
        private async void bttSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow?.DataBoundItem is not Student sv)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                return;
            }

            if (!double.TryParse(txtDiem.Text, out double diem))
            {
                MessageBox.Show("Điểm không hợp lệ!");
                return;
            }

            try
            {
                bll.Sua(sv.ID, txtHoTen.Text, diem);

                MessageBox.Show("Cập nhật thành công!");

                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa sinh viên: " + ex.Message);
            }
        }

        // Xóa sinh viên
        private async void bttXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow?.DataBoundItem is not Student sv)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                $"Bạn có chắc muốn xóa \"{sv.FullName}\"?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                bll.Xoa(sv.ID);

                MessageBox.Show("Xóa sinh viên thành công!");

                txtHoTen.Clear();
                txtDiem.Clear();

                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message);
            }
        }

        // Lọc sinh viên có điểm >= 5
        private void bttLoc_Click(object sender, EventArgs e)
        {
            try
            {
                List<Student> ketQua = bll.LocSinhVien();

                dgvSinhVien.DataSource = null;
                dgvSinhVien.DataSource = ketQua;

                lblQLySV.Text =
                    $"Tìm thấy {ketQua.Count} sinh viên đạt điểm >= 5.";

                lblQLySV.ForeColor = System.Drawing.Color.DarkGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lọc sinh viên: " + ex.Message);
            }
        }

        private void bttTai_Click(object sender, EventArgs e)
        {
            _ = TaiDanhSach();
        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow?.DataBoundItem is Student sv)
            {
                txtHoTen.Text = sv.FullName;
                txtDiem.Text = sv.Grade.ToString();
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDiem_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
