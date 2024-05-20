namespace TestDB.Forms
{
    partial class HomeForm
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
            this.roomDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new TestDB.Database1DataSet();
            this.showInformationButton = new MaterialSkin.Controls.MaterialButton();
            this.id = new System.Windows.Forms.Label();
            this.createNewSessionButton = new MaterialSkin.Controls.MaterialButton();
            this.showEmployeeButton = new MaterialSkin.Controls.MaterialButton();
            this.showBillLogButton = new MaterialSkin.Controls.MaterialButton();
            this.roomTableAdapter = new TestDB.Database1DataSetTableAdapters.RoomTableAdapter();
            this.tableAdapterManager = new TestDB.Database1DataSetTableAdapters.TableAdapterManager();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new TestDB.Database1DataSetTableAdapters.EmployeeTableAdapter();
            this.logOutButton = new MaterialSkin.Controls.MaterialButton();
            this.newRoomBtn = new MaterialSkin.Controls.MaterialButton();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(7, 534);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // roomDataGridView
            // 
            this.roomDataGridView.AllowUserToAddRows = false;
            this.roomDataGridView.AllowUserToDeleteRows = false;
            this.roomDataGridView.AutoGenerateColumns = false;
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1});
            this.roomDataGridView.DataSource = this.roomBindingSource;
            this.roomDataGridView.Location = new System.Drawing.Point(9, 82);
            this.roomDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.ReadOnly = true;
            this.roomDataGridView.RowHeadersWidth = 51;
            this.roomDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.roomDataGridView.Size = new System.Drawing.Size(323, 426);
            this.roomDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsAvailable";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsAvailable";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showInformationButton
            // 
            this.showInformationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showInformationButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.showInformationButton.Depth = 0;
            this.showInformationButton.HighEmphasis = true;
            this.showInformationButton.Icon = null;
            this.showInformationButton.Location = new System.Drawing.Point(247, 519);
            this.showInformationButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.showInformationButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.showInformationButton.Name = "showInformationButton";
            this.showInformationButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.showInformationButton.Size = new System.Drawing.Size(64, 36);
            this.showInformationButton.TabIndex = 2;
            this.showInformationButton.Text = "Info";
            this.showInformationButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.showInformationButton.UseAccentColor = false;
            this.showInformationButton.UseVisualStyleBackColor = true;
            this.showInformationButton.Click += new System.EventHandler(this.showInformationButton_Click);
            // 
            // id
            // 
            this.id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "Id", true));
            this.id.Location = new System.Drawing.Point(85, 534);
            this.id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(133, 28);
            this.id.TabIndex = 3;
            this.id.Text = "label1";
            // 
            // createNewSessionButton
            // 
            this.createNewSessionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createNewSessionButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createNewSessionButton.Depth = 0;
            this.createNewSessionButton.HighEmphasis = true;
            this.createNewSessionButton.Icon = null;
            this.createNewSessionButton.Location = new System.Drawing.Point(847, 450);
            this.createNewSessionButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.createNewSessionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.createNewSessionButton.Name = "createNewSessionButton";
            this.createNewSessionButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.createNewSessionButton.Size = new System.Drawing.Size(175, 36);
            this.createNewSessionButton.TabIndex = 4;
            this.createNewSessionButton.Text = "create new session";
            this.createNewSessionButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createNewSessionButton.UseAccentColor = false;
            this.createNewSessionButton.UseVisualStyleBackColor = true;
            this.createNewSessionButton.Click += new System.EventHandler(this.createNewSessionButton_Click);
            // 
            // showEmployeeButton
            // 
            this.showEmployeeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showEmployeeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.showEmployeeButton.Depth = 0;
            this.showEmployeeButton.HighEmphasis = true;
            this.showEmployeeButton.Icon = null;
            this.showEmployeeButton.Location = new System.Drawing.Point(880, 578);
            this.showEmployeeButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.showEmployeeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.showEmployeeButton.Name = "showEmployeeButton";
            this.showEmployeeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.showEmployeeButton.Size = new System.Drawing.Size(142, 36);
            this.showEmployeeButton.TabIndex = 5;
            this.showEmployeeButton.Text = "show employee";
            this.showEmployeeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.showEmployeeButton.UseAccentColor = false;
            this.showEmployeeButton.UseVisualStyleBackColor = true;
            this.showEmployeeButton.Click += new System.EventHandler(this.showEmployeeButton_Click);
            // 
            // showBillLogButton
            // 
            this.showBillLogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showBillLogButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.showBillLogButton.Depth = 0;
            this.showBillLogButton.HighEmphasis = true;
            this.showBillLogButton.Icon = null;
            this.showBillLogButton.Location = new System.Drawing.Point(916, 638);
            this.showBillLogButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.showBillLogButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.showBillLogButton.Name = "showBillLogButton";
            this.showBillLogButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.showBillLogButton.Size = new System.Drawing.Size(106, 36);
            this.showBillLogButton.TabIndex = 6;
            this.showBillLogButton.Text = "show bills";
            this.showBillLogButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.showBillLogButton.UseAccentColor = false;
            this.showBillLogButton.UseVisualStyleBackColor = true;
            this.showBillLogButton.Click += new System.EventHandler(this.showBillLogButton_Click);
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ItemBillTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = this.roomTableAdapter;
            this.tableAdapterManager.SessionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestDB.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.database1DataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // logOutButton
            // 
            this.logOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logOutButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.logOutButton.Depth = 0;
            this.logOutButton.HighEmphasis = true;
            this.logOutButton.Icon = null;
            this.logOutButton.Location = new System.Drawing.Point(9, 638);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.logOutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.logOutButton.Size = new System.Drawing.Size(78, 36);
            this.logOutButton.TabIndex = 7;
            this.logOutButton.Text = "Logout";
            this.logOutButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.logOutButton.UseAccentColor = false;
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // newRoomBtn
            // 
            this.newRoomBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newRoomBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.newRoomBtn.Depth = 0;
            this.newRoomBtn.HighEmphasis = true;
            this.newRoomBtn.Icon = null;
            this.newRoomBtn.Location = new System.Drawing.Point(865, 514);
            this.newRoomBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.newRoomBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.newRoomBtn.Name = "newRoomBtn";
            this.newRoomBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.newRoomBtn.Size = new System.Drawing.Size(157, 36);
            this.newRoomBtn.TabIndex = 8;
            this.newRoomBtn.Text = "CREATE NEW ROOM";
            this.newRoomBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.newRoomBtn.UseAccentColor = false;
            this.newRoomBtn.UseVisualStyleBackColor = true;
            this.newRoomBtn.Click += new System.EventHandler(this.newRoomBtn_Click_1);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 706);
            this.Controls.Add(this.newRoomBtn);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.showBillLogButton);
            this.Controls.Add(this.showEmployeeButton);
            this.Controls.Add(this.createNewSessionButton);
            this.Controls.Add(this.id);
            this.Controls.Add(this.showInformationButton);
            this.Controls.Add(this.roomDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeForm";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private Database1DataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView roomDataGridView;
        private MaterialSkin.Controls.MaterialButton showInformationButton;
        private System.Windows.Forms.Label id;
        private MaterialSkin.Controls.MaterialButton createNewSessionButton;
        private MaterialSkin.Controls.MaterialButton showEmployeeButton;
        private MaterialSkin.Controls.MaterialButton showBillLogButton;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Database1DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private MaterialSkin.Controls.MaterialButton logOutButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private MaterialSkin.Controls.MaterialButton newRoomBtn;
    }
}