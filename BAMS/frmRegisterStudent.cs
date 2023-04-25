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
using System.IO.Ports;

namespace BAMS
{
    public partial class frmRegisterStudent : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string sqlstr;
        SqlDataReader dr;
        public frmRegisterStudent()
        {
            InitializeComponent();
            clearData();
        }

        private void sTUDENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.sTUDENTBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.bAMSDataSet);

        }

        private void frmRegisterStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog2.Title = "Select Image";
                openFileDialog2.Filter = "All Files|*.*|Bitamps|*.bmp|GIFs|*.gif|JPEGs|*.jpg";
                openFileDialog2.FilterIndex = 1;
                openFileDialog2.FileName = "";
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    picturePictureBox.Image = Image.FromFile(openFileDialog2.FileName);
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
                try
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    if (picturePictureBox.Image != null)
                    {
                        picturePictureBox.Image.Save(ms, picturePictureBox.Image.RawFormat);
                    }
                    byte[] data = ms.GetBuffer();

                    //this.sTUDENTBindingSource.AddNew();
                    //((DataRowView)sTUDENTBindingSource.Current)["StudentId"] = Convert.ToInt32(studentIdTextBox.Text);
                    //((DataRowView)sTUDENTBindingSource.Current)["FirstName"] = firstNameTextBox.Text;
                    //((DataRowView)sTUDENTBindingSource.Current)["LastName"] = lastNameTextBox.Text;
                    //((DataRowView)sTUDENTBindingSource.Current)["OtherName"] = otherNameTextBox.Text;
                    //((DataRowView)sTUDENTBindingSource.Current)["Gender"] = genderComboBox.Text;
                    //((DataRowView)sTUDENTBindingSource.Current)["DateOfBirth"] = dateOfBirthDateTimePicker.Text;
                    //((DataRowView)sTUDENTBindingSource.Current)["DateOfBirth"] = dateOfBirthDateTimePicker.Text;
                    //((DataRowView)sTUDENTBindingSource.Current)["DateOfAdmission"] = dateOfAdmissionDateTimePicker.Text;
                    //((DataRowView)sTUDENTBindingSource.Current)["Picture"] = data;

                    con = new SqlConnection("Data Source=.;Initial Catalog=BAMS;Integrated Security=True");
                    con.Open();
                    sqlstr = "Insert into STUDENT values (@StudentId, @FirstName, @LastName, @OtherName, @Gender, @DateOfBirth, @DateOfAdmission, @Picture)";
                    cmd = new SqlCommand(sqlstr, con);

                    cmd.Parameters.AddWithValue("@StudentId", Convert.ToInt32(studentIdNumericUpDown.Text));
                    cmd.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                    if (otherNameTextBox == null)
                    {
                        cmd.Parameters.AddWithValue("@OtherName", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@OtherName", otherNameTextBox.Text);
                    }                    
                    cmd.Parameters.AddWithValue("@Gender", genderComboBox.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirthDateTimePicker.Text);
                    cmd.Parameters.AddWithValue("@DateOfAdmission", dateOfAdmissionDateTimePicker.Text);
                    cmd.Parameters.AddWithValue("@Picture", data);

                    cmd.ExecuteNonQuery();

                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.PortName = mySerial.comPort;
                        serialPort1.BaudRate = 9600;
                        serialPort1.Open();
                    }
                    
                    serialPort1.Write("*E" + studentIdNumericUpDown.Text + "#");
                    serialPort1.Close();
                    serialPort1.Dispose();
                    MessageBoxForm messageBox = new MessageBoxForm(" Student Successfully Registered! ");
                    messageBox.ShowDialog();
                    clearData();
                }
                catch (Exception ex)
                {
                    ex.sqlexception();
                }
            }
        }

        private void clearData()
        {
            firstNameTextBox.Clear();
            otherNameTextBox.Clear();
            lastNameTextBox.Clear();
            genderComboBox.Text = null;
            picturePictureBox.Image = null;
            dateOfBirthDateTimePicker.Value = DateTime.Now;
            dateOfAdmissionDateTimePicker.Value = DateTime.Now;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
