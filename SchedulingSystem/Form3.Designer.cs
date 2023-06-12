namespace SchedulingSystem
{
    partial class Form3
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
            this.dataGridHouseholdMember = new System.Windows.Forms.DataGridView();
            this.memberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hhmFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hhmMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hhmLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hhmBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hhmRelation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxRelationship = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxBirthdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMemberLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxMemberMName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxMemberFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMemberID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxHHTag = new System.Windows.Forms.TextBox();
            this.btnChooseMember = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHouseholdMember)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHouseholdMember
            // 
            this.dataGridHouseholdMember.AllowUserToAddRows = false;
            this.dataGridHouseholdMember.AllowUserToDeleteRows = false;
            this.dataGridHouseholdMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHouseholdMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberID,
            this.hhmFName,
            this.hhmMName,
            this.hhmLName,
            this.hhmBirth,
            this.hhmRelation});
            this.dataGridHouseholdMember.Location = new System.Drawing.Point(491, 12);
            this.dataGridHouseholdMember.Name = "dataGridHouseholdMember";
            this.dataGridHouseholdMember.ReadOnly = true;
            this.dataGridHouseholdMember.Size = new System.Drawing.Size(863, 860);
            this.dataGridHouseholdMember.TabIndex = 1;
            this.dataGridHouseholdMember.SelectionChanged += new System.EventHandler(this.dataGridHouseholdMember_SelectionChanged);
            // 
            // memberID
            // 
            this.memberID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.memberID.HeaderText = "Household Member ID";
            this.memberID.Name = "memberID";
            this.memberID.ReadOnly = true;
            // 
            // hhmFName
            // 
            this.hhmFName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hhmFName.HeaderText = "First Name";
            this.hhmFName.Name = "hhmFName";
            this.hhmFName.ReadOnly = true;
            // 
            // hhmMName
            // 
            this.hhmMName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hhmMName.HeaderText = "Middle Name";
            this.hhmMName.Name = "hhmMName";
            this.hhmMName.ReadOnly = true;
            // 
            // hhmLName
            // 
            this.hhmLName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hhmLName.HeaderText = "Last Name";
            this.hhmLName.Name = "hhmLName";
            this.hhmLName.ReadOnly = true;
            // 
            // hhmBirth
            // 
            this.hhmBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hhmBirth.HeaderText = "Birthdate";
            this.hhmBirth.Name = "hhmBirth";
            this.hhmBirth.ReadOnly = true;
            // 
            // hhmRelation
            // 
            this.hhmRelation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hhmRelation.HeaderText = "Relationship";
            this.hhmRelation.Name = "hhmRelation";
            this.hhmRelation.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 563);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Member - Relationship";
            // 
            // txtBoxRelationship
            // 
            this.txtBoxRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRelationship.Location = new System.Drawing.Point(41, 603);
            this.txtBoxRelationship.Name = "txtBoxRelationship";
            this.txtBoxRelationship.Size = new System.Drawing.Size(291, 30);
            this.txtBoxRelationship.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Member - Birthdate";
            // 
            // txtBoxBirthdate
            // 
            this.txtBoxBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBirthdate.Location = new System.Drawing.Point(41, 509);
            this.txtBoxBirthdate.Name = "txtBoxBirthdate";
            this.txtBoxBirthdate.Size = new System.Drawing.Size(291, 30);
            this.txtBoxBirthdate.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Member - Last Name:";
            // 
            // txtBoxMemberLName
            // 
            this.txtBoxMemberLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMemberLName.Location = new System.Drawing.Point(41, 420);
            this.txtBoxMemberLName.Name = "txtBoxMemberLName";
            this.txtBoxMemberLName.Size = new System.Drawing.Size(291, 30);
            this.txtBoxMemberLName.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Member - Middle Name:";
            // 
            // txtBoxMemberMName
            // 
            this.txtBoxMemberMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMemberMName.Location = new System.Drawing.Point(41, 330);
            this.txtBoxMemberMName.Name = "txtBoxMemberMName";
            this.txtBoxMemberMName.Size = new System.Drawing.Size(291, 30);
            this.txtBoxMemberMName.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Member - First Name:";
            // 
            // txtBoxMemberFName
            // 
            this.txtBoxMemberFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMemberFName.Location = new System.Drawing.Point(41, 242);
            this.txtBoxMemberFName.Name = "txtBoxMemberFName";
            this.txtBoxMemberFName.Size = new System.Drawing.Size(291, 30);
            this.txtBoxMemberFName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Household Member ID:";
            // 
            // txtBoxMemberID
            // 
            this.txtBoxMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMemberID.Location = new System.Drawing.Point(41, 151);
            this.txtBoxMemberID.Name = "txtBoxMemberID";
            this.txtBoxMemberID.Size = new System.Drawing.Size(291, 30);
            this.txtBoxMemberID.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "Household Name:";
            // 
            // txtBoxHHTag
            // 
            this.txtBoxHHTag.Enabled = false;
            this.txtBoxHHTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHHTag.Location = new System.Drawing.Point(41, 61);
            this.txtBoxHHTag.Name = "txtBoxHHTag";
            this.txtBoxHHTag.Size = new System.Drawing.Size(291, 30);
            this.txtBoxHHTag.TabIndex = 42;
            // 
            // btnChooseMember
            // 
            this.btnChooseMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseMember.Location = new System.Drawing.Point(221, 668);
            this.btnChooseMember.Name = "btnChooseMember";
            this.btnChooseMember.Size = new System.Drawing.Size(152, 143);
            this.btnChooseMember.TabIndex = 46;
            this.btnChooseMember.Text = "CHOOSE MEMBER";
            this.btnChooseMember.UseVisualStyleBackColor = true;
            this.btnChooseMember.Click += new System.EventHandler(this.btnChooseMember_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMember.Location = new System.Drawing.Point(44, 754);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(152, 57);
            this.btnEditMember.TabIndex = 45;
            this.btnEditMember.Text = "EDIT MEMBER";
            this.btnEditMember.UseVisualStyleBackColor = true;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Location = new System.Drawing.Point(43, 668);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(152, 57);
            this.btnAddMember.TabIndex = 44;
            this.btnAddMember.Text = "ADD MEMBER";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 884);
            this.Controls.Add(this.btnChooseMember);
            this.Controls.Add(this.btnEditMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxHHTag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxRelationship);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxBirthdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxMemberLName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxMemberMName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMemberFName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxMemberID);
            this.Controls.Add(this.dataGridHouseholdMember);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHouseholdMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHouseholdMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hhmFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hhmMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hhmLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hhmBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn hhmRelation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxRelationship;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxBirthdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxMemberLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxMemberMName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxMemberFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMemberID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxHHTag;
        private System.Windows.Forms.Button btnChooseMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Button btnAddMember;
    }
}