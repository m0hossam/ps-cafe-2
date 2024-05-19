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
            roomIdLabel.Text = roomId.ToString();
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
