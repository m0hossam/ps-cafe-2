using MaterialSkin.Controls;
using ps_cafe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDB.Forms
{
    public partial class EmployeeForm : MaterialForm
    {
        string username;
        public EmployeeForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.database1DataSet.Employee);
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new NewEmployeeForm(username));
        }

        private void removeEmployeeButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.DeleteEmployee(usernameLabel.Text);
        }

        private void updateSalaryButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.UpdateEmployeeSalary((double)salaryNumericUpDown.Value, usernameLabel.Text, int.Parse(idLabel.Text));
            MessageBox.Show("Salary Updated Successfully");
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.UpdateEmployeePassword(passwordTextBox.Text, usernameLabel.Text, int.Parse(idLabel.Text));
            MessageBox.Show("Salary Updated Successfully");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new HomeForm(username));
        }
    }
}
