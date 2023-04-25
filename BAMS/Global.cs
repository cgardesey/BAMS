using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAMS
{
    public static class Extension
    {
        public static int sqlexception (this Exception ex, String text = "")
        {
            var sql = ex.GetBaseException() as SqlException;
            if(sql != null)
            {
                switch (sql.Number)
                {
                    case 2:
                        {
                            MessageBoxForm messageBox = new MessageBoxForm("Cannot Connect to Server");
                            messageBox.ShowDialog();
                            break;
                        }

                    case 2601:
                        {
                            MessageBoxForm messageBox = new MessageBoxForm(text + " Already Exists!");
                            messageBox.ShowDialog();
                            //productNameTextBox.Focus();
                            break;
                        }

                    case 547: // Foreign Key violation
                        {
                            MessageBoxForm messageBox = new MessageBoxForm(" This operation failed because another data entry uses this entry.");
                            messageBox.ShowDialog();
                            break;
                        }                       
                                          
                    default:
                        {
                            MessageBoxForm messageBox = new MessageBoxForm("Error code: " + sql.Number.ToString() + ". " + sql.Message);
                            messageBox.ShowDialog();
                            break;
                        }
                }
                return sql.Number;
            }
            else
            {
                MessageBoxForm messageBox = new MessageBoxForm(ex.Message);
                messageBox.ShowDialog();
            }
            return 0;
        }
    }

    public static class mySerial
    {
       public static String comPort; 
    }
}
