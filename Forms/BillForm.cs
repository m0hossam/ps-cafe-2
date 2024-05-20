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
    public partial class BillForm : MaterialForm
    {
        int sessionId, billId;

        private void billBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.billBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ItemBill' table. You can move, or remove it, as needed.
            this.itemBillTableAdapter.Fill(this.database1DataSet.ItemBill);
            // TODO: This line of code loads data into the 'database1DataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.database1DataSet.Bill);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new HomeForm(Utilities.username));
        }

        public BillForm(int billId)
        {
            InitializeComponent( );

            priceLabel.Text = this.billTableAdapter.GetBillById(billId).Rows[0]["TotalAmount"].ToString();

            this.itemBillTableAdapter.FillBillItems(this.database1DataSet.ItemBill, billId);
            
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
            this.itemBillTableAdapter.Fill(this.database1DataSet.ItemBill);
        }





    }
}
