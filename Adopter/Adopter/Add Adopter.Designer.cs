
namespace Adopter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddAdopter = new System.Windows.Forms.Button();
            this.btnAdopterDelete = new System.Windows.Forms.Button();
            this.btnAdopterUpdate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewAdoption = new System.Windows.Forms.DataGridView();
            this.orphan_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_of_Adoption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adopter_NIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adopter_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adopter_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adopter_Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adopter_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adopter_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adopter_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdoption)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.buttonAddAdopter);
            this.panel1.Controls.Add(this.btnAdopterDelete);
            this.panel1.Controls.Add(this.btnAdopterUpdate);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.dataGridViewAdoption);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1559, 810);
            this.panel1.TabIndex = 2;
            // 
            // buttonAddAdopter
            // 
            this.buttonAddAdopter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAdopter.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddAdopter.Image")));
            this.buttonAddAdopter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddAdopter.Location = new System.Drawing.Point(88, 76);
            this.buttonAddAdopter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddAdopter.Name = "buttonAddAdopter";
            this.buttonAddAdopter.Size = new System.Drawing.Size(131, 42);
            this.buttonAddAdopter.TabIndex = 11;
            this.buttonAddAdopter.Text = "  Add";
            this.buttonAddAdopter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddAdopter.UseVisualStyleBackColor = true;
            this.buttonAddAdopter.Click += new System.EventHandler(this.buttonAddAdopter_Click_1);
            // 
            // btnAdopterDelete
            // 
            this.btnAdopterDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdopterDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnAdopterDelete.Image")));
            this.btnAdopterDelete.Location = new System.Drawing.Point(1333, 687);
            this.btnAdopterDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdopterDelete.Name = "btnAdopterDelete";
            this.btnAdopterDelete.Size = new System.Drawing.Size(141, 42);
            this.btnAdopterDelete.TabIndex = 12;
            this.btnAdopterDelete.Text = "Delete";
            this.btnAdopterDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdopterDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdopterUpdate
            // 
            this.btnAdopterUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdopterUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnAdopterUpdate.Image")));
            this.btnAdopterUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdopterUpdate.Location = new System.Drawing.Point(1163, 687);
            this.btnAdopterUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdopterUpdate.Name = "btnAdopterUpdate";
            this.btnAdopterUpdate.Size = new System.Drawing.Size(141, 42);
            this.btnAdopterUpdate.TabIndex = 11;
            this.btnAdopterUpdate.Text = "Update";
            this.btnAdopterUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdopterUpdate.UseVisualStyleBackColor = true;
            this.btnAdopterUpdate.Click += new System.EventHandler(this.btnAdopterUpdate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1080, 89);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(319, 22);
            this.txtSearch.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1415, 86);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "OK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewAdoption
            // 
            this.dataGridViewAdoption.AllowUserToAddRows = false;
            this.dataGridViewAdoption.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdoption.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            this.dataGridViewAdoption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdoption.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orphan_id,
            this.Date_of_Adoption,
            this.Adopter_NIC,
            this.Adopter_FirstName,
            this.Adopter_LastName,
            this.Adopter_Contact,
            this.Adopter_email,
            this.Adopter_Address,
            this.Adopter_City});
            this.dataGridViewAdoption.Location = new System.Drawing.Point(88, 139);
            this.dataGridViewAdoption.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAdoption.Name = "dataGridViewAdoption";
            this.dataGridViewAdoption.RowHeadersWidth = 51;
            this.dataGridViewAdoption.Size = new System.Drawing.Size(1397, 528);
            this.dataGridViewAdoption.TabIndex = 6;
            // 
            // orphan_id
            // 
            this.orphan_id.HeaderText = "Orphan ID";
            this.orphan_id.MinimumWidth = 6;
            this.orphan_id.Name = "orphan_id";
            // 
            // Date_of_Adoption
            // 
            this.Date_of_Adoption.HeaderText = "Date of Adoption";
            this.Date_of_Adoption.MinimumWidth = 6;
            this.Date_of_Adoption.Name = "Date_of_Adoption";
            // 
            // Adopter_NIC
            // 
            this.Adopter_NIC.HeaderText = "NIC NO";
            this.Adopter_NIC.MinimumWidth = 6;
            this.Adopter_NIC.Name = "Adopter_NIC";
            // 
            // Adopter_FirstName
            // 
            this.Adopter_FirstName.HeaderText = "First Name";
            this.Adopter_FirstName.MinimumWidth = 6;
            this.Adopter_FirstName.Name = "Adopter_FirstName";
            // 
            // Adopter_LastName
            // 
            this.Adopter_LastName.HeaderText = "Last Name";
            this.Adopter_LastName.MinimumWidth = 6;
            this.Adopter_LastName.Name = "Adopter_LastName";
            // 
            // Adopter_Contact
            // 
            this.Adopter_Contact.HeaderText = "Contact Number";
            this.Adopter_Contact.MinimumWidth = 6;
            this.Adopter_Contact.Name = "Adopter_Contact";
            // 
            // Adopter_email
            // 
            this.Adopter_email.HeaderText = "Email";
            this.Adopter_email.MinimumWidth = 6;
            this.Adopter_email.Name = "Adopter_email";
            // 
            // Adopter_Address
            // 
            this.Adopter_Address.HeaderText = "Address";
            this.Adopter_Address.MinimumWidth = 6;
            this.Adopter_Address.Name = "Adopter_Address";
            // 
            // Adopter_City
            // 
            this.Adopter_City.HeaderText = "City ";
            this.Adopter_City.MinimumWidth = 6;
            this.Adopter_City.Name = "Adopter_City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(968, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search By";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(964, 687);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(154, 41);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 810);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdoption)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddAdopter;
        private System.Windows.Forms.Button btnAdopterDelete;
        private System.Windows.Forms.Button btnAdopterUpdate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridViewAdoption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orphan_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_of_Adoption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adopter_NIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adopter_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adopter_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adopter_Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adopter_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adopter_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adopter_City;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnView;
    }
}

