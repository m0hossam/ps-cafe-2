namespace TestDB.Forms
{
    partial class BillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.database1DataSet = new TestDB.Database1DataSet();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTableAdapter = new TestDB.Database1DataSetTableAdapters.BillTableAdapter();
            this.tableAdapterManager = new TestDB.Database1DataSetTableAdapters.TableAdapterManager();
            this.itemBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBillTableAdapter = new TestDB.Database1DataSetTableAdapters.ItemBillTableAdapter();
            this.itemBillDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back = new MaterialSkin.Controls.MaterialButton();
            this.checkOutButton = new MaterialSkin.Controls.MaterialButton();
            this.priceLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBillDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.database1DataSet;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillTableAdapter = this.billTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ItemBillTableAdapter = this.itemBillTableAdapter;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.SessionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestDB.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemBillBindingSource
            // 
            this.itemBillBindingSource.DataMember = "ItemBill";
            this.itemBillBindingSource.DataSource = this.database1DataSet;
            // 
            // itemBillTableAdapter
            // 
            this.itemBillTableAdapter.ClearBeforeFill = true;
            // 
            // itemBillDataGridView
            // 
            this.itemBillDataGridView.AllowUserToAddRows = false;
            this.itemBillDataGridView.AllowUserToDeleteRows = false;
            this.itemBillDataGridView.AutoGenerateColumns = false;
            this.itemBillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemBillDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.itemBillDataGridView.DataSource = this.itemBillBindingSource;
            this.itemBillDataGridView.Location = new System.Drawing.Point(162, 89);
            this.itemBillDataGridView.Name = "itemBillDataGridView";
            this.itemBillDataGridView.ReadOnly = true;
            this.itemBillDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.itemBillDataGridView.Size = new System.Drawing.Size(443, 155);
            this.itemBillDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BillId";
            this.dataGridViewTextBoxColumn2.HeaderText = "BillId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "TotalPrice";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // back
            // 
            this.back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.back.Depth = 0;
            this.back.HighEmphasis = true;
            this.back.Icon = null;
            this.back.Location = new System.Drawing.Point(7, 405);
            this.back.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.back.MouseState = MaterialSkin.MouseState.HOVER;
            this.back.Name = "back";
            this.back.NoAccentTextColor = System.Drawing.Color.Empty;
            this.back.Size = new System.Drawing.Size(158, 36);
            this.back.TabIndex = 1;
            this.back.Text = "back";
            this.back.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.back.UseAccentColor = false;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkOutButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.checkOutButton.Depth = 0;
            this.checkOutButton.HighEmphasis = true;
            this.checkOutButton.Icon = null;
            this.checkOutButton.Location = new System.Drawing.Point(162, 262);
            this.checkOutButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.checkOutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.checkOutButton.Size = new System.Drawing.Size(98, 36);
            this.checkOutButton.TabIndex = 2;
            this.checkOutButton.Text = "Checkout";
            this.checkOutButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.checkOutButton.UseAccentColor = false;
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Depth = 0;
            this.priceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.priceLabel.Location = new System.Drawing.Point(498, 272);
            this.priceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(10, 19);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "0";
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.back);
            this.Controls.Add(this.itemBillDataGridView);
            this.Name = "BillForm";
            this.Text = "BillForm";
            this.Load += new System.EventHandler(this.BillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBillDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource billBindingSource;
        private Database1DataSetTableAdapters.BillTableAdapter billTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.ItemBillTableAdapter itemBillTableAdapter;
        private System.Windows.Forms.BindingSource itemBillBindingSource;
        private System.Windows.Forms.DataGridView itemBillDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private MaterialSkin.Controls.MaterialButton back;
        private MaterialSkin.Controls.MaterialButton checkOutButton;
        private MaterialSkin.Controls.MaterialLabel priceLabel;
    }
}