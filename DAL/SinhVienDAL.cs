using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
        public class SinhVienDAL
        {
            // Lấy toàn bộ danh sách sinh viên
            public List<Student> DanhSach()
            {
                using (var context = new AppDbConText())
                {
                    return context.Students.ToList();
                }
            }

            // Thêm sinh viên
            public void Them(Student sv)
            {
                using (var context = new AppDbConText())
                {
                    context.Students.Add(sv);
                    context.SaveChanges();
                }
            }

            // Sửa sinh viên
            public void Sua(int id, string hoTen, double diem)
            {
                using (var context = new AppDbConText())
                {
                    Student sv = context.Students.Find(id);

                    if (sv == null)
                        throw new System.Exception("Không tìm thấy sinh viên!");

                    sv.FullName = hoTen;
                    sv.Grade = diem;

                    context.SaveChanges();
                }
            }

            // Xóa sinh viên
            public void Xoa(int id)
            {
                using (var context = new AppDbConText())
                {
                    Student sv = context.Students.Find(id);

                    if (sv == null)
                        throw new System.Exception("Không tìm thấy sinh viên!");

                    context.Students.Remove(sv);
                    context.SaveChanges();
                }
            }

            // Lọc sinh viên có điểm từ 5 trở lên, điểm giảm dần
            public List<Student> LocSinhVien()
            {
                using (var context = new AppDbConText())
                {
                    return context.Students
                        .Where(sv => sv.Grade >= 5)
                        .OrderByDescending(sv => sv.Grade)
                        .ToList();
                }
            }
        }
    }
