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
    public partial class OrderForm : MaterialForm
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void itemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.database1DataSet.Item);

        }
    }
}
