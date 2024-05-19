namespace TestDB.Forms
{
    partial class NewEmployeeForm
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
            this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.usernameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.salaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.femaleRadioBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.maleRadioBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.nameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.addEmployeeButton = new MaterialSkin.Controls.MaterialButton();
            this.database1DataSet = new TestDB.Database1DataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new TestDB.Database1DataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new TestDB.Database1DataSetTableAdapters.TableAdapterManager();
            this.backButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AnimateReadOnly = false;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextBox.LeadingIcon = null;
            this.passwordTextBox.Location = new System.Drawing.Point(301, 306);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.MaxLength = 50;
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(201, 50);
            this.passwordTextBox.TabIndex = 33;
            this.passwordTextBox.Text = "";
            this.passwordTextBox.TrailingIcon = null;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.AnimateReadOnly = false;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Depth = 0;
            this.usernameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameTextBox.LeadingIcon = null;
            this.usernameTextBox.Location = new System.Drawing.Point(301, 240);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.MaxLength = 50;
            this.usernameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(201, 50);
            this.usernameTextBox.TabIndex = 32;
            this.usernameTextBox.Text = "";
            this.usernameTextBox.TrailingIcon = null;
            // 
            // salaryNumericUpDown
            // 
            this.salaryNumericUpDown.Location = new System.Drawing.Point(301, 199);
            this.salaryNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.salaryNumericUpDown.Name = "salaryNumericUpDown";
            this.salaryNumericUpDown.Size = new System.Drawing.Size(201, 20);
            this.salaryNumericUpDown.TabIndex = 31;
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Depth = 0;
            this.femaleRadioBtn.Location = new System.Drawing.Point(415, 145);
            this.femaleRadioBtn.Margin = new System.Windows.Forms.Padding(0);
            this.femaleRadioBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.femaleRadioBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Ripple = true;
            this.femaleRadioBtn.Size = new System.Drawing.Size(87, 37);
            this.femaleRadioBtn.TabIndex = 30;
            this.femaleRadioBtn.TabStop = true;
            this.femaleRadioBtn.Text = "Female";
            this.femaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Depth = 0;
            this.maleRadioBtn.Location = new System.Drawing.Point(301, 145);
            this.maleRadioBtn.Margin = new System.Windows.Forms.Padding(0);
            this.maleRadioBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.maleRadioBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Ripple = true;
            this.maleRadioBtn.Size = new System.Drawing.Size(70, 37);
            this.maleRadioBtn.TabIndex = 29;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AnimateReadOnly = false;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Depth = 0;
            this.nameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTextBox.LeadingIcon = null;
            this.nameTextBox.Location = new System.Drawing.Point(301, 90);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 50);
            this.nameTextBox.TabIndex = 28;
            this.nameTextBox.Text = "";
            this.nameTextBox.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(144, 309);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(71, 19);
            this.materialLabel5.TabIndex = 27;
            this.materialLabel5.Text = "Password";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(144, 255);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(72, 19);
            this.materialLabel4.TabIndex = 26;
            this.materialLabel4.Text = "Username";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(144, 199);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(46, 19);
            this.materialLabel3.TabIndex = 25;
            this.materialLabel3.Text = "Salary";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(144, 155);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "Gender";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(144, 100);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 19);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "Full Name";
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addEmployeeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addEmployeeButton.Depth = 0;
            this.addEmployeeButton.HighEmphasis = true;
            this.addEmployeeButton.Icon = null;
            this.addEmployeeButton.Location = new System.Drawing.Point(322, 383);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addEmployeeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addEmployeeButton.Size = new System.Drawing.Size(165, 36);
            this.addEmployeeButton.TabIndex = 34;
            this.addEmployeeButton.Text = "Add new Employee";
            this.addEmployeeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addEmployeeButton.UseAccentColor = false;
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
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
            this.tableAdapterManager.SessionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TestDB.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // backButton
            // 
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.backButton.Depth = 0;
            this.backButton.HighEmphasis = true;
            this.backButton.Icon = null;
            this.backButton.Location = new System.Drawing.Point(7, 405);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.backButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.backButton.Name = "backButton";
            this.backButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.backButton.Size = new System.Drawing.Size(64, 36);
            this.backButton.TabIndex = 46;
            this.backButton.Text = "back";
            this.backButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.backButton.UseAccentColor = false;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // NewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.salaryNumericUpDown);
            this.Controls.Add(this.femaleRadioBtn);
            this.Controls.Add(this.maleRadioBtn);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "NewEmployeeForm";
            this.Text = "NewEmployeeForm";
            this.Load += new System.EventHandler(this.NewEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox passwordTextBox;
        private MaterialSkin.Controls.MaterialTextBox usernameTextBox;
        private System.Windows.Forms.NumericUpDown salaryNumericUpDown;
        private MaterialSkin.Controls.MaterialRadioButton femaleRadioBtn;
        private MaterialSkin.Controls.MaterialRadioButton maleRadioBtn;
        private MaterialSkin.Controls.MaterialTextBox nameTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton addEmployeeButton;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Database1DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MaterialSkin.Controls.MaterialButton backButton;
    }
}