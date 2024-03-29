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
    public partial class UpdateStudentForm : Form
    {
        private Student studentToUpdate;

        public UpdateStudentForm(Student student)
        {
            InitializeComponent();
            studentToUpdate = student;
        }

        private void UpdateStudentForm_Load_1(object sender, EventArgs e)
        {
            // Populate controls with student information
            idtxt.Text = studentToUpdate.StudentID.ToString();
            idtxt.ReadOnly = true;
            firstnametxt.Text = studentToUpdate.FirstName;
            lastnametxt.Text = studentToUpdate.LastName;
            agetxt.Text = studentToUpdate.Age.ToString();
            gendertxt.Text = studentToUpdate.Gender;
            classtxt.Text = studentToUpdate.Class;
            gradetxt.Text = studentToUpdate.Grade.ToString();
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            // Declare variables
            int id, age, grade;

            // Validate input fields and parse values
            if (!int.TryParse(idtxt.Text, out id))
            {
                MessageBox.Show("Invalid Student ID");
                return;
            }
            if (!int.TryParse(agetxt.Text, out age))
            {
                MessageBox.Show("Invalid Age");
                return;
            }
            if (!int.TryParse(gradetxt.Text, out grade))
            {
                MessageBox.Show("Invalid Grade");
                return;
            }

            // Update student information
            Student updatedStudent = new Student(id, firstnametxt.Text, lastnametxt.Text, age, gendertxt.Text, classtxt.Text, grade);

            // Update student in the database
            StudentDB.UpdateStudent(updatedStudent);
            MessageBox.Show("Student updated successfully");

            // Close the form
            this.Close();
        }
    }
}
