namespace TestDB.Forms
{
    partial class NewItemForm
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label priceLabel;
            this.database1DataSet = new TestDB.Database1DataSet();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new TestDB.Database1DataSetTableAdapters.ItemTableAdapter();
            this.tableAdapterManager = new TestDB.Database1DataSetTableAdapters.TableAdapterManager();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new MaterialSkin.Controls.MaterialButton();
            this.insertButton = new MaterialSkin.Controls.MaterialButton();
            this.updateButton = new MaterialSkin.Controls.MaterialButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.itemNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.numericUpDownUpdate = new System.Windows.Forms.NumericUpDown();
            this.back = new MaterialSkin.Controls.MaterialButton();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.database1DataSet;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ItemBillTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = this.itemTableAdapter;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.SessionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestDB.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AutoGenerateColumns = false;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.itemDataGridView.DataSource = this.itemBindingSource;
            this.itemDataGridView.Location = new System.Drawing.Point(6, 67);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.Size = new System.Drawing.Size(344, 141);
            this.itemDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteButton.Depth = 0;
            this.deleteButton.HighEmphasis = true;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(431, 79);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteButton.Size = new System.Drawing.Size(73, 36);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "delete";
            this.deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteButton.UseAccentColor = false;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.insertButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.insertButton.Depth = 0;
            this.insertButton.HighEmphasis = true;
            this.insertButton.Icon = null;
            this.insertButton.Location = new System.Drawing.Point(433, 223);
            this.insertButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.insertButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.insertButton.Name = "insertButton";
            this.insertButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.insertButton.Size = new System.Drawing.Size(71, 36);
            this.insertButton.TabIndex = 3;
            this.insertButton.Text = "insert";
            this.insertButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.insertButton.UseAccentColor = false;
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.updateButton.Depth = 0;
            this.updateButton.HighEmphasis = true;
            this.updateButton.Icon = null;
            this.updateButton.Location = new System.Drawing.Point(433, 354);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.updateButton.Size = new System.Drawing.Size(77, 36);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "update";
            this.updateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.updateButton.UseAccentColor = false;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(650, 72);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 4;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(694, 69);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(650, 98);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(694, 95);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(650, 124);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(694, 121);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 9;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(674, 223);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown.TabIndex = 10;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.AnimateReadOnly = false;
            this.itemNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemNameTextBox.Depth = 0;
            this.itemNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemNameTextBox.LeadingIcon = null;
            this.itemNameTextBox.Location = new System.Drawing.Point(529, 215);
            this.itemNameTextBox.MaxLength = 50;
            this.itemNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.itemNameTextBox.Multiline = false;
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(100, 50);
            this.itemNameTextBox.TabIndex = 11;
            this.itemNameTextBox.Text = "";
            this.itemNameTextBox.TrailingIcon = null;
            // 
            // numericUpDownUpdate
            // 
            this.numericUpDownUpdate.Location = new System.Drawing.Point(674, 370);
            this.numericUpDownUpdate.Name = "numericUpDownUpdate";
            this.numericUpDownUpdate.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownUpdate.TabIndex = 12;
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
            this.back.TabIndex = 13;
            this.back.Text = "back";
            this.back.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.back.UseAccentColor = false;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // NewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.numericUpDownUpdate);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.itemDataGridView);
            this.Name = "NewItemForm";
            this.Text = "NewItemForm";
            this.Load += new System.EventHandler(this.NewItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private Database1DataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private MaterialSkin.Controls.MaterialButton insertButton;
        private MaterialSkin.Controls.MaterialButton updateButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private MaterialSkin.Controls.MaterialTextBox itemNameTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDownUpdate;
        private MaterialSkin.Controls.MaterialButton back;
    }
}