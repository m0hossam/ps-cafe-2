namespace TestDB.Forms
{
    partial class RoomSessionForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.currentSessionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.roomAvailabilityLabel = new MaterialSkin.Controls.MaterialLabel();
            this.startTimeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.endTimeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.gameConsoleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.gameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.database1DataSet = new TestDB.Database1DataSet();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new TestDB.Database1DataSetTableAdapters.RoomTableAdapter();
            this.tableAdapterManager = new TestDB.Database1DataSetTableAdapters.TableAdapterManager();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionTableAdapter = new TestDB.Database1DataSetTableAdapters.SessionTableAdapter();
            this.backHomeBtn = new MaterialSkin.Controls.MaterialButton();
            this.finishSessionBtn = new MaterialSkin.Controls.MaterialButton();
            this.orderBtn = new MaterialSkin.Controls.MaterialButton();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTableAdapter = new TestDB.Database1DataSetTableAdapters.BillTableAdapter();
            this.roomIdLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 90);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(66, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Room ID:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(218, 196);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Start Time: ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(218, 229);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(72, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "End Time:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(218, 297);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Game:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(218, 262);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(108, 19);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Game Console:";
            // 
            // currentSessionLabel
            // 
            this.currentSessionLabel.AutoSize = true;
            this.currentSessionLabel.Depth = 0;
            this.currentSessionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.currentSessionLabel.Location = new System.Drawing.Point(287, 90);
            this.currentSessionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentSessionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.currentSessionLabel.Name = "currentSessionLabel";
            this.currentSessionLabel.Size = new System.Drawing.Size(140, 19);
            this.currentSessionLabel.TabIndex = 11;
            this.currentSessionLabel.Text = "CURRENT SESSION";
            // 
            // roomAvailabilityLabel
            // 
            this.roomAvailabilityLabel.AutoSize = true;
            this.roomAvailabilityLabel.BackColor = System.Drawing.SystemColors.Control;
            this.roomAvailabilityLabel.Depth = 0;
            this.roomAvailabilityLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.roomAvailabilityLabel.Location = new System.Drawing.Point(674, 90);
            this.roomAvailabilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomAvailabilityLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.roomAvailabilityLabel.Name = "roomAvailabilityLabel";
            this.roomAvailabilityLabel.Size = new System.Drawing.Size(103, 19);
            this.roomAvailabilityLabel.TabIndex = 12;
            this.roomAvailabilityLabel.Text = "UNAVAILABLE";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Depth = 0;
            this.startTimeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.startTimeLabel.Location = new System.Drawing.Point(455, 196);
            this.startTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(83, 19);
            this.startTimeLabel.TabIndex = 13;
            this.startTimeLabel.Text = "Start Time: ";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Depth = 0;
            this.endTimeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.endTimeLabel.Location = new System.Drawing.Point(455, 229);
            this.endTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(83, 19);
            this.endTimeLabel.TabIndex = 14;
            this.endTimeLabel.Text = "Start Time: ";
            // 
            // gameConsoleLabel
            // 
            this.gameConsoleLabel.AutoSize = true;
            this.gameConsoleLabel.Depth = 0;
            this.gameConsoleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gameConsoleLabel.Location = new System.Drawing.Point(455, 262);
            this.gameConsoleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameConsoleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.gameConsoleLabel.Name = "gameConsoleLabel";
            this.gameConsoleLabel.Size = new System.Drawing.Size(83, 19);
            this.gameConsoleLabel.TabIndex = 15;
            this.gameConsoleLabel.Text = "Start Time: ";
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Depth = 0;
            this.gameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gameLabel.Location = new System.Drawing.Point(455, 297);
            this.gameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(83, 19);
            this.gameLabel.TabIndex = 16;
            this.gameLabel.Text = "Start Time: ";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.database1DataSet;
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
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataMember = "Session";
            this.sessionBindingSource.DataSource = this.database1DataSet;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // backHomeBtn
            // 
            this.backHomeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backHomeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.backHomeBtn.Depth = 0;
            this.backHomeBtn.HighEmphasis = true;
            this.backHomeBtn.Icon = null;
            this.backHomeBtn.Location = new System.Drawing.Point(5, 417);
            this.backHomeBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.backHomeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.backHomeBtn.Name = "backHomeBtn";
            this.backHomeBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.backHomeBtn.Size = new System.Drawing.Size(127, 36);
            this.backHomeBtn.TabIndex = 17;
            this.backHomeBtn.Text = "Back To Home";
            this.backHomeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.backHomeBtn.UseAccentColor = false;
            this.backHomeBtn.UseVisualStyleBackColor = true;
            this.backHomeBtn.Click += new System.EventHandler(this.backHomeBtn_Click);
            // 
            // finishSessionBtn
            // 
            this.finishSessionBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.finishSessionBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.finishSessionBtn.Depth = 0;
            this.finishSessionBtn.HighEmphasis = true;
            this.finishSessionBtn.Icon = null;
            this.finishSessionBtn.Location = new System.Drawing.Point(646, 417);
            this.finishSessionBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.finishSessionBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.finishSessionBtn.Name = "finishSessionBtn";
            this.finishSessionBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.finishSessionBtn.Size = new System.Drawing.Size(131, 36);
            this.finishSessionBtn.TabIndex = 18;
            this.finishSessionBtn.Text = "Finish Session";
            this.finishSessionBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.finishSessionBtn.UseAccentColor = false;
            this.finishSessionBtn.UseVisualStyleBackColor = true;
            this.finishSessionBtn.Click += new System.EventHandler(this.finishSessionBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.orderBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.orderBtn.Depth = 0;
            this.orderBtn.HighEmphasis = true;
            this.orderBtn.Icon = null;
            this.orderBtn.Location = new System.Drawing.Point(290, 417);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.orderBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.orderBtn.Size = new System.Drawing.Size(188, 36);
            this.orderBtn.TabIndex = 19;
            this.orderBtn.Text = "Order Food or Drinks";
            this.orderBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.orderBtn.UseAccentColor = false;
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
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
            // roomIdLabel
            // 
            this.roomIdLabel.AutoSize = true;
            this.roomIdLabel.Depth = 0;
            this.roomIdLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.roomIdLabel.Location = new System.Drawing.Point(77, 90);
            this.roomIdLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.roomIdLabel.Name = "roomIdLabel";
            this.roomIdLabel.Size = new System.Drawing.Size(107, 19);
            this.roomIdLabel.TabIndex = 20;
            this.roomIdLabel.Text = "materialLabel6";
            // 
            // RoomSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 460);
            this.Controls.Add(this.roomIdLabel);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.finishSessionBtn);
            this.Controls.Add(this.backHomeBtn);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.gameConsoleLabel);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.roomAvailabilityLabel);
            this.Controls.Add(this.currentSessionLabel);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RoomSessionForm";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "RoomSessionForm";
            this.Load += new System.EventHandler(this.RoomSessionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel currentSessionLabel;
        private MaterialSkin.Controls.MaterialLabel roomAvailabilityLabel;
        private MaterialSkin.Controls.MaterialLabel startTimeLabel;
        private MaterialSkin.Controls.MaterialLabel endTimeLabel;
        private MaterialSkin.Controls.MaterialLabel gameConsoleLabel;
        private MaterialSkin.Controls.MaterialLabel gameLabel;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private Database1DataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private Database1DataSetTableAdapters.SessionTableAdapter sessionTableAdapter;
        private MaterialSkin.Controls.MaterialButton backHomeBtn;
        private MaterialSkin.Controls.MaterialButton finishSessionBtn;
        private MaterialSkin.Controls.MaterialButton orderBtn;
        private System.Windows.Forms.BindingSource billBindingSource;
        private Database1DataSetTableAdapters.BillTableAdapter billTableAdapter;
        private MaterialSkin.Controls.MaterialLabel roomIdLabel;
    }
}