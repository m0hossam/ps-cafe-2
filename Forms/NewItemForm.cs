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
    public partial class NewItemForm : MaterialForm
    {
        public NewItemForm()
        {
            InitializeComponent();
        }

        private void itemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void NewItemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.database1DataSet.Item);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.itemTableAdapter.DeleteItem(int.Parse(idTextBox.Text));
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            this.itemTableAdapter.InsertItem(itemNameTextBox.Text, (double)numericUpDown.Value);

            this.tableAdapterManager.UpdateAll(this.database1DataSet);
            this.itemTableAdapter.Fill(this.database1DataSet.Item);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new HomeForm(Utilities.username));
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            this.itemTableAdapter.UpdateItemPrice((double)numericUpDownUpdate.Value, int.Parse(idTextBox.Text), int.Parse(idTextBox.Text));
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
            this.itemTableAdapter.Fill(this.database1DataSet.Item);
        }
    }
}
