namespace SchedulingSystem
{
    partial class calendarSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.appointmentCalendar = new System.Windows.Forms.MonthCalendar();
            this.txtbxSelectedDate = new System.Windows.Forms.TextBox();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.btnLoadTable = new System.Windows.Forms.Button();
            this.txtBoxPatientLName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPatientFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPatientMName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPatientID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPatientCN = new System.Windows.Forms.TextBox();
            this.btnEditAppoint = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridAppointment = new System.Windows.Forms.DataGridView();
            this.appID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appTimeSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayPanel = new System.Windows.Forms.TabControl();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChooseHH = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointment)).BeginInit();
            this.displayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentCalendar
            // 
            this.appointmentCalendar.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.appointmentCalendar.Location = new System.Drawing.Point(18, 40);
            this.appointmentCalendar.Name = "appointmentCalendar";
            this.appointmentCalendar.TabIndex = 0;
            this.appointmentCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.appointmentCalendar_DateSelected);
            // 
            // txtbxSelectedDate
            // 
            this.txtbxSelectedDate.Enabled = false;
            this.txtbxSelectedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSelectedDate.Location = new System.Drawing.Point(198, 377);
            this.txtbxSelectedDate.Name = "txtbxSelectedDate";
            this.txtbxSelectedDate.Size = new System.Drawing.Size(179, 30);
            this.txtbxSelectedDate.TabIndex = 2;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTable.Location = new System.Drawing.Point(18, 435);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(126, 57);
            this.btnCreateTable.TabIndex = 3;
            this.btnCreateTable.Text = "CREATE TABLE";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // btnLoadTable
            // 
            this.btnLoadTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadTable.Location = new System.Drawing.Point(166, 435);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(132, 57);
            this.btnLoadTable.TabIndex = 4;
            this.btnLoadTable.Text = "LOAD TABLE";
            this.btnLoadTable.UseVisualStyleBackColor = true;
            this.btnLoadTable.Click += new System.EventHandler(this.btnLoadTable_Click);
            // 
            // txtBoxPatientLName
            // 
            this.txtBoxPatientLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPatientLName.Location = new System.Drawing.Point(25, 688);
            this.txtBoxPatientLName.Name = "txtBoxPatientLName";
            this.txtBoxPatientLName.Size = new System.Drawing.Size(179, 30);
            this.txtBoxPatientLName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 648);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Patient Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 731);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Patient First Name:";
            // 
            // txtBoxPatientFName
            // 
            this.txtBoxPatientFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPatientFName.Location = new System.Drawing.Point(25, 771);
            this.txtBoxPatientFName.Name = "txtBoxPatientFName";
            this.txtBoxPatientFName.Size = new System.Drawing.Size(179, 30);
            this.txtBoxPatientFName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 819);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Patient Middle Name:";
            // 
            // txtBoxPatientMName
            // 
            this.txtBoxPatientMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPatientMName.Location = new System.Drawing.Point(25, 859);
            this.txtBoxPatientMName.Name = "txtBoxPatientMName";
            this.txtBoxPatientMName.Size = new System.Drawing.Size(179, 30);
            this.txtBoxPatientMName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 648);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Patient ID:";
            // 
            // txtBoxPatientID
            // 
            this.txtBoxPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPatientID.Location = new System.Drawing.Point(253, 688);
            this.txtBoxPatientID.Name = "txtBoxPatientID";
            this.txtBoxPatientID.Size = new System.Drawing.Size(179, 30);
            this.txtBoxPatientID.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 731);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Patient Contact Number:";
            // 
            // txtBoxPatientCN
            // 
            this.txtBoxPatientCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPatientCN.Location = new System.Drawing.Point(253, 771);
            this.txtBoxPatientCN.Name = "txtBoxPatientCN";
            this.txtBoxPatientCN.Size = new System.Drawing.Size(179, 30);
            this.txtBoxPatientCN.TabIndex = 13;
            // 
            // btnEditAppoint
            // 
            this.btnEditAppoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAppoint.Location = new System.Drawing.Point(253, 832);
            this.btnEditAppoint.Name = "btnEditAppoint";
            this.btnEditAppoint.Size = new System.Drawing.Size(179, 57);
            this.btnEditAppoint.TabIndex = 16;
            this.btnEditAppoint.Text = "EDIT APPOINTMENT";
            this.btnEditAppoint.UseVisualStyleBackColor = true;
            this.btnEditAppoint.Click += new System.EventHandler(this.btnEditAppoint_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "DB Access Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1038, 769);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Doctor 2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 757);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Appointment ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 97;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Appointment Time Slot";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Patient Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Patient First Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Patient Middle Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Patient Contact Number";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridAppointment);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1038, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doctor 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridAppointment
            // 
            this.dataGridAppointment.AllowUserToAddRows = false;
            this.dataGridAppointment.AllowUserToDeleteRows = false;
            this.dataGridAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appID,
            this.appTimeSlot,
            this.ptLastName,
            this.ptFirstName,
            this.ptMiddleName,
            this.ptContactNumber});
            this.dataGridAppointment.Location = new System.Drawing.Point(0, 0);
            this.dataGridAppointment.Name = "dataGridAppointment";
            this.dataGridAppointment.ReadOnly = true;
            this.dataGridAppointment.Size = new System.Drawing.Size(1038, 465);
            this.dataGridAppointment.TabIndex = 0;
            this.dataGridAppointment.SelectionChanged += new System.EventHandler(this.dataGridAppointment_SelectionChanged);
            // 
            // appID
            // 
            this.appID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.appID.HeaderText = "Appointment ID";
            this.appID.Name = "appID";
            this.appID.ReadOnly = true;
            this.appID.Width = 97;
            // 
            // appTimeSlot
            // 
            this.appTimeSlot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.appTimeSlot.HeaderText = "Appointment Time Slot";
            this.appTimeSlot.Name = "appTimeSlot";
            this.appTimeSlot.ReadOnly = true;
            this.appTimeSlot.Width = 110;
            // 
            // ptLastName
            // 
            this.ptLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ptLastName.HeaderText = "Patient Last Name";
            this.ptLastName.Name = "ptLastName";
            this.ptLastName.ReadOnly = true;
            // 
            // ptFirstName
            // 
            this.ptFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ptFirstName.HeaderText = "Patient First Name";
            this.ptFirstName.Name = "ptFirstName";
            this.ptFirstName.ReadOnly = true;
            // 
            // ptMiddleName
            // 
            this.ptMiddleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ptMiddleName.HeaderText = "Patient Middle Name";
            this.ptMiddleName.Name = "ptMiddleName";
            this.ptMiddleName.ReadOnly = true;
            // 
            // ptContactNumber
            // 
            this.ptContactNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ptContactNumber.HeaderText = "Patient Contact Number";
            this.ptContactNumber.Name = "ptContactNumber";
            this.ptContactNumber.ReadOnly = true;
            // 
            // displayPanel
            // 
            this.displayPanel.Controls.Add(this.tabPage1);
            this.displayPanel.Controls.Add(this.tabPage3);
            this.displayPanel.Location = new System.Drawing.Point(516, 18);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.SelectedIndex = 0;
            this.displayPanel.Size = new System.Drawing.Size(1046, 493);
            this.displayPanel.TabIndex = 1;
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTable.Location = new System.Drawing.Point(322, 435);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(132, 57);
            this.btnDeleteTable.TabIndex = 19;
            this.btnDeleteTable.Text = "DELETE TABLE";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(315, 39);
            this.label7.TabIndex = 20;
            this.label7.Text = "WALK-IN PATIENT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(871, 571);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(396, 39);
            this.label8.TabIndex = 21;
            this.label8.Text = "REGISTERED PATIENT";
            // 
            // btnChooseHH
            // 
            this.btnChooseHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseHH.Location = new System.Drawing.Point(848, 744);
            this.btnChooseHH.Name = "btnChooseHH";
            this.btnChooseHH.Size = new System.Drawing.Size(179, 57);
            this.btnChooseHH.TabIndex = 26;
            this.btnChooseHH.Text = "CHOOSE HOUSEHOLD";
            this.btnChooseHH.UseVisualStyleBackColor = true;
            this.btnChooseHH.Click += new System.EventHandler(this.btnChooseHH_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1078, 648);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Household Member:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1083, 688);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 30);
            this.textBox1.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(843, 648);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Household Name:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(848, 688);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 30);
            this.textBox2.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1083, 744);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 57);
            this.button2.TabIndex = 27;
            this.button2.Text = "CHOOSE HOUSEHOLD MEMBER";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // calendarSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 981);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnChooseHH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDeleteTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEditAppoint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxPatientCN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxPatientID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPatientMName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxPatientFName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPatientLName);
            this.Controls.Add(this.btnLoadTable);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.txtbxSelectedDate);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.appointmentCalendar);
            this.Name = "calendarSystem";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.calendarSystem_Load);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointment)).EndInit();
            this.displayPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar appointmentCalendar;
        private System.Windows.Forms.TextBox txtbxSelectedDate;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button btnLoadTable;
        private System.Windows.Forms.TextBox txtBoxPatientLName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPatientFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPatientMName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxPatientID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxPatientCN;
        private System.Windows.Forms.Button btnEditAppoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn appID;
        private System.Windows.Forms.DataGridViewTextBoxColumn appTimeSlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptContactNumber;
        private System.Windows.Forms.TabControl displayPanel;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChooseHH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
    }
}

