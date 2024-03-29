using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.StudentManagemntSystemAS3
{
    public partial class Form1 : Form
    {
        private static readonly string Path = @"D:\WinForms.StudentManagemntSystemAS3\WinForms.StudentManagemntSystemAS3\WinForms.StudentManagemntSystemAS3\user.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool UserValidation(string username, string password)
        {
            var userCredentials = (from line in File.ReadAllLines(Path)
                                   let parts = line.Split(',')
                                   select new { Username = parts[0], Password = parts[1] })
                                 .ToDictionary(user => user.Username, user => user.Password);

            if (userCredentials.ContainsKey(username) && userCredentials[username] == password)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            else if (UserValidation(username, password))
            {
                MessageBox.Show("Login Successful");
                StudentForm studentForm = new StudentForm();
                studentForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }

        }



    }
}
