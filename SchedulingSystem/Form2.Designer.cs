namespace SchedulingSystem
{
    partial class Form2
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
            this.dataGridHousehold = new System.Windows.Forms.DataGridView();
            this.householdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hhHeadFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hhHeadMname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hhHeadLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hhHeadInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hhHeadEmployer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hhHeadWorkNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hhHeadHomeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditAppoint = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPatientCN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPatientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPatientMName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPatientFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPatientLName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHousehold)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHousehold
            // 
            this.dataGridHousehold.AllowUserToAddRows = false;
            this.dataGridHousehold.AllowUserToDeleteRows = false;
            this.dataGridHousehold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHousehold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.householdName,
            this.hhHeadFname,
            this.hhHeadMname,
            this.hhHeadLname,
            this.hhHeadInsurance,
            this.hhHeadEmployer,
            this.hhHeadWorkNumber,
            this.hhHeadHomeNumber});
            this.dataGridHousehold.Location = new System.Drawing.Point(383, 0);
            this.dataGridHousehold.Name = "dataGridHousehold";
            this.dataGridHousehold.ReadOnly = true;
            this.dataGridHousehold.Size = new System.Drawing.Size(1295, 861);
            this.dataGridHousehold.TabIndex = 0;
            // 
            // householdName
            // 
            this.householdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.householdName.HeaderText = "Household Name";
            this.householdName.Name = "householdName";
            this.householdName.ReadOnly = true;
            // 
            // hhHeadFname
            // 
            this.hhHeadFname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hhHeadFname.HeaderText = "Household Head - First Name";
            this.hhHeadFname.Name = "hhHeadFname";
            this.hhHeadFname.ReadOnly = true;
            // 
            // hhHeadMname
            // 
            this.hhHeadMname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hhHeadMname.HeaderText = "Household Head - Middle Name";
            this.hhHeadMname.Name = "hhHeadMname";
            this.hhHeadMname.ReadOnly = true;
            // 
            // hhHeadLname
            // 
            this.hhHeadLname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hhHeadLname.HeaderText = "Household Head - Last Name";
            this.hhHeadLname.Name = "hhHeadLname";
            this.hhHeadLname.ReadOnly = true;
            // 
            // hhHeadInsurance
            // 
            this.hhHeadInsurance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hhHeadInsurance.HeaderText = "Household Head - Insurance";
            this.hhHeadInsurance.Name = "hhHeadInsurance";
            this.hhHeadInsurance.ReadOnly = true;
            // 
            // hhHeadEmployer
            // 
            this.hhHeadEmployer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hhHeadEmployer.HeaderText = "Household Head - Employer";
            this.hhHeadEmployer.Name = "hhHeadEmployer";
            this.hhHeadEmployer.ReadOnly = true;
            // 
            // hhHeadWorkNumber
            // 
            this.hhHeadWorkNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hhHeadWorkNumber.HeaderText = "Household Head - Work Number";
            this.hhHeadWorkNumber.Name = "hhHeadWorkNumber";
            this.hhHeadWorkNumber.ReadOnly = true;
            // 
            // hhHeadHomeNumber
            // 
            this.hhHeadHomeNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hhHeadHomeNumber.HeaderText = "Household Head - Home Number";
            this.hhHeadHomeNumber.Name = "hhHeadHomeNumber";
            this.hhHeadHomeNumber.ReadOnly = true;
            // 
            // btnEditAppoint
            // 
            this.btnEditAppoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAppoint.Location = new System.Drawing.Point(27, 780);
            this.btnEditAppoint.Name = "btnEditAppoint";
            this.btnEditAppoint.Size = new System.Drawing.Size(152, 57);
            this.btnEditAppoint.TabIndex = 27;
            this.btnEditAppoint.Text = "EDIT APPOINTMENT";
            this.btnEditAppoint.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Household Head - Insurance:";
            // 
            // txtBoxPatientCN
            // 
            this.txtBoxPatientCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPatientCN.Location = new System.Drawing.Point(30, 417);
            this.txtBoxPatientCN.Name = "txtBoxPatientCN";
            this.txtBoxPatientCN.Size = new System.Drawing.Size(291, 30);
            this.txtBoxPatientCN.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Household Head - Last Name:";
            // 
            // txtBoxPatientID
            // 
            this.txtBoxPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPatientID.Location = new System.Drawing.Point(30, 328);
            this.txtBoxPatientID.Name = "txtBoxPatientID";
            this.txtBoxPatientID.Size = new System.Drawing.Size(291, 30);
            this.txtBoxPatientID.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Household Head - Middle Name:";
            // 
            // txtBoxPatientMName
            // 
            this.txtBoxPatientMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPatientMName.Location = new System.Drawing.Point(30, 238);
            this.txtBoxPatientMName.Name = "txtBoxPatientMName";
            this.txtBoxPatientMName.Size = new System.Drawing.Size(291, 30);
            this.txtBoxPatientMName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Household Head - First Name:";
            // 
            // txtBoxPatientFName
            // 
            this.txtBoxPatientFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPatientFName.Location = new System.Drawing.Point(30, 150);
            this.txtBoxPatientFName.Name = "txtBoxPatientFName";
            this.txtBoxPatientFName.Size = new System.Drawing.Size(291, 30);
            this.txtBoxPatientFName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Household Name:";
            // 
            // txtBoxPatientLName
            // 
            this.txtBoxPatientLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPatientLName.Location = new System.Drawing.Point(30, 59);
            this.txtBoxPatientLName.Name = "txtBoxPatientLName";
            this.txtBoxPatientLName.Size = new System.Drawing.Size(291, 30);
            this.txtBoxPatientLName.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Household Head - Employer:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(30, 504);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 30);
            this.textBox1.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(198, 780);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 57);
            this.button1.TabIndex = 30;
            this.button1.Text = "EDIT APPOINTMENT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Household Head - Work Number:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(30, 600);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(291, 30);
            this.textBox2.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 663);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(307, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Household Head - Home Number:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(30, 703);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(291, 30);
            this.textBox3.TabIndex = 33;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 958);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.dataGridHousehold);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHousehold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHousehold;
        private System.Windows.Forms.DataGridViewTextBoxColumn householdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hhHeadFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn hhHeadMname;
        private System.Windows.Forms.DataGridViewTextBoxColumn hhHeadLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn hhHeadInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn hhHeadEmployer;
        private System.Windows.Forms.DataGridViewTextBoxColumn hhHeadWorkNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn hhHeadHomeNumber;
        private System.Windows.Forms.Button btnEditAppoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxPatientCN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxPatientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPatientMName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPatientFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPatientLName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
    }
}