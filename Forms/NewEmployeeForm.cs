using MaterialSkin.Controls;
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
    public partial class NewEmployeeForm : MaterialForm
    {
        public NewEmployeeForm()
        {
            InitializeComponent();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.InsertEmployee(
                nameTextBox.Text,
                (maleRadioBtn.Checked ? maleRadioBtn.Text : femaleRadioBtn.Text),
                (double)salaryNumericUpDown.Value,
                usernameTextBox.Text,
                passwordTextBox.Text
                );
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void NewEmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.database1DataSet.Employee);

        }
    }
}
