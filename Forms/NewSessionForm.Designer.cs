namespace TestDB.Forms
{
    partial class NewSessionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSessionForm));
            this.database1DataSet = new TestDB.Database1DataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new TestDB.Database1DataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new TestDB.Database1DataSetTableAdapters.TableAdapterManager();
            this.sessionTableAdapter = new TestDB.Database1DataSetTableAdapters.SessionTableAdapter();
            this.employeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.employeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.consoleComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.gameComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newSessionBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.roomIdLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).BeginInit();
            this.employeeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.ItemBillTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.SessionTableAdapter = this.sessionTableAdapter;
            this.tableAdapterManager.UpdateOrder = TestDB.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingNavigator
            // 
            this.employeeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeeBindingNavigator.BindingSource = this.employeeBindingSource;
            this.employeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.employeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.employeeBindingNavigatorSaveItem});
            this.employeeBindingNavigator.Location = new System.Drawing.Point(3, 64);
            this.employeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeeBindingNavigator.Name = "employeeBindingNavigator";
            this.employeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeeBindingNavigator.Size = new System.Drawing.Size(1196, 27);
            this.employeeBindingNavigator.TabIndex = 0;
            this.employeeBindingNavigator.Text = "bindingNavigator1";
            this.employeeBindingNavigator.RefreshItems += new System.EventHandler(this.employeeBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // employeeBindingNavigatorSaveItem
            // 
            this.employeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeBindingNavigatorSaveItem.Image")));
            this.employeeBindingNavigatorSaveItem.Name = "employeeBindingNavigatorSaveItem";
            this.employeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.employeeBindingNavigatorSaveItem.Text = "Save Data";
            this.employeeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeeBindingNavigatorSaveItem_Click);
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.database1DataSet;
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataMember = "Session";
            this.sessionBindingSource.DataSource = this.database1DataSet;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(218, 201);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Game Console:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(279, 279);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(47, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Game:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(254, 353);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(72, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "End Time:";
            // 
            // consoleComboBox
            // 
            this.consoleComboBox.AutoResize = false;
            this.consoleComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.consoleComboBox.Depth = 0;
            this.consoleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.consoleComboBox.DropDownHeight = 174;
            this.consoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.consoleComboBox.DropDownWidth = 121;
            this.consoleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.consoleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.consoleComboBox.FormattingEnabled = true;
            this.consoleComboBox.IntegralHeight = false;
            this.consoleComboBox.ItemHeight = 43;
            this.consoleComboBox.Items.AddRange(new object[] {
            "PlayStation 3",
            "PlayStation 4",
            "PlayStation 5",
            "Xbox One",
            "Xbox Series X",
            "Xbox Series S"});
            this.consoleComboBox.Location = new System.Drawing.Point(379, 182);
            this.consoleComboBox.MaxDropDownItems = 4;
            this.consoleComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.consoleComboBox.Name = "consoleComboBox";
            this.consoleComboBox.Size = new System.Drawing.Size(357, 49);
            this.consoleComboBox.StartIndex = 0;
            this.consoleComboBox.TabIndex = 5;
            // 
            // gameComboBox
            // 
            this.gameComboBox.AutoResize = false;
            this.gameComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gameComboBox.Depth = 0;
            this.gameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.gameComboBox.DropDownHeight = 174;
            this.gameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameComboBox.DropDownWidth = 121;
            this.gameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameComboBox.FormattingEnabled = true;
            this.gameComboBox.IntegralHeight = false;
            this.gameComboBox.ItemHeight = 43;
            this.gameComboBox.Items.AddRange(new object[] {
            "COD: Black Ops III",
            "COD: Black Ops 4",
            "COD: Black Ops Cold War",
            "GTA V",
            "PES 2022",
            "PES 2023",
            "PES 2024",
            "FIFA 22",
            "FIFA 23",
            "FIFA 24"});
            this.gameComboBox.Location = new System.Drawing.Point(379, 266);
            this.gameComboBox.MaxDropDownItems = 4;
            this.gameComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.gameComboBox.Name = "gameComboBox";
            this.gameComboBox.Size = new System.Drawing.Size(357, 49);
            this.gameComboBox.StartIndex = 0;
            this.gameComboBox.TabIndex = 6;
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(379, 353);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(357, 22);
            this.endTimeDateTimePicker.TabIndex = 8;
            // 
            // newSessionBtn
            // 
            this.newSessionBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newSessionBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.newSessionBtn.Depth = 0;
            this.newSessionBtn.HighEmphasis = true;
            this.newSessionBtn.Icon = null;
            this.newSessionBtn.Location = new System.Drawing.Point(379, 405);
            this.newSessionBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.newSessionBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.newSessionBtn.Name = "newSessionBtn";
            this.newSessionBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.newSessionBtn.Size = new System.Drawing.Size(175, 36);
            this.newSessionBtn.TabIndex = 9;
            this.newSessionBtn.Text = "Create New Session";
            this.newSessionBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.newSessionBtn.UseAccentColor = false;
            this.newSessionBtn.UseVisualStyleBackColor = true;
            this.newSessionBtn.Click += new System.EventHandler(this.newSessionBtn_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(260, 131);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(66, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Room ID:";
            // 
            // roomIdLabel
            // 
            this.roomIdLabel.AutoSize = true;
            this.roomIdLabel.Depth = 0;
            this.roomIdLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.roomIdLabel.Location = new System.Drawing.Point(376, 131);
            this.roomIdLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.roomIdLabel.Name = "roomIdLabel";
            this.roomIdLabel.Size = new System.Drawing.Size(10, 19);
            this.roomIdLabel.TabIndex = 11;
            this.roomIdLabel.Text = "0";
            // 
            // NewSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 589);
            this.Controls.Add(this.roomIdLabel);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.newSessionBtn);
            this.Controls.Add(this.endTimeDateTimePicker);
            this.Controls.Add(this.gameComboBox);
            this.Controls.Add(this.consoleComboBox);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.employeeBindingNavigator);
            this.Name = "NewSessionForm";
            this.Text = "NewSessionForm";
            this.Load += new System.EventHandler(this.NewSessionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).EndInit();
            this.employeeBindingNavigator.ResumeLayout(false);
            this.employeeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Database1DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton employeeBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private Database1DataSetTableAdapters.SessionTableAdapter sessionTableAdapter;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox consoleComboBox;
        private MaterialSkin.Controls.MaterialComboBox gameComboBox;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private MaterialSkin.Controls.MaterialButton newSessionBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel roomIdLabel;
    }
}