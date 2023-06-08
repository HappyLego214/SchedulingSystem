using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SchedulingSystem
{
    public partial class Form2 : Form
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

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
        private void LoadTable()
        {
            connection.Open();
            dataGridHousehold.Rows.Clear();
            command = new MySqlCommand(@"SELECT `householdName`, `hhHeadFname`, `hhHeadMname`, `hhHeadLname`, `hhHeadEmployer`, `hhHeadInsurance`, `hhHeadWorkNumber`, `hHHeadHomeNumber` FROM householdlist;", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridHousehold.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
            }
            connection.Close();
        }

        private void btnEditHousehold_Click(object sender, EventArgs e)
        {
            if (dataGridHousehold.SelectedRows.Count > 0)
            {
                connection.Open();
                command = new MySqlCommand("UPDATE `householdlist` " +
                 "SET hhHeadFname = '" + txtBoxHHHeadFName.Text + "', " +
                 "hhHeadMname = '" + txtBoxHHHeadMName.Text + "', " +
                 "hhHeadLname = '" + txtBoxHHHeadLName.Text + "', " +
                 "hhHeadEmployer = '" + txtBoxHHHeadEmployer.Text + "', " +
                 "hhHeadInsurance = '" + txtBoxHHHeadInsurance.Text + "', " +
                 "hhHeadWorkNumber = '" + txtBoxHHHeadWorkNumber.Text + "', " +
                 "hHHeadHomeNumber = '" + txtBoxHHHeadHomeNumber.Text + "'" +
                 "WHERE householdName = '" + txtBoxHHName.Text + "';", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Edit Succesful!", "Success!");
                LoadTable();
                ClearAll();
            }
        }

        private void ClearAll()
        {
            txtBoxHHHeadEmployer.Clear();
            txtBoxHHHeadFName.Clear();
            txtBoxHHHeadHomeNumber.Clear();
            txtBoxHHHeadInsurance.Clear();
            txtBoxHHHeadLName.Clear();
            txtBoxHHHeadMName.Clear();
            txtBoxHHHeadWorkNumber.Clear();
            txtBoxHHName.Clear();
        }

        private void btnAddHousehold_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new MySqlCommand("INSERT INTO `householdlist`(`householdName`, `hhHeadFname`, `hhHeadMname`, `hhHeadLname`, `hhHeadEmployer`, `hhHeadInsurance`, `hhHeadWorkNumber`, `hHHeadHomeNumber`)" +
                "VALUES ('" +txtBoxHHHeadLName.Text + "','" + txtBoxHHHeadFName.Text + "','" + txtBoxHHHeadMName.Text + "','" + txtBoxHHHeadLName.Text + "','" + txtBoxHHHeadEmployer.Text + "','" + txtBoxHHHeadInsurance.Text + "','" + txtBoxHHHeadWorkNumber.Text + "','" + txtBoxHHHeadHomeNumber.Text + "');", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("v", "Success!");
            LoadTable();
            ClearAll();
        }

        public string sendHouseholdName
        {
            get { return txtBoxHHName.Text; }
        }

        private void dataGridHousehold_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridHousehold.SelectedRows.Count > 0) 
            {
                txtBoxHHName.Text =
                    dataGridHousehold.SelectedRows[0].Cells[0].Value.ToString();
                txtBoxHHHeadFName.Text =
                    dataGridHousehold.SelectedRows[0].Cells[1].Value.ToString();
                txtBoxHHHeadMName.Text =
                    dataGridHousehold.SelectedRows[0].Cells[2].Value.ToString();
                txtBoxHHHeadLName.Text =
                    dataGridHousehold.SelectedRows[0].Cells[3].Value.ToString();
                txtBoxHHHeadEmployer.Text =
                    dataGridHousehold.SelectedRows[0].Cells[4].Value.ToString();
                txtBoxHHHeadInsurance.Text =
                    dataGridHousehold.SelectedRows[0].Cells[5].Value.ToString();
                txtBoxHHHeadWorkNumber.Text =
                    dataGridHousehold.SelectedRows[0].Cells[6].Value.ToString();
                txtBoxHHHeadHomeNumber.Text =
                    dataGridHousehold.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        private void btnChooseHousehold_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
