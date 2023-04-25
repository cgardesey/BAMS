using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAMS
{
    public partial class StudentAttendanceReport : Form
    {
        public StudentAttendanceReport()
        {
            InitializeComponent();
        }
        #region Form Properties
        private const int CS_DROPSHADOW = 0x00020000;

        private bool Dragging = false;
        private Point StartPoint = new Point(0, 0);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Label1_MouseUp(object sender, MouseEventArgs e)
        {

        }
        #endregion

        public bool EnforceConstraints { get; set; }
        private void SalesReport_Load(object sender, EventArgs e)
        {
            try
            {
                BAMSDataSet.EnforceConstraints = false;
                this.STUDENTATTENDANCEVIEWTableAdapter.Fill(this.BAMSDataSet.STUDENTATTENDANCEVIEW);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
               

                string searchString = txtSearch.Text;
                STUDENTATTENDANCEVIEWBindingSource.Filter = "convert(StudentId, 'System.String') LIKE '%" + searchString + "%' OR FirstName LIKE '%" + searchString + "%' OR LastName LIKE '%" + searchString + "%' OR OtherName LIKE '%" + searchString + "%'";
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void Label1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.StartPoint.X, p.Y - this.StartPoint.Y);
            }
        }

        private void Label1_MouseDown_1(object sender, MouseEventArgs e)
        {
            Dragging = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void Label1_MouseUp_1(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                fromDateTimePicker.Value = DateTime.Today;
                toDateTimePicker.Value = DateTime.Today;
                this.STUDENTATTENDANCEVIEWTableAdapter.FillByDate(this.BAMSDataSet.STUDENTATTENDANCEVIEW, fromDateTimePicker.Value.ToString(), toDateTimePicker.Value.ToString());
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                this.STUDENTATTENDANCEVIEWTableAdapter.FillByDate(this.BAMSDataSet.STUDENTATTENDANCEVIEW, fromDateTimePicker.Value.ToString(), toDateTimePicker.Value.ToString());
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }
    }
}
