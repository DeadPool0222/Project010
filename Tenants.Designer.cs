using System;

namespace C_M_House_Rental
{
    partial class Tenants
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
            this.components = new System.ComponentModel.Container();
            this.dgvTenant = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataSet1 = new C_M_House_Rental.LoginDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.Button();
            this.Rents = new System.Windows.Forms.Button();
            this.Apartments = new System.Windows.Forms.Button();
            this.Tenant = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.loginDataSet = new C_M_House_Rental.LoginDataSet();
            this.loginDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenantTableAdapter = new C_M_House_Rental.LoginDataSet1TableAdapters.TenantTableAdapter();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTenant
            // 
            this.dgvTenant.AllowUserToAddRows = false;
            this.dgvTenant.AutoGenerateColumns = false;
            this.dgvTenant.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTenant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.phoneNumDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dgvTenant.DataSource = this.tenantBindingSource;
            this.dgvTenant.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTenant.Location = new System.Drawing.Point(769, 125);
            this.dgvTenant.Name = "dgvTenant";
            this.dgvTenant.Size = new System.Drawing.Size(342, 398);
            this.dgvTenant.TabIndex = 10;
            this.dgvTenant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTenant_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneNumDataGridViewTextBoxColumn
            // 
            this.phoneNumDataGridViewTextBoxColumn.DataPropertyName = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.HeaderText = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.Name = "phoneNumDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // tenantBindingSource
            // 
            this.tenantBindingSource.DataMember = "Tenant";
            this.tenantBindingSource.DataSource = this.loginDataSet1;
            // 
            // loginDataSet1
            // 
            this.loginDataSet1.DataSetName = "LoginDataSet1";
            this.loginDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.Category);
            this.panel1.Controls.Add(this.Rents);
            this.panel1.Controls.Add(this.Apartments);
            this.panel1.Controls.Add(this.Tenant);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 617);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::C_M_House_Rental.Properties.Resources.OIP__4_;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(13, 555);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 23);
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Zilla Slab", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "C.J House Rental MS";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::C_M_House_Rental.Properties.Resources.OIP__1_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(14, 311);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 41);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::C_M_House_Rental.Properties.Resources.OIP__1_;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(14, 250);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 41);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::C_M_House_Rental.Properties.Resources.OIP__1_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(14, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 41);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::C_M_House_Rental.Properties.Resources.OIP__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(17, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.Font = new System.Drawing.Font("Zilla Slab", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(42, 555);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(125, 23);
            this.Logout.TabIndex = 7;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            // 
            // Category
            // 
            this.Category.BackColor = System.Drawing.Color.Transparent;
            this.Category.Font = new System.Drawing.Font("Zilla Slab", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(55, 329);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(125, 23);
            this.Category.TabIndex = 6;
            this.Category.Text = "Category";
            this.Category.UseVisualStyleBackColor = false;
            // 
            // Rents
            // 
            this.Rents.BackColor = System.Drawing.Color.Transparent;
            this.Rents.Font = new System.Drawing.Font("Zilla Slab", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rents.Location = new System.Drawing.Point(58, 268);
            this.Rents.Name = "Rents";
            this.Rents.Size = new System.Drawing.Size(122, 23);
            this.Rents.TabIndex = 5;
            this.Rents.Text = "Rents";
            this.Rents.UseVisualStyleBackColor = false;
            // 
            // Apartments
            // 
            this.Apartments.BackColor = System.Drawing.Color.Transparent;
            this.Apartments.Font = new System.Drawing.Font("Zilla Slab", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apartments.Location = new System.Drawing.Point(55, 217);
            this.Apartments.Name = "Apartments";
            this.Apartments.Size = new System.Drawing.Size(125, 23);
            this.Apartments.TabIndex = 4;
            this.Apartments.Text = "Apartments";
            this.Apartments.UseVisualStyleBackColor = false;
            // 
            // Tenant
            // 
            this.Tenant.BackColor = System.Drawing.Color.Transparent;
            this.Tenant.Font = new System.Drawing.Font("Zilla Slab", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tenant.Location = new System.Drawing.Point(61, 164);
            this.Tenant.Name = "Tenant";
            this.Tenant.Size = new System.Drawing.Size(122, 23);
            this.Tenant.TabIndex = 3;
            this.Tenant.Text = "Tenants";
            this.Tenant.UseVisualStyleBackColor = false;
            this.Tenant.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(184, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 55);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::C_M_House_Rental.Properties.Resources.OIP;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(1061, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(63, 42);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Zilla Slab", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tenants";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(290, 182);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(552, 182);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(159, 20);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zilla Slab", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zilla Slab", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "PhoneNumber:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Zilla Slab", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(299, 233);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(54, 19);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Zilla Slab", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(364, 233);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(66, 19);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zilla Slab", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender:";
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "LoginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginDataSetBindingSource
            // 
            this.loginDataSetBindingSource.DataSource = this.loginDataSet;
            this.loginDataSetBindingSource.Position = 0;
            // 
            // tenantTableAdapter
            // 
            this.tenantTableAdapter.ClearBeforeFill = true;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btAdd.Font = new System.Drawing.Font("Zilla Slab", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(751, 540);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(125, 38);
            this.btAdd.TabIndex = 11;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btDelete.Font = new System.Drawing.Font("Zilla Slab", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(1013, 540);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(125, 38);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btReset.Font = new System.Drawing.Font("Zilla Slab", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(882, 542);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(125, 36);
            this.btReset.TabIndex = 13;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // Tenants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 629);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgvTenant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Tenants";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Tenants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Tenant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Category;
        private System.Windows.Forms.Button Rents;
        private System.Windows.Forms.Button Apartments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource loginDataSetBindingSource;
        private LoginDataSet loginDataSet;
        private LoginDataSet1 loginDataSet1;
        private System.Windows.Forms.BindingSource tenantBindingSource;
        private LoginDataSet1TableAdapters.TenantTableAdapter tenantTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.DataGridView dgvTenant;
    }
}