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
    public partial class OrderForm : MaterialForm
    {
        int billId;
        public OrderForm(int billId)
        {
            InitializeComponent();
            this.billId = billId;
        }

        private void itemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ItemBill' table. You can move, or remove it, as needed.
            this.itemBillTableAdapter.Fill(this.database1DataSet.ItemBill);
            // TODO: This line of code loads data into the 'database1DataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.database1DataSet.Item);

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if(this.itemBillTableAdapter.GetNumberOfItemBills(int.Parse(idTextBox.Text), billId)>= 1)
            {
                this.itemBillTableAdapter.UpdateItemBill(int.Parse(idTextBox.Text), billId, int.Parse(numericUpDown.Value.ToString()));
            }
            else
            {
                this.itemBillTableAdapter.InsertItemBill(int.Parse(idTextBox.Text), billId, int.Parse(numericUpDown.Value.ToString()));
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new HomeForm(Utilities.username));
        }
    }
}
