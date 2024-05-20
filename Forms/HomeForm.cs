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
    public partial class HomeForm : MaterialForm
    {

        string username;
        string isAdmin;
        public HomeForm(string username)
        {
            InitializeComponent();
            this.username = username;
            this.isAdmin = this.employeeTableAdapter.GetEmployeeByUsername(this.username).Rows[0]["IsAdmin"].ToString();
        }

        private void roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.database1DataSet.Employee);
            // TODO: This line of code loads data into the 'database1DataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.database1DataSet.Room);

        }

        private void showInformationButton_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new RoomSessionForm(int.Parse(id.Text), username));
        }

        private void createNewSessionButton_Click(object sender, EventArgs e)
        {
            string IsAvailable = this.roomTableAdapter.GetRoomById(int.Parse(id.Text)).Rows[0]["IsAvailable"].ToString();
            if(IsAvailable == "True")
                Utilities.ChangeForm(this, new NewSessionForm(int.Parse(id.Text), username));
            else
                MessageBox.Show("Error");
        }

        private void showEmployeeButton_Click(object sender, EventArgs e)
        {
            if (isAdmin == "True")
                Utilities.ChangeForm(this, new EmployeeForm(username));
            else 
                MessageBox.Show("Error");
        }

        private void showBillLogButton_Click(object sender, EventArgs e)
        {
            if (isAdmin == "True")
                Utilities.ChangeForm(this, new BillLogForm(username));
            else
                MessageBox.Show("Error");
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new RegisterForm());
        }

        private void newRoomBtn_Click_1(object sender, EventArgs e)
        {
            if (isAdmin == "False")
            {
                MessageBox.Show("You have to be an admin to access this option!");
                return;
            }

            this.roomTableAdapter.InsertRoom();
            this.roomBindingSource.EndEdit();
            this.roomTableAdapter.Fill(this.database1DataSet.Room);
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
        }
    }
}
