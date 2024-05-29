using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace C_M_House_Rental
{
    public partial class Tenants : Form
    {
        private List<Tenant> tenant; 
        private DataTable tenantDataTable;

        public Tenants()
        {
            InitializeComponent();
            tenant = new List<Tenant>(); 
            tenantDataTable = new DataTable();

            tenantDataTable.Columns.Add("Name", typeof(string));
            tenantDataTable.Columns.Add("Phone Number", typeof(string));
            tenantDataTable.Columns.Add("Gender", typeof(string));

            dgvTenant.DataSource = tenantDataTable;
        }

        private void Tenants_Load(object sender, EventArgs e)
        {
            try 
            {
                this.tenantTableAdapter.Fill(this.loginDataSet1.Tenant);

                foreach (DataRow row in tenantDataTable.Rows)
                {
                    string phoneNumber = row["Phone Number"].ToString();
                    // Remove non-numeric characters (replace with your formatting logic)
                    phoneNumber = Regex.Replace(phoneNumber, "[^0-9]", "");
                    row["Phone Number"] = phoneNumber;
                }

                BindDataToGrid();

                // Check if any data was retrieved
                if (loginDataSet1.Tenant.Rows.Count == 0)
                {
                    MessageBox.Show("No tenants found!");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error loading tenants: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindDataToGrid()
        {
            dgvTenant.DataSource = tenantDataTable;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
           int phoneNumber =Convert.ToInt32(txtPhoneNumber.Text.Trim());
            string gender = rbMale.Checked ? "Male" : "Female";

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter name and phone number!");
                return;
            }

            // Create a new Tenant object (optional)
            Tenant newTenant = new Tenant(name, phoneNumber, gender); 

            DataRow newRow = tenantDataTable.NewRow();
            newRow["Name"] = name;
            newRow["Phone Number"] = phoneNumber; 
            newRow["Gender"] = gender;
            tenantDataTable.Rows.Add(newRow);

            BindDataToGrid();

            // Clear the input fields
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            rbMale.Checked = false;

            MessageBox.Show("Tenant added successfully!");
        }
     
        private void btReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvTenant.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a tenant to delete!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected tenant?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int selectedRowIndex = dgvTenant.SelectedRows[0].Index;
                tenantDataTable.Rows.RemoveAt(selectedRowIndex);

                BindDataToGrid();

                MessageBox.Show("Tenant deleted successfully!");
            }
        }

        private void dgvTenant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}