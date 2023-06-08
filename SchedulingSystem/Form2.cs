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
    }
}
