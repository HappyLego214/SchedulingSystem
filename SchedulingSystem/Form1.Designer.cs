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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxServiceCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxSCDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxAppID = new System.Windows.Forms.TextBox();
            this.btnEditAppoint = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChooseHH = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxHMName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxHouseholdTag = new System.Windows.Forms.TextBox();
            this.btnChooseHHM = new System.Windows.Forms.Button();
            this.btnAppointPatient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSelectedDoc = new System.Windows.Forms.TextBox();
            this.dataGridAppointments = new System.Windows.Forms.DataGridView();
            this.appID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appTimeSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptServiceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptServeDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChooseMP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentCalendar
            // 
            this.appointmentCalendar.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.appointmentCalendar.Enabled = false;
            this.appointmentCalendar.Location = new System.Drawing.Point(18, 40);
            this.appointmentCalendar.MaxSelectionCount = 1;
            this.appointmentCalendar.Name = "appointmentCalendar";
            this.appointmentCalendar.TabIndex = 0;
            this.appointmentCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.appointmentCalendar_DateSelected);
            // 
            // txtbxSelectedDate
            // 
            this.txtbxSelectedDate.Enabled = false;
            this.txtbxSelectedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSelectedDate.Location = new System.Drawing.Point(34, 420);
            this.txtbxSelectedDate.Name = "txtbxSelectedDate";
            this.txtbxSelectedDate.Size = new System.Drawing.Size(279, 30);
            this.txtbxSelectedDate.TabIndex = 2;
            this.txtbxSelectedDate.TextChanged += new System.EventHandler(this.txtbxSelectedDate_TextChanged);
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Enabled = false;
            this.btnCreateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTable.Location = new System.Drawing.Point(34, 482);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(126, 96);
            this.btnCreateTable.TabIndex = 3;
            this.btnCreateTable.Text = "CREATE TABLE";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // btnLoadTable
            // 
            this.btnLoadTable.Enabled = false;
            this.btnLoadTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadTable.Location = new System.Drawing.Point(181, 482);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(132, 96);
            this.btnLoadTable.TabIndex = 4;
            this.btnLoadTable.Text = "LOAD TABLE";
            this.btnLoadTable.UseVisualStyleBackColor = true;
            this.btnLoadTable.Click += new System.EventHandler(this.btnLoadTable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1430, 641);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Service Code:";
            // 
            // txtBoxServiceCode
            // 
            this.txtBoxServiceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxServiceCode.Location = new System.Drawing.Point(1435, 681);
            this.txtBoxServiceCode.Name = "txtBoxServiceCode";
            this.txtBoxServiceCode.Size = new System.Drawing.Size(179, 30);
            this.txtBoxServiceCode.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1430, 736);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Service Code Description:";
            // 
            // txtBoxSCDesc
            // 
            this.txtBoxSCDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSCDesc.Location = new System.Drawing.Point(1435, 776);
            this.txtBoxSCDesc.Name = "txtBoxSCDesc";
            this.txtBoxSCDesc.Size = new System.Drawing.Size(402, 30);
            this.txtBoxSCDesc.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1055, 641);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Appointment ID:";
            // 
            // txtBoxAppID
            // 
            this.txtBoxAppID.Enabled = false;
            this.txtBoxAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAppID.Location = new System.Drawing.Point(1060, 681);
            this.txtBoxAppID.Name = "txtBoxAppID";
            this.txtBoxAppID.Size = new System.Drawing.Size(179, 30);
            this.txtBoxAppID.TabIndex = 11;
            // 
            // btnEditAppoint
            // 
            this.btnEditAppoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAppoint.Location = new System.Drawing.Point(1435, 827);
            this.btnEditAppoint.Name = "btnEditAppoint";
            this.btnEditAppoint.Size = new System.Drawing.Size(225, 57);
            this.btnEditAppoint.TabIndex = 16;
            this.btnEditAppoint.Text = "INSERT SERVICE CODE";
            this.btnEditAppoint.UseVisualStyleBackColor = true;
            this.btnEditAppoint.Click += new System.EventHandler(this.btnEditAppoint_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "DB Access Name:";
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Enabled = false;
            this.btnDeleteTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTable.Location = new System.Drawing.Point(34, 605);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(279, 57);
            this.btnDeleteTable.TabIndex = 19;
            this.btnDeleteTable.Text = "DELETE TABLE";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1419, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(400, 39);
            this.label7.TabIndex = 20;
            this.label7.Text = "SERVICE CODE / DESC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(412, 562);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(420, 39);
            this.label8.TabIndex = 21;
            this.label8.Text = "HOUSEHOLD BROWSER";
            // 
            // btnChooseHH
            // 
            this.btnChooseHH.Enabled = false;
            this.btnChooseHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseHH.Location = new System.Drawing.Point(405, 749);
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
            this.label9.Location = new System.Drawing.Point(635, 641);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Household Member Name:";
            // 
            // txtBoxHMName
            // 
            this.txtBoxHMName.Enabled = false;
            this.txtBoxHMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHMName.Location = new System.Drawing.Point(640, 681);
            this.txtBoxHMName.Name = "txtBoxHMName";
            this.txtBoxHMName.Size = new System.Drawing.Size(238, 30);
            this.txtBoxHMName.TabIndex = 24;
            this.txtBoxHMName.TextChanged += new System.EventHandler(this.txtBoxHMName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(400, 641);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Household Name:";
            // 
            // txtBoxHouseholdTag
            // 
            this.txtBoxHouseholdTag.Enabled = false;
            this.txtBoxHouseholdTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHouseholdTag.Location = new System.Drawing.Point(405, 681);
            this.txtBoxHouseholdTag.Name = "txtBoxHouseholdTag";
            this.txtBoxHouseholdTag.Size = new System.Drawing.Size(179, 30);
            this.txtBoxHouseholdTag.TabIndex = 22;
            this.txtBoxHouseholdTag.TextChanged += new System.EventHandler(this.txtBoxHouseholdTag_TextChanged);
            // 
            // btnChooseHHM
            // 
            this.btnChooseHHM.Enabled = false;
            this.btnChooseHHM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseHHM.Location = new System.Drawing.Point(640, 749);
            this.btnChooseHHM.Name = "btnChooseHHM";
            this.btnChooseHHM.Size = new System.Drawing.Size(243, 57);
            this.btnChooseHHM.TabIndex = 27;
            this.btnChooseHHM.Text = "CHOOSE HOUSEHOLD MEMBER";
            this.btnChooseHHM.UseVisualStyleBackColor = true;
            this.btnChooseHHM.Click += new System.EventHandler(this.btnChooseHHM_Click);
            // 
            // btnAppointPatient
            // 
            this.btnAppointPatient.Enabled = false;
            this.btnAppointPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointPatient.Location = new System.Drawing.Point(1060, 749);
            this.btnAppointPatient.Name = "btnAppointPatient";
            this.btnAppointPatient.Size = new System.Drawing.Size(179, 57);
            this.btnAppointPatient.TabIndex = 28;
            this.btnAppointPatient.Text = "APPOINT PATIENT";
            this.btnAppointPatient.UseVisualStyleBackColor = true;
            this.btnAppointPatient.Click += new System.EventHandler(this.btnAppointPatient_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(939, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(443, 39);
            this.label5.TabIndex = 29;
            this.label5.Text = "PATIENT APPPOINTMENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Medical Provider Last Name:";
            // 
            // txtBoxSelectedDoc
            // 
            this.txtBoxSelectedDoc.Enabled = false;
            this.txtBoxSelectedDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSelectedDoc.Location = new System.Drawing.Point(412, 420);
            this.txtBoxSelectedDoc.Name = "txtBoxSelectedDoc";
            this.txtBoxSelectedDoc.Size = new System.Drawing.Size(352, 30);
            this.txtBoxSelectedDoc.TabIndex = 30;
            this.txtBoxSelectedDoc.TextChanged += new System.EventHandler(this.txtBoxSelectedDoc_TextChanged);
            // 
            // dataGridAppointments
            // 
            this.dataGridAppointments.AllowUserToAddRows = false;
            this.dataGridAppointments.AllowUserToDeleteRows = false;
            this.dataGridAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appID,
            this.appTimeSlot,
            this.ptName,
            this.ptServiceCode,
            this.ptServeDesc});
            this.dataGridAppointments.Location = new System.Drawing.Point(818, 40);
            this.dataGridAppointments.Name = "dataGridAppointments";
            this.dataGridAppointments.ReadOnly = true;
            this.dataGridAppointments.Size = new System.Drawing.Size(1038, 450);
            this.dataGridAppointments.TabIndex = 32;
            this.dataGridAppointments.SelectionChanged += new System.EventHandler(this.dataGridAppointments_SelectionChanged);
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
            // ptName
            // 
            this.ptName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ptName.HeaderText = "Patient Name";
            this.ptName.Name = "ptName";
            this.ptName.ReadOnly = true;
            // 
            // ptServiceCode
            // 
            this.ptServiceCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ptServiceCode.HeaderText = "Service Code";
            this.ptServiceCode.Name = "ptServiceCode";
            this.ptServiceCode.ReadOnly = true;
            // 
            // ptServeDesc
            // 
            this.ptServeDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ptServeDesc.HeaderText = "Service Code Description";
            this.ptServeDesc.Name = "ptServeDesc";
            this.ptServeDesc.ReadOnly = true;
            // 
            // btnChooseMP
            // 
            this.btnChooseMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseMP.Location = new System.Drawing.Point(412, 482);
            this.btnChooseMP.Name = "btnChooseMP";
            this.btnChooseMP.Size = new System.Drawing.Size(352, 57);
            this.btnChooseMP.TabIndex = 33;
            this.btnChooseMP.Text = "CHOOSE PROVIDER";
            this.btnChooseMP.UseVisualStyleBackColor = true;
            this.btnChooseMP.Click += new System.EventHandler(this.btnChooseMP_Click);
            // 
            // calendarSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1883, 981);
            this.Controls.Add(this.btnChooseMP);
            this.Controls.Add(this.dataGridAppointments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxSelectedDoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAppointPatient);
            this.Controls.Add(this.btnChooseHHM);
            this.Controls.Add(this.btnChooseHH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxHMName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxHouseholdTag);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDeleteTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEditAppoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxAppID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxSCDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxServiceCode);
            this.Controls.Add(this.btnLoadTable);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.txtbxSelectedDate);
            this.Controls.Add(this.appointmentCalendar);
            this.Name = "calendarSystem";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.calendarSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar appointmentCalendar;
        private System.Windows.Forms.TextBox txtbxSelectedDate;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button btnLoadTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxServiceCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxSCDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxAppID;
        private System.Windows.Forms.Button btnEditAppoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChooseHH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxHMName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxHouseholdTag;
        private System.Windows.Forms.Button btnChooseHHM;
        private System.Windows.Forms.Button btnAppointPatient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSelectedDoc;
        private System.Windows.Forms.DataGridView dataGridAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn appID;
        private System.Windows.Forms.DataGridViewTextBoxColumn appTimeSlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptServiceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptServeDesc;
        private System.Windows.Forms.Button btnChooseMP;
    }
}

