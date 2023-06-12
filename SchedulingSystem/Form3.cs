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
            if (dataGridHouseholdMember.SelectedRows.Count > 0)
            {
                txtBoxMemberID.Text =
                    dataGridHouseholdMember.SelectedRows[0].Cells[0].Value.ToString();
                txtBoxMemberFName.Text =
                    dataGridHouseholdMember.SelectedRows[0].Cells[1].Value.ToString();
                txtBoxMemberMName.Text =
                    dataGridHouseholdMember.SelectedRows[0].Cells[2].Value.ToString();
                txtBoxMemberLName.Text =
                    dataGridHouseholdMember.SelectedRows[0].Cells[3].Value.ToString();
                txtBoxBirthdate.Text =
                    dataGridHouseholdMember.SelectedRows[0].Cells[4].Value.ToString();
                txtBoxRelationship.Text =
                    dataGridHouseholdMember.SelectedRows[0].Cells[5].Value.ToString();
            }
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

        private void Form3_Load(object sender, EventArgs e)
        {
            txtBoxHHTag.Text = householdTag;
            LoadTable();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new MySqlCommand("INSERT INTO " + txtBoxHHTag.Text + "(`memberID`, `hhmFName`, `hhmMName`, `hhmLName`, `hhmBirth`, `hhmRelation`) " +
                "VALUES ('" + txtBoxMemberID.Text + "','" + txtBoxMemberFName.Text + "','" + txtBoxMemberMName.Text + "','" + txtBoxMemberLName.Text + "','" + txtBoxBirthdate.Text + "','" + txtBoxRelationship.Text + "');", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("v", "Success!");
            LoadTable();
            ClearAll();
        }

        private void ClearAll()
        {
            txtBoxBirthdate.Clear();
            txtBoxMemberFName.Clear();
            txtBoxMemberID.Clear();
            txtBoxMemberLName.Clear();
            txtBoxMemberMName.Clear();
            txtBoxRelationship.Clear();
        }

        public string sendHouseholdMemberName
        {
            get { return txtBoxMemberFName.Text + " " + txtBoxMemberMName.Text[0] + ". " + txtBoxMemberLName.Text; }
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if (dataGridHouseholdMember.SelectedRows.Count > 0)
            {
                connection.Open();
                command = new MySqlCommand("UPDATE " + txtBoxHHTag.Text + " " +
                 "SET memberID = '" + txtBoxMemberID.Text + "', " +
                 "hhmFName = '" + txtBoxMemberFName.Text + "', " +
                 "hhmMName = '" + txtBoxMemberMName.Text + "', " +
                 "hhmLName = '" + txtBoxMemberLName.Text + "', " +
                 "hhmBirth = '" + txtBoxBirthdate.Text + "', " +
                 "hhmRelation = '" + txtBoxRelationship.Text + "'" +
                 "WHERE memberID = '" + txtBoxMemberID.Text + "';", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Edit Succesful!", "Success!");
                LoadTable();
                ClearAll();
            }
        }

        private void btnChooseMember_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
