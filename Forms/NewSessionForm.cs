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
    public partial class NewSessionForm : MaterialForm
    {
        private int roomId;
        public NewSessionForm(int roomId)
        {
            InitializeComponent();
            this.roomId = roomId;
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void NewSessionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.database1DataSet.Session);
            // TODO: This line of code loads data into the 'database1DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.database1DataSet.Employee);

        }

        private void employeeBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void newSessionBtn_Click(object sender, EventArgs e)
        {
            if (endTimeDateTimePicker.Value <= DateTime.Now)
            {
                MessageBox.Show("Please pick a datetime later than the current datetime!");
                return;
            }
            this.sessionTableAdapter.InsertSession(
                consoleComboBox.SelectedItem.ToString(),
                gameComboBox.SelectedItem.ToString(),
                DateTime.Now,
                endTimeDateTimePicker.Value,
                roomId
                );
        }
    }
}
