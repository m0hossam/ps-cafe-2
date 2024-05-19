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
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(53, 111);
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
            this.materialLabel2.Location = new System.Drawing.Point(299, 234);
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
            this.materialLabel3.Location = new System.Drawing.Point(310, 275);
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
            this.materialLabel4.Location = new System.Drawing.Point(335, 358);
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
            this.materialLabel5.Location = new System.Drawing.Point(274, 315);
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
            this.currentSessionLabel.Location = new System.Drawing.Point(333, 184);
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
            this.roomAvailabilityLabel.Location = new System.Drawing.Point(658, 111);
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
            this.startTimeLabel.Location = new System.Drawing.Point(411, 234);
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
            this.endTimeLabel.Location = new System.Drawing.Point(411, 275);
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
            this.gameConsoleLabel.Location = new System.Drawing.Point(411, 315);
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
            this.gameLabel.Location = new System.Drawing.Point(411, 358);
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
            // RoomSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 461);
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
            this.Name = "RoomSessionForm";
            this.Text = "RoomSessionForm";
            this.Load += new System.EventHandler(this.RoomSessionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
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
    }
}