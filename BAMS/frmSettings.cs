using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;

namespace BAMS
{
    public partial class frmSettings : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string sqlstr;
        string instring;
        public frmSettings()
        {
            InitializeComponent();
            portComboBox.Items.AddRange(SerialPort.GetPortNames());
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //mySerial.comPort = comboBox1.Text;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (btnPort.Text == "Open")
            {
                if (String.IsNullOrEmpty(portComboBox.Text))
                {
                    MessageBoxForm messageBox = new MessageBoxForm("Select COM PORT!");
                    messageBox.ShowDialog();
                }
                else
                {
                    serialPort1.PortName = portComboBox.Text;
                    serialPort1.BaudRate = 9600;

                    mySerial.comPort = portComboBox.Text;
                    progressBar1.Value = 100;
                    btnPort.Text = "Close";
                    try
                    {
                        serialPort1.Open();
                    }
                    catch (UnauthorizedAccessException)
                    {
                        MessageBoxForm messageBox = new MessageBoxForm("Unauthorized Access");
                        messageBox.ShowDialog();
                    }
                }               
            }
            else
            {                                            
                portComboBox.SelectedIndex = -1;

                mySerial.comPort = "";
                progressBar1.Value = 0;
                btnPort.Text = "Open";
                serialPort1.Close();
                serialPort1.Dispose();
            }   
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            try
            {
                instring = serialPort1.ReadLine();
                //MessageBoxForm messageBox = new MessageBoxForm(instring);
                //messageBox.ShowDialog();
                logAttendanceInfo();
            }
            catch (Exception ex)
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
        }

        private void logAttendanceInfo()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=BAMS;Integrated Security=True");
                con.Open();
                sqlstr = "Insert into STUDENTATTENDANCE values (@Date, @StudentId, @WasPresent, @Time)";
                cmd = new SqlCommand(sqlstr, con);

                instring = instring.Trim();

                cmd.Parameters.AddWithValue("@Date", System.DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@StudentId", Convert.ToInt32(instring));
                cmd.Parameters.AddWithValue("@WasPresent", 1);
                cmd.Parameters.AddWithValue("@Time", System.DateTime.Now.TimeOfDay);
                cmd.ExecuteNonQuery();

                MessageBoxForm messageBox = new MessageBoxForm("Attendance details successfully logged!");
                messageBox.ShowDialog();
            }
            catch (Exception ex)
            {
                ex.sqlexception();
            }
            finally
            {
                con.Close();
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            if (mySerial.comPort == "")
            {
                portComboBox.Text = "";
                progressBar1.Value = 0;
                btnPort.Text = "Open";
            }
            else
            {
                portComboBox.Text = mySerial.comPort;
                progressBar1.Value = 100;
                btnPort.Text = "Close";
            }
        }
    }
}
