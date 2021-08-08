
namespace Adopter
{
    partial class Adopter_Controler
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdopterFName = new System.Windows.Forms.TextBox();
            this.txtAdopterLName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAdopterNIC = new System.Windows.Forms.MaskedTextBox();
            this.txtAdopterCity = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdopterAddress = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdopterContact = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdopterEmail = new System.Windows.Forms.TextBox();
            this.btnAdopterSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AdoptionDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtOrphanID = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 102;
            this.label2.Text = "Orphan ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 104;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 105;
            this.label5.Text = "Last Name";
            // 
            // txtAdopterFName
            // 
            this.txtAdopterFName.Location = new System.Drawing.Point(241, 208);
            this.txtAdopterFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdopterFName.MaxLength = 20;
            this.txtAdopterFName.Name = "txtAdopterFName";
            this.txtAdopterFName.Size = new System.Drawing.Size(265, 22);
            this.txtAdopterFName.TabIndex = 93;
            this.txtAdopterFName.TextChanged += new System.EventHandler(this.txtAdopterFName_TextChanged);
            // 
            // txtAdopterLName
            // 
            this.txtAdopterLName.Location = new System.Drawing.Point(241, 256);
            this.txtAdopterLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdopterLName.MaxLength = 20;
            this.txtAdopterLName.Name = "txtAdopterLName";
            this.txtAdopterLName.Size = new System.Drawing.Size(265, 22);
            this.txtAdopterLName.TabIndex = 94;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(33, 158);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 22);
            this.label15.TabIndex = 108;
            this.label15.Text = "NIC No";
            // 
            // txtAdopterNIC
            // 
            this.txtAdopterNIC.Location = new System.Drawing.Point(241, 158);
            this.txtAdopterNIC.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdopterNIC.Mask = "000000000aaa";
            this.txtAdopterNIC.Name = "txtAdopterNIC";
            this.txtAdopterNIC.PromptChar = ' ';
            this.txtAdopterNIC.Size = new System.Drawing.Size(267, 22);
            this.txtAdopterNIC.TabIndex = 91;
            // 
            // txtAdopterCity
            // 
            this.txtAdopterCity.Location = new System.Drawing.Point(712, 313);
            this.txtAdopterCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdopterCity.Mask = "000000000aaa";
            this.txtAdopterCity.Name = "txtAdopterCity";
            this.txtAdopterCity.PromptChar = ' ';
            this.txtAdopterCity.Size = new System.Drawing.Size(267, 22);
            this.txtAdopterCity.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(578, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 109;
            this.label8.Text = "Address";
            // 
            // txtAdopterAddress
            // 
            this.txtAdopterAddress.Location = new System.Drawing.Point(714, 222);
            this.txtAdopterAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdopterAddress.MaxLength = 50;
            this.txtAdopterAddress.Name = "txtAdopterAddress";
            this.txtAdopterAddress.Size = new System.Drawing.Size(265, 66);
            this.txtAdopterAddress.TabIndex = 99;
            this.txtAdopterAddress.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(578, 312);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 22);
            this.label9.TabIndex = 110;
            this.label9.Text = "City";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 304);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 22);
            this.label10.TabIndex = 111;
            this.label10.Text = "Contact Number";
            // 
            // txtAdopterContact
            // 
            this.txtAdopterContact.Location = new System.Drawing.Point(241, 304);
            this.txtAdopterContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdopterContact.Mask = "(000) -0000000";
            this.txtAdopterContact.Name = "txtAdopterContact";
            this.txtAdopterContact.PromptChar = ' ';
            this.txtAdopterContact.Size = new System.Drawing.Size(265, 22);
            this.txtAdopterContact.TabIndex = 95;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 350);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 22);
            this.label11.TabIndex = 112;
            this.label11.Text = "Email";
            // 
            // txtAdopterEmail
            // 
            this.txtAdopterEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtAdopterEmail.Location = new System.Drawing.Point(239, 350);
            this.txtAdopterEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdopterEmail.Name = "txtAdopterEmail";
            this.txtAdopterEmail.Size = new System.Drawing.Size(267, 22);
            this.txtAdopterEmail.TabIndex = 96;
            // 
            // btnAdopterSave
            // 
            this.btnAdopterSave.BackColor = System.Drawing.Color.White;
            this.btnAdopterSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdopterSave.Location = new System.Drawing.Point(489, 456);
            this.btnAdopterSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdopterSave.Name = "btnAdopterSave";
            this.btnAdopterSave.Size = new System.Drawing.Size(133, 39);
            this.btnAdopterSave.TabIndex = 100;
            this.btnAdopterSave.Text = "&Save";
            this.btnAdopterSave.UseVisualStyleBackColor = false;
            this.btnAdopterSave.Click += new System.EventHandler(this.btnAdopterSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(836, 456);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(123, 39);
            this.buttonClose.TabIndex = 101;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(32, 108);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 25);
            this.label13.TabIndex = 115;
            this.label13.Text = "Adopter Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(547, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 116;
            this.label7.Text = "Date Of Adoption:";
            // 
            // AdoptionDate
            // 
            this.AdoptionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AdoptionDate.Location = new System.Drawing.Point(753, 54);
            this.AdoptionDate.Margin = new System.Windows.Forms.Padding(4);
            this.AdoptionDate.Name = "AdoptionDate";
            this.AdoptionDate.Size = new System.Drawing.Size(265, 22);
            this.AdoptionDate.TabIndex = 117;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.AdoptionDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.btnAdopterSave);
            this.panel1.Controls.Add(this.txtAdopterEmail);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtAdopterContact);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtAdopterAddress);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtAdopterCity);
            this.panel1.Controls.Add(this.txtOrphanID);
            this.panel1.Controls.Add(this.txtAdopterNIC);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtAdopterLName);
            this.panel1.Controls.Add(this.txtAdopterFName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 556);
            this.panel1.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(673, 456);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 39);
            this.btnClear.TabIndex = 101;
            this.btnClear.Text = "C&lear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtOrphanID
            // 
            this.txtOrphanID.Location = new System.Drawing.Point(241, 56);
            this.txtOrphanID.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrphanID.Mask = "000000000aaa";
            this.txtOrphanID.Name = "txtOrphanID";
            this.txtOrphanID.PromptChar = ' ';
            this.txtOrphanID.Size = new System.Drawing.Size(267, 22);
            this.txtOrphanID.TabIndex = 91;
            this.txtOrphanID.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Adopter_Controler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 556);
            this.Controls.Add(this.panel1);
            this.Name = "Adopter_Controler";
            this.Text = "Add";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdopterFName;
        private System.Windows.Forms.TextBox txtAdopterLName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtAdopterNIC;
        private System.Windows.Forms.MaskedTextBox txtAdopterCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtAdopterAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtAdopterContact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAdopterEmail;
        private System.Windows.Forms.Button btnAdopterSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker AdoptionDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtOrphanID;
        private System.Windows.Forms.Button btnClear;
    }
}