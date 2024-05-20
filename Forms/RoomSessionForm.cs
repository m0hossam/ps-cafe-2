﻿using MaterialSkin.Controls;
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
            // TODO: This line of code loads data into the 'database1DataSet.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.database1DataSet.Session);
            // TODO: This line of code loads data into the 'database1DataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.database1DataSet.Room);

        }
    }
}
