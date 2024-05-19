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
    public partial class BillLogForm : MaterialForm
    {
        string username;
        public BillLogForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void billBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.billBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void BillLogForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.database1DataSet.Bill);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Utilities.ChangeForm(this, new HomeForm(username));
        }
    }
}
