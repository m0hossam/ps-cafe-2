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
    public partial class RoomSessionForm : MaterialForm
    {
        private int roomId;
        private string shiftEmployeeUsername;

        public RoomSessionForm(int roomId, string shiftEmployeeUsername)
        {
            InitializeComponent();
            this.roomId = roomId;
            this.shiftEmployeeUsername = shiftEmployeeUsername;

            string isAvailable = this.roomTableAdapter.GetRoomById(this.roomId).Rows[0]["IsAvailable"].ToString();
            if (isAvailable == "True")
            {
                roomAvailabilityLabel.Text = "AVAILABLE";
                startTimeLabel.Visible = false;
                endTimeLabel.Visible = false;
                gameConsoleLabel.Visible = false;
                gameLabel.Visible = false;
            }
            else
            {
                int sessionId = int.Parse(this.sessionTableAdapter.GetMaxId(roomId).ToString());
                Database1DataSet.SessionDataTable sessionDataTable = this.sessionTableAdapter.GetSessionById(sessionId);
                roomAvailabilityLabel.Text = "UNAVAILABLE";
                gameConsoleLabel.Text = sessionDataTable.Rows[0]["GameConsole"].ToString();
                gameLabel.Text = sessionDataTable.Rows[0]["Game"].ToString();
                startTimeLabel.Text = sessionDataTable.Rows[0]["StartTime"].ToString();
                endTimeLabel.Text = sessionDataTable.Rows[0]["EndTime"].ToString();
            }
        }

        private void roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void RoomSessionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.database1DataSet.Bill);
            // TODO: This line of code loads data into the 'database1DataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.database1DataSet.Session);
            // TODO: This line of code loads data into the 'database1DataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.database1DataSet.Room);

        }

        private void backHomeBtn_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new HomeForm(shiftEmployeeUsername));
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            int sessionId = int.Parse(this.sessionTableAdapter.GetMaxId(roomId).ToString());
            int billId = int.Parse(this.billTableAdapter.GetMaxIdBySessionId(sessionId).ToString());
            Utilities.ChangeForm(this, new OrderForm(billId));
        }

        private void finishSessionBtn_Click(object sender, EventArgs e)
        {
            this.roomTableAdapter.UpdateRoom(true, roomId, roomId);
            int sessionId = int.Parse(this.sessionTableAdapter.GetMaxId(roomId).ToString());
            int billId = int.Parse(this.billTableAdapter.GetMaxIdBySessionId(sessionId).ToString());
            Database1DataSet.SessionDataTable sessionDataTable = this.sessionTableAdapter.GetSessionById(sessionId);
            DateTime start = DateTime.Parse(sessionDataTable.Rows[0]["StartTime"].ToString());
            DateTime end = DateTime.Parse(sessionDataTable.Rows[0]["EndTime"].ToString());
            float sessionPrice = (float)end.Subtract(start).TotalHours * Utilities.ONE_HOUR_PRICE;
            this.billTableAdapter.CalculateBillTotalAmount(billId, sessionPrice);

            this.tableAdapterManager.UpdateAll(this.database1DataSet);
            Utilities.ChangeForm(this, new BillForm(billId));
        }
    }
}
