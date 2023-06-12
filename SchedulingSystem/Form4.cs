using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSystem
{
    public partial class Form4 : Form
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


        public Form4()
        {
            InitializeComponent();
        }
        private void LoadTable()
        {
            connection.Open();
            dataGridMedicalPrac.Rows.Clear();
            command = new MySqlCommand(@"SELECT `ID`, `mpFirstName`, `mpMiddleName`, `mpLastName`, `mpField` FROM `medicalproviders`", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridMedicalPrac.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
            }
            connection.Close();
        }

        private void dataGridMedicalPrac_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridMedicalPrac.SelectedRows.Count > 0)
            {
                txtBoxMPID.Text =
                    dataGridMedicalPrac.SelectedRows[0].Cells[0].Value.ToString();
                txtBoxMPFName.Text =
                    dataGridMedicalPrac.SelectedRows[0].Cells[1].Value.ToString();
                txtBoxMPMName.Text =
                    dataGridMedicalPrac.SelectedRows[0].Cells[2].Value.ToString();
                txtBoxMPLName.Text =
                    dataGridMedicalPrac.SelectedRows[0].Cells[3].Value.ToString();
                txtBoxMPOccup.Text =
                    dataGridMedicalPrac.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        public string sendMPLastName
        {
            get { return txtBoxMPLName.Text; }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void btnChooseHousehold_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
