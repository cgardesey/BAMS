using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BAMS
{
    public partial class frmEditStudent : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string sqlstr;
        SqlDataReader dr;
        public frmEditStudent()
        {
            InitializeComponent();
            clearData();
        }

        private void clearData()
        {
            //employeeIDTextBox.Clear();
            firstNameTextBox.Clear();
            otherNameTextBox.Clear();
            lastNameTextBox.Clear();
            genderComboBox.Text = null;
            picturePictureBox.Image = null;
            dateOfBirthDateTimePicker.Value = DateTime.Now;
            dateOfAdmissionDateTimePicker.Value = DateTime.Now;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.Title = "Select Image";
                openFileDialog1.Filter = "All Files|*.*|Bitamps|*.bmp|GIFs|*.gif|JPEGs|*.jpg";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.FileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    picturePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                    picturePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    picturePictureBox.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            picturePictureBox.Image = null;
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Enter First Name ");
                messageBox.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Enter Last Name ");
                messageBox.ShowDialog();
            }
            else if (string.IsNullOrWhiteSpace(genderComboBox.Text))
            {
                MessageBoxForm messageBox = new MessageBoxForm(" Select Gender ");
                messageBox.ShowDialog();
            }
            else if ((firstNameTextBox.Text + lastNameTextBox.Text + genderComboBox.Text) != "")
            {
                update();
            }
        }

        private void update()
        {
            try
            {
                //MemoryStream ms = new MemoryStream();
                //picturePictureBox.Image.Save(ms, picturePictureBox.Image.RawFormat);
                //byte[] data = ms.GetBuffer();

                this.Validate();
                this.sTUDENTBindingSource.EndEdit();
                this.sTUDENTTableAdapter.Update(this.bAMSDataSet.STUDENT);

                this.sTUDENTTableAdapter.Fill(this.bAMSDataSet.STUDENT);

                MessageBoxForm messageBox = new MessageBoxForm(" Details Successfully Updated! ");
                messageBox.ShowDialog();
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void frmEditStudent_Load(object sender, EventArgs e)
        {
            try
            {
                this.sTUDENTTableAdapter.Fill(this.bAMSDataSet.STUDENT);
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchstring = txtSearch.Text;
                sTUDENTBindingSource.Filter = "FIRSTNAME LIKE '%" + searchstring + "%' OR LASTNAME LIKE '%" + searchstring + "%'";
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dvgSearch.Rows.Count != 0)
            {
                string id = studentIdTextBox.Text;
                MessageBoxForm messageBox = new MessageBoxForm("Are You Sure You Want To Delete " + firstNameTextBox.Text + " " + lastNameTextBox.Text + " " + otherNameTextBox.Text + "?");
                messageBox.yes = true;
                messageBox.no = true;
                messageBox.ok = false;
                DialogResult result = messageBox.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        this.sTUDENTBindingSource.RemoveCurrent();
                        this.sTUDENTBindingSource.EndEdit();
                        this.sTUDENTTableAdapter.Update(this.bAMSDataSet.STUDENT);

                        if (!serialPort1.IsOpen)
                        {
                            serialPort1.PortName = mySerial.comPort;
                            serialPort1.BaudRate = 9600;
                            serialPort1.Open();
                        }
                        string temp = "*D";
                        temp += id;
                        temp += "#";
                        serialPort1.Write(temp);
                        serialPort1.Close();
                        serialPort1.Dispose();
                    }
                    catch (Exception ex)
                    {
                        var sqlresult = ex.sqlexception();
                        if (sqlresult == 547)
                        {
                            this.sTUDENTTableAdapter.Fill(this.bAMSDataSet.STUDENT);
                            //return;
                        }
                    }
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void studentIdLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
