namespace BAMS
{
    partial class frmEditStudent
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
            System.Windows.Forms.Label Label1;
            System.Windows.Forms.Label studentIdLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label otherNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label dateOfAdmissionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditStudent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAMSDataSet = new BAMS.BAMSDataSet();
            this.btnSaveDetails = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.dvgSearch = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.studentTableAdapter1 = new BAMS.BAMSDataSet1TableAdapters.STUDENTTableAdapter();
            this.sTUDENTTableAdapter = new BAMS.BAMSDataSetTableAdapters.STUDENTTableAdapter();
            this.tableAdapterManager = new BAMS.BAMSDataSetTableAdapters.TableAdapterManager();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.otherNameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfAdmissionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            Label1 = new System.Windows.Forms.Label();
            studentIdLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            otherNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            dateOfAdmissionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAMSDataSet)).BeginInit();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSearch)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.Font = new System.Drawing.Font("Trebuchet MS", 17F);
            Label1.ForeColor = System.Drawing.Color.Orange;
            Label1.Location = new System.Drawing.Point(3, 13);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(1048, 40);
            Label1.TabIndex = 238;
            Label1.Text = "  Edit Student";
            Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentIdLabel
            // 
            studentIdLabel.AutoSize = true;
            studentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            studentIdLabel.ForeColor = System.Drawing.Color.White;
            studentIdLabel.Location = new System.Drawing.Point(57, 83);
            studentIdLabel.Name = "studentIdLabel";
            studentIdLabel.Size = new System.Drawing.Size(73, 16);
            studentIdLabel.TabIndex = 369;
            studentIdLabel.Text = "Student  Id:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.ForeColor = System.Drawing.Color.White;
            firstNameLabel.Location = new System.Drawing.Point(57, 130);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(79, 16);
            firstNameLabel.TabIndex = 371;
            firstNameLabel.Text = "First  Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.ForeColor = System.Drawing.Color.White;
            lastNameLabel.Location = new System.Drawing.Point(57, 177);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(79, 16);
            lastNameLabel.TabIndex = 373;
            lastNameLabel.Text = "Last  Name:";
            // 
            // otherNameLabel
            // 
            otherNameLabel.AutoSize = true;
            otherNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            otherNameLabel.ForeColor = System.Drawing.Color.White;
            otherNameLabel.Location = new System.Drawing.Point(57, 224);
            otherNameLabel.Name = "otherNameLabel";
            otherNameLabel.Size = new System.Drawing.Size(86, 16);
            otherNameLabel.TabIndex = 375;
            otherNameLabel.Text = "Other  Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.ForeColor = System.Drawing.Color.White;
            genderLabel.Location = new System.Drawing.Point(57, 271);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(56, 16);
            genderLabel.TabIndex = 377;
            genderLabel.Text = "Gender:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateOfBirthLabel.ForeColor = System.Drawing.Color.White;
            dateOfBirthLabel.Location = new System.Drawing.Point(57, 318);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(88, 16);
            dateOfBirthLabel.TabIndex = 378;
            dateOfBirthLabel.Text = "Date Of  Birth:";
            // 
            // dateOfAdmissionLabel
            // 
            dateOfAdmissionLabel.AutoSize = true;
            dateOfAdmissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateOfAdmissionLabel.ForeColor = System.Drawing.Color.White;
            dateOfAdmissionLabel.Location = new System.Drawing.Point(57, 365);
            dateOfAdmissionLabel.Name = "dateOfAdmissionLabel";
            dateOfAdmissionLabel.Size = new System.Drawing.Size(109, 16);
            dateOfAdmissionLabel.TabIndex = 380;
            dateOfAdmissionLabel.Text = "Admission  Date:";
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(369, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 252;
            this.button1.Text = "&Delete Student";
            this.toolTip1.SetToolTip(this.button1, "Remove User");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnRemoveImage.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRemoveImage.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnRemoveImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnRemoveImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveImage.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveImage.ForeColor = System.Drawing.Color.White;
            this.btnRemoveImage.Location = new System.Drawing.Point(451, 300);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(168, 37);
            this.btnRemoveImage.TabIndex = 236;
            this.btnRemoveImage.Text = "&Remove Image";
            this.btnRemoveImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnRemoveImage, "Remove Image");
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBrowse.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(451, 257);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(168, 37);
            this.btnBrowse.TabIndex = 235;
            this.btnBrowse.Text = "&Browse Image";
            this.toolTip1.SetToolTip(this.btnBrowse, "Browse Image");
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturePictureBox.BackgroundImage")));
            this.picturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.sTUDENTBindingSource, "Picture", true));
            this.picturePictureBox.Location = new System.Drawing.Point(451, 78);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(168, 178);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePictureBox.TabIndex = 250;
            this.picturePictureBox.TabStop = false;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.bAMSDataSet;
            // 
            // bAMSDataSet
            // 
            this.bAMSDataSet.DataSetName = "BAMSDataSet";
            this.bAMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSaveDetails
            // 
            this.btnSaveDetails.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSaveDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDetails.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSaveDetails.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSaveDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnSaveDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnSaveDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDetails.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDetails.ForeColor = System.Drawing.Color.White;
            this.btnSaveDetails.Location = new System.Drawing.Point(534, 551);
            this.btnSaveDetails.Name = "btnSaveDetails";
            this.btnSaveDetails.Size = new System.Drawing.Size(127, 37);
            this.btnSaveDetails.TabIndex = 239;
            this.btnSaveDetails.Text = "&Save Details";
            this.toolTip1.SetToolTip(this.btnSaveDetails, "Save Details");
            this.btnSaveDetails.UseVisualStyleBackColor = false;
            this.btnSaveDetails.Click += new System.EventHandler(this.btnSaveDetails_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Indigo;
            this.SearchPanel.Controls.Add(this.dvgSearch);
            this.SearchPanel.Controls.Add(this.panel3);
            this.SearchPanel.Location = new System.Drawing.Point(669, 12);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(364, 560);
            this.SearchPanel.TabIndex = 237;
            // 
            // dvgSearch
            // 
            this.dvgSearch.AllowUserToAddRows = false;
            this.dvgSearch.AllowUserToDeleteRows = false;
            this.dvgSearch.AllowUserToResizeColumns = false;
            this.dvgSearch.AllowUserToResizeRows = false;
            this.dvgSearch.AutoGenerateColumns = false;
            this.dvgSearch.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.OtherName,
            this.studentIdDataGridViewTextBoxColumn});
            this.dvgSearch.DataSource = this.sTUDENTBindingSource;
            this.dvgSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgSearch.Location = new System.Drawing.Point(0, 125);
            this.dvgSearch.MultiSelect = false;
            this.dvgSearch.Name = "dvgSearch";
            this.dvgSearch.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgSearch.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dvgSearch.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgSearch.Size = new System.Drawing.Size(364, 435);
            this.dvgSearch.TabIndex = 131;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OtherName
            // 
            this.OtherName.DataPropertyName = "OtherName";
            this.OtherName.HeaderText = "Other Name(s)";
            this.OtherName.Name = "OtherName";
            this.OtherName.ReadOnly = true;
            this.OtherName.Width = 170;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 125);
            this.panel3.TabIndex = 129;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(327, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 27);
            this.button2.TabIndex = 318;
            this.button2.Text = " x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(288, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 27);
            this.btnMinimize.TabIndex = 316;
            this.btnMinimize.Text = " _";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(36, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(293, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "           Search First Name or Last Name";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.STUDENTATTENDANCETableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = this.sTUDENTTableAdapter;
            this.tableAdapterManager.UpdateOrder = BAMS.BAMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(203, 125);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox.TabIndex = 383;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(203, 172);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 385;
            // 
            // otherNameTextBox
            // 
            this.otherNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource, "OtherName", true));
            this.otherNameTextBox.Location = new System.Drawing.Point(203, 219);
            this.otherNameTextBox.Name = "otherNameTextBox";
            this.otherNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.otherNameTextBox.TabIndex = 387;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sTUDENTBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(203, 314);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 391;
            // 
            // dateOfAdmissionDateTimePicker
            // 
            this.dateOfAdmissionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sTUDENTBindingSource, "DateOfAdmission", true));
            this.dateOfAdmissionDateTimePicker.Location = new System.Drawing.Point(203, 361);
            this.dateOfAdmissionDateTimePicker.Name = "dateOfAdmissionDateTimePicker";
            this.dateOfAdmissionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfAdmissionDateTimePicker.TabIndex = 393;
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.studentIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource, "StudentId", true));
            this.studentIdTextBox.Location = new System.Drawing.Point(203, 79);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.ReadOnly = true;
            this.studentIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.studentIdTextBox.TabIndex = 394;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sTUDENTBindingSource, "Gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(203, 266);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(200, 21);
            this.genderComboBox.TabIndex = 395;
            // 
            // frmEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1071, 600);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.studentIdTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.otherNameTextBox);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.dateOfAdmissionDateTimePicker);
            this.Controls.Add(studentIdLabel);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(otherNameLabel);
            this.Controls.Add(genderLabel);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(dateOfAdmissionLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picturePictureBox);
            this.Controls.Add(this.btnSaveDetails);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditStudent";
            this.Load += new System.EventHandler(this.frmEditStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAMSDataSet)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgSearch)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Button btnRemoveImage;
        internal System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picturePictureBox;
        internal System.Windows.Forms.Button btnSaveDetails;
        internal System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.DataGridView dvgSearch;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private BAMSDataSet bAMSDataSet;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.IO.Ports.SerialPort serialPort1;
        private BAMSDataSet1TableAdapters.STUDENTTableAdapter studentTableAdapter1;
        private BAMSDataSetTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private BAMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox otherNameTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateOfAdmissionDateTimePicker;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
    }
}