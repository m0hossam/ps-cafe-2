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
    public partial class RegisterForm : MaterialForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void employeeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.database1DataSet.Employee);

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            int? numberOfEmployees = this.employeeTableAdapter.GetNumberOfEmployees();
            if (numberOfEmployees.HasValue)
            {
                if (numberOfEmployees.Value > 0)
                {
                    MessageBox.Show("An Admin account has already been created!\nPlease login into your employee account.");
                    Utilities.ChangeForm(this, new LoginForm());
                    return;
                }
            }
            this.employeeTableAdapter.InsertEmployee(
                nameTextBox.Text,
                (maleRadioBtn.Checked ? maleRadioBtn.Text : femaleRadioBtn.Text),
                (double)salaryNumericUpDown.Value,
                usernameTextBox.Text,
                passwordTextBox.Text
                );

            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

            Utilities.ChangeForm(this, new LoginForm());
        }
    }
}
