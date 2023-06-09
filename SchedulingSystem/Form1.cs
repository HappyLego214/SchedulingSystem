using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using Org.BouncyCastle.Utilities.Collections;

namespace SchedulingSystem
{
    public partial class calendarSystem : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        MySqlConnection connection = new MySqlConnection
            (@"
            datasource = localhost;
            port = 3306;
            username = root;
            password = '';
            database = appointments
            ");

        MySqlCommand command;
        MySqlDataReader reader;

        public calendarSystem()
        {
            InitializeComponent();
        }

        private void appointmentCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            string a = "tbl" + appointmentCalendar.SelectionRange.Start.ToString("MM/dd/yyyy").Replace("/","");
            txtbxSelectedDate.Text = a;
        }

        private void createTable()
        {
            string sqlStatement = (@"CREATE TABLE " + txtbxSelectedDate.Text + " ( appID INT PRIMARY KEY AUTO_INCREMENT, appTimeSlot VARCHAR(100), ptLastName VARCHAR(50) DEFAULT '---', ptFirstName VARCHAR(50)  DEFAULT '---', ptMiddleName VARCHAR(50) DEFAULT '---');");
            MessageBox.Show("Table Created", "Success!");

            try
            {
                if(connection.State == ConnectionState.Closed) 
                {
                    connection.Open();
                }
                Console.WriteLine("Connection Is Open");
                MySqlCommand command= new MySqlCommand(sqlStatement, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Table Created");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                insertTimeValues();
                connection.Close();
                Console.WriteLine("Connection Is Closed");
            }
        }

        private void insertTimeValues()
        {
            command = new MySqlCommand(@"INSERT INTO " + txtbxSelectedDate.Text + " (`appTimeSlot`) " +
                "VALUES ('8:00'), ('8:30'), ('9:00'), ('9:30'), ('10:00'), ('10:30'), ('11:00'), ('11:30'), " +
                "('13:00'), ('13:30'), ('14:00'), ('14:30'), ('15:00'), ('15:30'), ('16:00'), ('16:30'), ('17:00');", connection);
            command.ExecuteNonQuery();
        }

        private void LoadTable()
        {
            dataGridAppointment.Rows.Clear();
            command = new MySqlCommand(@"SELECT appID, appTimeSlot, ptLastName, ptFirstName, ptMiddleName FROM " + txtbxSelectedDate.Text + ";", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridAppointment.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));    
            }

        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            bool exists;
            try
            {
                connection.Open();
                command = new MySqlCommand(@"SELECT * FROM information_schema.tables WHERE table_schema = 'appointments' AND table_name = " + txtbxSelectedDate.Text + ");", connection);
                exists = (int)command.ExecuteScalar() == 1;
            }
            catch
            {
                try
                {
                    exists = true;
                    command = new MySqlCommand(@"SELECT 1 FROM " + txtbxSelectedDate.Text + " WHERE 1 = 0", connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Appointment Date Already Exists!", "Error");
                }
                catch
                {
                    exists = false;
                    createTable();
                }
            }
            finally
            {
                connection.Close();
            }
        }

        private void calendarSystem_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }

        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            bool exists;
            try
            {
                connection.Open();
                command = new MySqlCommand(@"SELECT * FROM information_schema.tables WHERE table_schema = 'appointments' AND table_name = " + txtbxSelectedDate.Text + ");", connection);
                exists = (int)command.ExecuteScalar() == 1;
            }
            catch
            {
                try
                {
                    exists = true;
                    command = new MySqlCommand(@"SELECT 1 FROM " + txtbxSelectedDate.Text + " WHERE 1 = 0", connection);
                    command.ExecuteNonQuery();
                    LoadTable();
                }
                catch
                {
                    exists = false;
                    MessageBox.Show("Appointment Date Does Not Exist!", "Error");
                    Console.WriteLine("CHECK-4");
                }
            } finally
            {
                connection.Close();
            }
        }

        private void dataGridAppointment_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridAppointment.SelectedRows.Count > 0)
            {
                txtBoxPatientID.Text =
                     dataGridAppointment.SelectedRows[0].Cells[0].Value.ToString();
                txtBoxPatientLName.Text =
                    dataGridAppointment.SelectedRows[0].Cells[2].Value.ToString();
                txtBoxPatientFName.Text =
                    dataGridAppointment.SelectedRows[0].Cells[3].Value.ToString();
                txtBoxPatientMName.Text =
                    dataGridAppointment.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void ClearAll()
        {
            txtBoxPatientFName.Clear();
            txtBoxPatientLName.Clear();
            txtBoxPatientMName.Clear();
            txtBoxPatientID.Clear();
        }

        private void btnEditAppoint_Click(object sender, EventArgs e)
        {
            if (dataGridAppointment.SelectedRows.Count > 0)
            {
                string sqlStatement = (@"UPDATE `" + txtbxSelectedDate.Text + "` SET `ptLastName`='" + txtBoxPatientLName.Text + "',`ptFirstName`='" + txtBoxPatientFName.Text + "',`ptMiddleName`='" + txtBoxPatientMName.Text + "' WHERE appID = '" + txtBoxPatientID.Text + "';");
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    Console.WriteLine("Connection Is Open");
                    MySqlCommand command = new MySqlCommand(sqlStatement, connection);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Table Edited");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    LoadTable();
                    ClearAll();
                    MessageBox.Show("Appointment Added", "Success");
                    connection.Close();
                    Console.WriteLine("Connection Is Closed");
                }
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            string sqlStatement = (@"DROP TABLE " + txtbxSelectedDate.Text + ";");
            MessageBox.Show("Table Deleted", "Success!");

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                Console.WriteLine("Connection Is Open");
                MySqlCommand command = new MySqlCommand(sqlStatement, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Table Created");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dataGridAppointment.Rows.Clear();
                connection.Close();
                Console.WriteLine("Connection Is Closed");
            }
        }

        private void btnChooseHH_Click(object sender, EventArgs e)
        {
            using (Form2 frm2 = new Form2())
            {          
               frm2.ShowDialog();
               txtBoxHouseholdTag.Text = frm2.sendHouseholdName;
            }
        }

        private void btnChooseHHM_Click(object sender, EventArgs e)
        {
            using (Form3 frm3 = new Form3())

            {

                frm3.householdTag = txtBoxHouseholdTag.Text;
                frm3.ShowDialog();

            }
        }
        private void txtBoxHouseholdTag_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxHouseholdTag.Text.Length > 0)
            {
                btnChooseHHM.Enabled= true;
            } else
            {
                btnChooseHHM.Enabled= false;
            }
        }
    }
}
