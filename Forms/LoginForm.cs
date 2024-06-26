﻿using MaterialSkin.Controls;
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
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            if(this.employeeTableAdapter.LogInValid(username, password).ToString() != "1")
            {
                MessageBox.Show("Error");
                return;
            }
            Utilities.username = username;
            Utilities.ChangeForm(this, new HomeForm(username));

        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.database1DataSet.Employee);

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new RegisterForm());
        }
    }
}
