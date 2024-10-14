using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DAL.entities;
using System.Data.Entity;
using System.Reflection;
namespace GUI
{
    public partial class Form1 : Form
    {
        private StudentBUS studentBLL;
        private string imageName;
        private object picAvatar;

        private Model1 dbContext { get; set; }

        public Form1()
        {
            InitializeComponent();
            studentBLL = new StudentBUS();
            InitializeDataGridView();
            LoadComboBoxData();
            LoadStudentData();

        }

        private void LoadStudentData()
        {
            var studentList = studentBLL.GetAllStudents();
            BindGrid(studentList);
        }

        private void BindGrid(object studentList)
        {
            throw new NotImplementedException();
        }

        private void LoadComboBoxData()
        {
            var faculties = studentBLL.GetAllFaculties();
            cmbFaculty.DataSource = faculties;
            cmbFaculty.DisplayMember = "FacultyName";
            cmbFaculty.ValueMember = "FacultyID";

            // Load Major ComboBox
            var majors = studentBLL.GetAllMajors();
            cmbMajor.DataSource = majors;
            cmbMajor.DisplayMember = "Name";
            cmbMajor.ValueMember = "MajorID";
        }

        private void InitializeDataGridView()
        {
            dgvStudent.Columns.Add("MSSV", "Mã SV");
            dgvStudent.Columns.Add("HoTen", "Họ Tên");
            dgvStudent.Columns.Add("Khoa", "Khoa");
            dgvStudent.Columns.Add("DiemTB", "Điểm TB");
            dgvStudent.Columns.Add("ChuyenNganh", "Chuyên Ngành");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string studentID = txtMaSV.Text;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    studentBLL.DeleteStudent(studentID);
                    string imagesDirectory = "C:\\Users\\dell-pc\\source\\repos\\Images";
                    string avatarPath = Path.Combine(imagesDirectory, studentID + ".jpg");
                    if (File.Exists(avatarPath))
                    {
                        File.Delete(avatarPath);
                    }
                    avatarPath = Path.Combine(imagesDirectory, studentID + ".png");
                    if (File.Exists(avatarPath))
                    {
                        File.Delete(avatarPath);
                    }
                    LoadStudentData();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells["MSSV"].Value?.ToString() ?? "";
                txtTenSV.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
                cmbFaculty.Text = row.Cells["Khoa"].Value?.ToString() ?? "";
                txtDTB.Text = row.Cells["DiemTB"].Value?.ToString() ?? "";
                cmbMajor.Text = row.Cells["ChuyenNganh"].Value?.ToString() ?? "";

                string avatarFileName = row.Cells["MSSV"].Value?.ToString() + ".jpg";
                ShowAvatar(avatarFileName);
            }
        }

        private void ShowAvatar(string avatarFileName)
        {
            
        }
    }
}
