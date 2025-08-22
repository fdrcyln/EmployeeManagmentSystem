using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeFormTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            addEmployee1.Visible = true;
            salary1.Visible = false;
        }

        private void SalaryButton_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = true;
        }
    }
}
