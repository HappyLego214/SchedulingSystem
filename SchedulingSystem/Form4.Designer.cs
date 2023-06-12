namespace SchedulingSystem
{
    partial class Form4
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
            this.dataGridMedicalPrac = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMPLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxMPMName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxMPFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMPID = new System.Windows.Forms.TextBox();
            this.txtBoxMPOccup = new System.Windows.Forms.TextBox();
            this.btnChooseHousehold = new System.Windows.Forms.Button();
            this.btnEditHousehold = new System.Windows.Forms.Button();
            this.btnAddHousehold = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicalPrac)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMedicalPrac
            // 
            this.dataGridMedicalPrac.AllowUserToAddRows = false;
            this.dataGridMedicalPrac.AllowUserToDeleteRows = false;
            this.dataGridMedicalPrac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedicalPrac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.mpFirstName,
            this.mpMiddleName,
            this.mpLastName,
            this.mpField});
            this.dataGridMedicalPrac.Location = new System.Drawing.Point(456, 1);
            this.dataGridMedicalPrac.Name = "dataGridMedicalPrac";
            this.dataGridMedicalPrac.ReadOnly = true;
            this.dataGridMedicalPrac.Size = new System.Drawing.Size(784, 861);
            this.dataGridMedicalPrac.TabIndex = 1;
            this.dataGridMedicalPrac.SelectionChanged += new System.EventHandler(this.dataGridMedicalPrac_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Medical Practitioner - Occupation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Medical Practitioner - Last Name:";
            // 
            // txtBoxMPLName
            // 
            this.txtBoxMPLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMPLName.Location = new System.Drawing.Point(31, 333);
            this.txtBoxMPLName.Name = "txtBoxMPLName";
            this.txtBoxMPLName.Size = new System.Drawing.Size(291, 30);
            this.txtBoxMPLName.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Medical Practitioner - Middle Name:";
            // 
            // txtBoxMPMName
            // 
            this.txtBoxMPMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMPMName.Location = new System.Drawing.Point(31, 243);
            this.txtBoxMPMName.Name = "txtBoxMPMName";
            this.txtBoxMPMName.Size = new System.Drawing.Size(291, 30);
            this.txtBoxMPMName.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Medical Practitioner - First Name:";
            // 
            // txtBoxMPFName
            // 
            this.txtBoxMPFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMPFName.Location = new System.Drawing.Point(31, 155);
            this.txtBoxMPFName.Name = "txtBoxMPFName";
            this.txtBoxMPFName.Size = new System.Drawing.Size(291, 30);
            this.txtBoxMPFName.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Medical Practitioner - ID:";
            // 
            // txtBoxMPID
            // 
            this.txtBoxMPID.Enabled = false;
            this.txtBoxMPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMPID.Location = new System.Drawing.Point(31, 64);
            this.txtBoxMPID.Name = "txtBoxMPID";
            this.txtBoxMPID.Size = new System.Drawing.Size(291, 30);
            this.txtBoxMPID.TabIndex = 27;
            // 
            // txtBoxMPOccup
            // 
            this.txtBoxMPOccup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMPOccup.Location = new System.Drawing.Point(31, 431);
            this.txtBoxMPOccup.Name = "txtBoxMPOccup";
            this.txtBoxMPOccup.Size = new System.Drawing.Size(291, 30);
            this.txtBoxMPOccup.TabIndex = 36;
            // 
            // btnChooseHousehold
            // 
            this.btnChooseHousehold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseHousehold.Location = new System.Drawing.Point(210, 500);
            this.btnChooseHousehold.Name = "btnChooseHousehold";
            this.btnChooseHousehold.Size = new System.Drawing.Size(152, 143);
            this.btnChooseHousehold.TabIndex = 39;
            this.btnChooseHousehold.Text = "CHOOSE DOCTOR";
            this.btnChooseHousehold.UseVisualStyleBackColor = true;
            this.btnChooseHousehold.Click += new System.EventHandler(this.btnChooseHousehold_Click);
            // 
            // btnEditHousehold
            // 
            this.btnEditHousehold.Enabled = false;
            this.btnEditHousehold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditHousehold.Location = new System.Drawing.Point(33, 586);
            this.btnEditHousehold.Name = "btnEditHousehold";
            this.btnEditHousehold.Size = new System.Drawing.Size(152, 57);
            this.btnEditHousehold.TabIndex = 38;
            this.btnEditHousehold.Text = "EDIT DOCTOR";
            this.btnEditHousehold.UseVisualStyleBackColor = true;
            // 
            // btnAddHousehold
            // 
            this.btnAddHousehold.Enabled = false;
            this.btnAddHousehold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHousehold.Location = new System.Drawing.Point(32, 500);
            this.btnAddHousehold.Name = "btnAddHousehold";
            this.btnAddHousehold.Size = new System.Drawing.Size(152, 57);
            this.btnAddHousehold.TabIndex = 37;
            this.btnAddHousehold.Text = "ADD DOCTOR";
            this.btnAddHousehold.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // mpFirstName
            // 
            this.mpFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mpFirstName.HeaderText = "First Name";
            this.mpFirstName.Name = "mpFirstName";
            this.mpFirstName.ReadOnly = true;
            // 
            // mpMiddleName
            // 
            this.mpMiddleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mpMiddleName.HeaderText = "Middle Name";
            this.mpMiddleName.Name = "mpMiddleName";
            this.mpMiddleName.ReadOnly = true;
            // 
            // mpLastName
            // 
            this.mpLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mpLastName.HeaderText = "Last Name";
            this.mpLastName.Name = "mpLastName";
            this.mpLastName.ReadOnly = true;
            // 
            // mpField
            // 
            this.mpField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mpField.HeaderText = "Occupation";
            this.mpField.Name = "mpField";
            this.mpField.ReadOnly = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 865);
            this.Controls.Add(this.btnChooseHousehold);
            this.Controls.Add(this.btnEditHousehold);
            this.Controls.Add(this.btnAddHousehold);
            this.Controls.Add(this.txtBoxMPOccup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxMPLName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxMPMName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMPFName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxMPID);
            this.Controls.Add(this.dataGridMedicalPrac);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicalPrac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMedicalPrac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxMPLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxMPMName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxMPFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMPID;
        private System.Windows.Forms.TextBox txtBoxMPOccup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpField;
        private System.Windows.Forms.Button btnChooseHousehold;
        private System.Windows.Forms.Button btnEditHousehold;
        private System.Windows.Forms.Button btnAddHousehold;
    }
}