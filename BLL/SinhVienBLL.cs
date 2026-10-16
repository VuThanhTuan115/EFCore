using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class SinhVienBLL
    {
        private SinhVienDAL dal = new SinhVienDAL();

        public List<Student> DanhSach()
        {
            return dal.DanhSach();
        }

        public void Them(string hoTen, double diem)
        {
            if (string.IsNullOrWhiteSpace(hoTen))
                throw new System.Exception("Vui lòng nhập họ tên!");

            if (diem < 0 || diem > 10)
                throw new System.Exception("Điểm phải từ 0 đến 10!");

            Student sv = new Student
            {
                FullName = hoTen,
                Grade = diem
            };

            dal.Them(sv);
        }

        public void Sua(int id, string hoTen, double diem)
        {
            if (string.IsNullOrWhiteSpace(hoTen))
                throw new System.Exception("Vui lòng nhập họ tên!");

            if (diem < 0 || diem > 10)
                throw new System.Exception("Điểm phải từ 0 đến 10!");

            dal.Sua(id, hoTen, diem);
        }

        public void Xoa(int id)
        {
            dal.Xoa(id);
        }

        public List<Student> LocSinhVien()
        {
            return dal.LocSinhVien();
        }
    }
}
