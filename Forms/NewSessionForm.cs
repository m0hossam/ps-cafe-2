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
    public partial class NewSessionForm : MaterialForm
    {
        private int roomId;
        private string username;
        public NewSessionForm(int roomId, string username)
        {
            InitializeComponent();
            this.roomId = roomId;
            roomIdLabel.Text = roomId.ToString();
            this.username = username;
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
            this.roomTableAdapter.UpdateRoom(false, roomId, roomId);

            this.roomTableAdapter.Fill(this.database1DataSet.Room);
            this.roomBindingSource.EndEdit();
            this.sessionTableAdapter.Fill(this.database1DataSet.Session);
            this.sessionBindingSource.EndEdit();
            this.roomTableAdapter.Update(database1DataSet.Room);
            this.sessionTableAdapter.Update(database1DataSet.Session);
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

            int sessionId = int.Parse(this.sessionTableAdapter.GetMaxId(roomId).ToString());
            int employeeId = int.Parse(this.employeeTableAdapter.GetEmployeeByUsername(username).Rows[0]["Id"].ToString());
            try
            {
                this.billTableAdapter.InsertBill(sessionId, employeeId);

            } catch { 

            }
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

            Utilities.ChangeForm(this, new HomeForm(username));
        }

        private void NewSessionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.database1DataSet.Bill);
            // TODO: This line of code loads data into the 'database1DataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.database1DataSet.Room);

        }
    }
}
