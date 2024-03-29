using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms.StudentManagemntSystemAS3
{
    public partial class AddStudentForm : Form
    {
        bool isUpdate;
        Student student;
        public AddStudentForm(bool isUpdate, Student student)
        {
            InitializeComponent();
            this.isUpdate = isUpdate;
            this.student = student;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                addbtn.Text = "Update";
                idtxt.ReadOnly = true;
                idtxt.Text = student.StudentID.ToString();
                firstnametxt.Text = student.FirstName;
                lastnametxt.Text = student.LastName;
                agetxt.Text = student.Age.ToString();
                gendertxt.Text = student.Gender;
                classtxt.Text = student.Class;
                gradetxt.Text = student.Grade.ToString();
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            int id, age, grade;
            if (!int.TryParse(idtxt.Text, out  id))
            {
                MessageBox.Show("Invalid Student ID");
                return;
            }
            else if (!int.TryParse(agetxt.Text, out  age))
            {
                MessageBox.Show("Invalid Age");
                return;
            }
            else if (!int.TryParse(gradetxt.Text, out  grade))
            {
                MessageBox.Show("Invalid Grade");
                return;
            }
            Student newStudent = new Student(id, firstnametxt.Text, lastnametxt.Text, age, gendertxt.Text, classtxt.Text, grade);

            List<Student> students = StudentDB.GetStudents();
            students.Add(newStudent);
            StudentDB.SaveStudents(students);

            MessageBox.Show("Student added successfully");
            this.Close();


        }
    }
}
