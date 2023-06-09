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
using System.Security.Cryptography.X509Certificates;

namespace SchedulingSystem
{
    public partial class Form3 : Form
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

        public string householdTag { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridHouseholdMember_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void LoadTable()
        {
            connection.Open();
            dataGridHouseholdMember.Rows.Clear();
            command = new MySqlCommand(@"SELECT `memberID`, `hhmFName`, `hhmMName`, `hhmLName`, DATE_FORMAT(hhmBirth, '%Y / %m / %d'), `hhmRelation` FROM " + txtBoxHHTag.Text+ " ;", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridHouseholdMember.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
            }
            connection.Close();
        }

        private void ClearAll()
        {
            txtBoxMemberFName.Clear();
            txtBoxMemberMName.Clear();
            txtBoxMemberID.Clear();
            txtBoxMemberLName.Clear();
            txtBoxBirthdate.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtBoxHHTag.Text = "household" + householdTag.ToLower();
            LoadTable();
        }
    }
}
