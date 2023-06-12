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
            this.btnAddHousehold = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxHHHeadInsurance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxHHHeadLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxHHHeadMName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxHHHeadFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxHHName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxHHHeadEmployer = new System.Windows.Forms.TextBox();
            this.btnEditHousehold = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxHHHeadWorkNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxHHHeadHomeNumber = new System.Windows.Forms.TextBox();
            this.btnChooseHousehold = new System.Windows.Forms.Button();
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
            this.dataGridHousehold.Location = new System.Drawing.Point(383, 19);
            this.dataGridHousehold.Name = "dataGridHousehold";
            this.dataGridHousehold.ReadOnly = true;
            this.dataGridHousehold.Size = new System.Drawing.Size(1261, 861);
            this.dataGridHousehold.TabIndex = 0;
            this.dataGridHousehold.SelectionChanged += new System.EventHandler(this.dataGridHousehold_SelectionChanged);
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
            // btnAddHousehold
            // 
            this.btnAddHousehold.Enabled = false;
            this.btnAddHousehold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHousehold.Location = new System.Drawing.Point(29, 758);
            this.btnAddHousehold.Name = "btnAddHousehold";
            this.btnAddHousehold.Size = new System.Drawing.Size(152, 57);
            this.btnAddHousehold.TabIndex = 27;
            this.btnAddHousehold.Text = "ADD HOUSEHOLD";
            this.btnAddHousehold.UseVisualStyleBackColor = true;
            this.btnAddHousehold.Click += new System.EventHandler(this.btnAddHousehold_Click);
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
            // txtBoxHHHeadInsurance
            // 
            this.txtBoxHHHeadInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHHHeadInsurance.Location = new System.Drawing.Point(30, 417);
            this.txtBoxHHHeadInsurance.Name = "txtBoxHHHeadInsurance";
            this.txtBoxHHHeadInsurance.Size = new System.Drawing.Size(291, 30);
            this.txtBoxHHHeadInsurance.TabIndex = 25;
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
            // txtBoxHHHeadLName
            // 
            this.txtBoxHHHeadLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHHHeadLName.Location = new System.Drawing.Point(30, 328);
            this.txtBoxHHHeadLName.Name = "txtBoxHHHeadLName";
            this.txtBoxHHHeadLName.Size = new System.Drawing.Size(291, 30);
            this.txtBoxHHHeadLName.TabIndex = 23;
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
            // txtBoxHHHeadMName
            // 
            this.txtBoxHHHeadMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHHHeadMName.Location = new System.Drawing.Point(30, 238);
            this.txtBoxHHHeadMName.Name = "txtBoxHHHeadMName";
            this.txtBoxHHHeadMName.Size = new System.Drawing.Size(291, 30);
            this.txtBoxHHHeadMName.TabIndex = 21;
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
            // txtBoxHHHeadFName
            // 
            this.txtBoxHHHeadFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHHHeadFName.Location = new System.Drawing.Point(30, 150);
            this.txtBoxHHHeadFName.Name = "txtBoxHHHeadFName";
            this.txtBoxHHHeadFName.Size = new System.Drawing.Size(291, 30);
            this.txtBoxHHHeadFName.TabIndex = 19;
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
            // txtBoxHHName
            // 
            this.txtBoxHHName.Enabled = false;
            this.txtBoxHHName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHHName.Location = new System.Drawing.Point(30, 59);
            this.txtBoxHHName.Name = "txtBoxHHName";
            this.txtBoxHHName.Size = new System.Drawing.Size(291, 30);
            this.txtBoxHHName.TabIndex = 17;
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
            // txtBoxHHHeadEmployer
            // 
            this.txtBoxHHHeadEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHHHeadEmployer.Location = new System.Drawing.Point(30, 504);
            this.txtBoxHHHeadEmployer.Name = "txtBoxHHHeadEmployer";
            this.txtBoxHHHeadEmployer.Size = new System.Drawing.Size(291, 30);
            this.txtBoxHHHeadEmployer.TabIndex = 28;
            // 
            // btnEditHousehold
            // 
            this.btnEditHousehold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditHousehold.Location = new System.Drawing.Point(30, 844);
            this.btnEditHousehold.Name = "btnEditHousehold";
            this.btnEditHousehold.Size = new System.Drawing.Size(152, 57);
            this.btnEditHousehold.TabIndex = 30;
            this.btnEditHousehold.Text = "EDIT HOUSEHOLD";
            this.btnEditHousehold.UseVisualStyleBackColor = true;
            this.btnEditHousehold.Click += new System.EventHandler(this.btnEditHousehold_Click);
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
            // txtBoxHHHeadWorkNumber
            // 
            this.txtBoxHHHeadWorkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHHHeadWorkNumber.Location = new System.Drawing.Point(30, 600);
            this.txtBoxHHHeadWorkNumber.Name = "txtBoxHHHeadWorkNumber";
            this.txtBoxHHHeadWorkNumber.Size = new System.Drawing.Size(291, 30);
            this.txtBoxHHHeadWorkNumber.TabIndex = 31;
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
            // txtBoxHHHeadHomeNumber
            // 
            this.txtBoxHHHeadHomeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHHHeadHomeNumber.Location = new System.Drawing.Point(30, 703);
            this.txtBoxHHHeadHomeNumber.Name = "txtBoxHHHeadHomeNumber";
            this.txtBoxHHHeadHomeNumber.Size = new System.Drawing.Size(291, 30);
            this.txtBoxHHHeadHomeNumber.TabIndex = 33;
            // 
            // btnChooseHousehold
            // 
            this.btnChooseHousehold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseHousehold.Location = new System.Drawing.Point(207, 758);
            this.btnChooseHousehold.Name = "btnChooseHousehold";
            this.btnChooseHousehold.Size = new System.Drawing.Size(152, 143);
            this.btnChooseHousehold.TabIndex = 36;
            this.btnChooseHousehold.Text = "CHOOSE HOUSEHOLD";
            this.btnChooseHousehold.UseVisualStyleBackColor = true;
            this.btnChooseHousehold.Click += new System.EventHandler(this.btnChooseHousehold_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 958);
            this.Controls.Add(this.btnChooseHousehold);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxHHHeadHomeNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxHHHeadWorkNumber);
            this.Controls.Add(this.btnEditHousehold);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxHHHeadEmployer);
            this.Controls.Add(this.btnAddHousehold);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxHHHeadInsurance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxHHHeadLName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxHHHeadMName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxHHHeadFName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxHHName);
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
        private System.Windows.Forms.Button btnAddHousehold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxHHHeadInsurance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxHHHeadLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxHHHeadMName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxHHHeadFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxHHName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxHHHeadEmployer;
        private System.Windows.Forms.Button btnEditHousehold;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxHHHeadWorkNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxHHHeadHomeNumber;
        private System.Windows.Forms.Button btnChooseHousehold;
    }
}