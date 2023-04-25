namespace BAMS
{
    partial class StudentsReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnClose = new System.Windows.Forms.Button();
            this.BAMSDataSet = new BAMS.BAMSDataSet();
            this.STUDENTVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.STUDENTVIEWTableAdapter = new BAMS.BAMSDataSetTableAdapters.STUDENTVIEWTableAdapter();
            Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BAMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STUDENTVIEWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.BackColor = System.Drawing.Color.White;
            Label1.Dock = System.Windows.Forms.DockStyle.Top;
            Label1.Font = new System.Drawing.Font("Trebuchet MS", 17F);
            Label1.ForeColor = System.Drawing.Color.Black;
            Label1.Location = new System.Drawing.Point(1, 1);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(825, 48);
            Label1.TabIndex = 157;
            Label1.Text = "  Students Report";
            Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown_1);
            Label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove_1);
            Label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseUp_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 701);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(826, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 701);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 702);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(827, 1);
            this.panel4.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 1);
            this.panel1.TabIndex = 3;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.STUDENTVIEWBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BAMS.StudentsReport1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 49);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(825, 653);
            this.reportViewer1.TabIndex = 166;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Orange;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(787, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 27);
            this.btnClose.TabIndex = 339;
            this.btnClose.Text = "x";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BAMSDataSet
            // 
            this.BAMSDataSet.DataSetName = "BAMSDataSet";
            this.BAMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // STUDENTVIEWBindingSource
            // 
            this.STUDENTVIEWBindingSource.DataMember = "STUDENTVIEW";
            this.STUDENTVIEWBindingSource.DataSource = this.BAMSDataSet;
            // 
            // STUDENTVIEWTableAdapter
            // 
            this.STUDENTVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // StudentsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(827, 703);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(Label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeReport";
            this.Load += new System.EventHandler(this.EmployeeReport_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EmployeeReport_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.BAMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STUDENTVIEWBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource STUDENTVIEWBindingSource;
        private BAMSDataSet BAMSDataSet;
        private BAMSDataSetTableAdapters.STUDENTVIEWTableAdapter STUDENTVIEWTableAdapter;
    }
}