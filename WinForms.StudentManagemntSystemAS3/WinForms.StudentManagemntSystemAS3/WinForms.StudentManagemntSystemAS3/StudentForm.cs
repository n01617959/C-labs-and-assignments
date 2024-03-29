using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.StudentManagemntSystemAS3
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudent = new AddStudentForm(false, null);
            addStudent.ShowDialog();
            LoadLatestGridView();
        }

        public void LoadLatestGridView()
        {
            studentGridView.Rows.Clear();
            List<Student> studentlist = StudentDB.GetStudents();
            foreach (Student student in studentlist)
            {
                studentGridView.Rows.Add(student.StudentID, student.FirstName, student.LastName, student.Age, student.Gender, student.Class, student.Grade);
            }

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadLatestGridView();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (studentGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = studentGridView.SelectedRows[0].Index;
                Student selectedStudent = StudentDB.GetStudents()[selectedIndex];

                // Open the UpdateStudentForm with the selected student's information
                UpdateStudentForm updateStudentForm = new UpdateStudentForm(selectedStudent);
                updateStudentForm.ShowDialog();

                // Refresh grid view after updating student information
                LoadLatestGridView();
            }
            else
            {
                MessageBox.Show("No student selected. Please select a student to edit.");
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (studentGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = studentGridView.SelectedRows[0].Index;
                StudentDB.DeleteStudent(selectedIndex);
                LoadLatestGridView();
            }
            else
            {
                MessageBox.Show("Please select a student to delete");
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string search = searchtxt.Text;
            List<Student> studentlist = StudentDB.GetStudents();
            if (string.IsNullOrEmpty(search))
            {
                LoadLatestGridView();
                return;
            }
            else
            {
                var searchResult = studentlist.Where(s => s.StudentID.ToString().Contains(search) || s.FirstName.Contains(search) || s.LastName.Contains(search)).ToList();
                studentGridView.Rows.Clear();
                foreach (Student student in searchResult)
                {
                    studentGridView.Rows.Add(student.StudentID, student.FirstName, student.LastName, student.Age, student.Gender, student.Class, student.Grade);
                }
            }
            

        }
    }
}
