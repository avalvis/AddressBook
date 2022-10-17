namespace AddressBook
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstContacts = new System.Windows.Forms.ListView();
            this.clLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAllContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.lstContacts);
            this.groupBox1.Location = new System.Drawing.Point(12, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 272);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacts";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnDelete.Location = new System.Drawing.Point(363, 229);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 30);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.btnDelete, "Delete selected contact");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnEdit.Location = new System.Drawing.Point(249, 229);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 30);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.toolTip1.SetToolTip(this.btnEdit, "Edit selected contact");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnExit.Location = new System.Drawing.Point(537, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 30);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstContacts
            // 
            this.lstContacts.BackColor = System.Drawing.Color.Honeydew;
            this.lstContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clLastName,
            this.clFirstName,
            this.clPhone,
            this.clMail});
            this.lstContacts.ContextMenuStrip = this.contextMenuStrip2;
            this.lstContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lstContacts.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstContacts.FullRowSelect = true;
            this.lstContacts.HideSelection = false;
            this.lstContacts.Location = new System.Drawing.Point(6, 16);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(639, 206);
            this.lstContacts.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lstContacts, "A list with all the saved contacts");
            this.lstContacts.UseCompatibleStateImageBehavior = false;
            this.lstContacts.View = System.Windows.Forms.View.Details;
            this.lstContacts.SelectedIndexChanged += new System.EventHandler(this.lstContacts_SelectedIndexChanged);
            // 
            // clLastName
            // 
            this.clLastName.Text = "Last Name";
            this.clLastName.Width = 150;
            // 
            // clFirstName
            // 
            this.clFirstName.Text = "First Name";
            this.clFirstName.Width = 150;
            // 
            // clPhone
            // 
            this.clPhone.Text = "Phone";
            this.clPhone.Width = 150;
            // 
            // clMail
            // 
            this.clMail.Text = "Email";
            this.clMail.Width = 150;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.BackColor = System.Drawing.Color.Honeydew;
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAllContactsToolStripMenuItem,
            this.deleteAllContactsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openAllContactsToolStripMenuItem
            // 
            this.openAllContactsToolStripMenuItem.Name = "openAllContactsToolStripMenuItem";
            this.openAllContactsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openAllContactsToolStripMenuItem.Text = "Open File Location";
            this.openAllContactsToolStripMenuItem.ToolTipText = "Open the directory where the contacts file is saved";
            this.openAllContactsToolStripMenuItem.Click += new System.EventHandler(this.openAllContactsToolStripMenuItem_Click);
            // 
            // deleteAllContactsToolStripMenuItem
            // 
            this.deleteAllContactsToolStripMenuItem.Name = "deleteAllContactsToolStripMenuItem";
            this.deleteAllContactsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteAllContactsToolStripMenuItem.Text = "Delete All Contacts";
            this.deleteAllContactsToolStripMenuItem.ToolTipText = "Caution! You will lose all your contacts!";
            this.deleteAllContactsToolStripMenuItem.Click += new System.EventHandler(this.deleteAllContactsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allContactsToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // allContactsToolStripMenuItem
            // 
            this.allContactsToolStripMenuItem.Name = "allContactsToolStripMenuItem";
            this.allContactsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allContactsToolStripMenuItem.Text = "All Contacts";
            this.allContactsToolStripMenuItem.ToolTipText = "Overall view of all the saved contacts";
            this.allContactsToolStripMenuItem.Click += new System.EventHandler(this.allContactsToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.clearToolStripMenuItem.Text = "Clear Form";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LemonChiffon;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.LemonChiffon;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewContactsToolStripMenuItem,
            this.clearToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 48);
            // 
            // viewContactsToolStripMenuItem
            // 
            this.viewContactsToolStripMenuItem.Name = "viewContactsToolStripMenuItem";
            this.viewContactsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewContactsToolStripMenuItem.Text = "View Contacts";
            this.viewContactsToolStripMenuItem.Click += new System.EventHandler(this.allContactsToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.clearToolStripMenuItem1.Text = "Clear Form";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFirstName.Location = new System.Drawing.Point(6, 16);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblLastName.Location = new System.Drawing.Point(6, 42);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 18;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPhone.Location = new System.Drawing.Point(6, 68);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 20);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblEmail.Location = new System.Drawing.Point(6, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAddress.Location = new System.Drawing.Point(6, 120);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "Address:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblNotes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNotes.Location = new System.Drawing.Point(6, 146);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(55, 20);
            this.lblNotes.TabIndex = 22;
            this.lblNotes.Text = "Notes:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.Honeydew;
            this.txtFirstName.Location = new System.Drawing.Point(98, 16);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(342, 20);
            this.txtFirstName.TabIndex = 23;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.Honeydew;
            this.txtLastName.Location = new System.Drawing.Point(98, 42);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(342, 20);
            this.txtLastName.TabIndex = 24;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Honeydew;
            this.txtPhone.Location = new System.Drawing.Point(98, 68);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(342, 20);
            this.txtPhone.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Honeydew;
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmail.Location = new System.Drawing.Point(98, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(342, 20);
            this.txtEmail.TabIndex = 26;
            this.txtEmail.Text = "someone@example.com";
            this.toolTip1.SetToolTip(this.txtEmail, "someone@example.com");
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Honeydew;
            this.txtAddress.Location = new System.Drawing.Point(98, 120);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(342, 20);
            this.txtAddress.TabIndex = 27;
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.Honeydew;
            this.txtNotes.Location = new System.Drawing.Point(98, 146);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(342, 68);
            this.txtNotes.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSave.Location = new System.Drawing.Point(104, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 30);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave, "Save your new contact");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnClear.Location = new System.Drawing.Point(332, 220);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 30);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnClear, "Clear form");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnApply.Location = new System.Drawing.Point(218, 220);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(108, 30);
            this.btnApply.TabIndex = 31;
            this.btnApply.Text = "Apply Changes";
            this.toolTip1.SetToolTip(this.btnApply, "Save any changes you have made to the selected contact");
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.btnApply);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtNotes);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.lblNotes);
            this.groupBox2.Controls.Add(this.lblAddress);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.lblLastName);
            this.groupBox2.Controls.Add(this.lblFirstName);
            this.groupBox2.Location = new System.Drawing.Point(223, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 266);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            this.toolTip1.SetToolTip(this.groupBox2, "Add a new contact here");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(686, 583);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Address Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView lstContacts;
        private System.Windows.Forms.ColumnHeader clLastName;
        // private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader clFirstName;
        private System.Windows.Forms.ColumnHeader clPhone;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem deleteAllContactsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem openAllContactsToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader clMail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem viewContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

