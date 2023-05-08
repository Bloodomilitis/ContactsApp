namespace ContactsApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindBox = new System.Windows.Forms.TextBox();
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FullNameBox = new System.Windows.Forms.TextBox();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.MailLabel = new System.Windows.Forms.Label();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.VKBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.EditContactButton = new System.Windows.Forms.Button();
            this.RemoveContactButton = new System.Windows.Forms.Button();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.CloseMessageButton = new System.Windows.Forms.Button();
            this.CelebrantsLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.InfoPicture = new System.Windows.Forms.PictureBox();
            this.ContactsList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            this.MessagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // FindLabel
            // 
            this.FindLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindLabel.AutoSize = true;
            this.FindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindLabel.Location = new System.Drawing.Point(13, 13);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(34, 15);
            this.FindLabel.TabIndex = 0;
            this.FindLabel.Text = "Find:";
            // 
            // FindBox
            // 
            this.FindBox.Location = new System.Drawing.Point(49, 10);
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(203, 20);
            this.FindBox.TabIndex = 1;
            this.FindBox.TextChanged += new System.EventHandler(this.FindBox_TextChanged);
            // 
            // PhotoBox
            // 
            this.PhotoBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoBox.InitialImage = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoBox.Location = new System.Drawing.Point(277, 10);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(100, 100);
            this.PhotoBox.TabIndex = 2;
            this.PhotoBox.TabStop = false;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.Location = new System.Drawing.Point(383, 20);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(67, 15);
            this.FullNameLabel.TabIndex = 7;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // FullNameBox
            // 
            this.FullNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameBox.BackColor = System.Drawing.Color.White;
            this.FullNameBox.Location = new System.Drawing.Point(383, 37);
            this.FullNameBox.Margin = new System.Windows.Forms.Padding(3, 35, 3, 3);
            this.FullNameBox.Name = "FullNameBox";
            this.FullNameBox.ReadOnly = true;
            this.FullNameBox.Size = new System.Drawing.Size(409, 20);
            this.FullNameBox.TabIndex = 8;
            // 
            // MailTextBox
            // 
            this.MailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailTextBox.BackColor = System.Drawing.Color.White;
            this.MailTextBox.Location = new System.Drawing.Point(383, 88);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.ReadOnly = true;
            this.MailTextBox.Size = new System.Drawing.Size(409, 20);
            this.MailTextBox.TabIndex = 10;
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MailLabel.Location = new System.Drawing.Point(383, 70);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(46, 15);
            this.MailLabel.TabIndex = 9;
            this.MailLabel.Text = "E-mail:";
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.BackColor = System.Drawing.Color.White;
            this.PhoneNumberBox.Location = new System.Drawing.Point(383, 138);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.ReadOnly = true;
            this.PhoneNumberBox.Size = new System.Drawing.Size(180, 20);
            this.PhoneNumberBox.TabIndex = 12;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(383, 120);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(91, 15);
            this.PhoneNumberLabel.TabIndex = 11;
            this.PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // DateBox
            // 
            this.DateBox.BackColor = System.Drawing.Color.White;
            this.DateBox.Location = new System.Drawing.Point(383, 188);
            this.DateBox.Name = "DateBox";
            this.DateBox.ReadOnly = true;
            this.DateBox.Size = new System.Drawing.Size(180, 20);
            this.DateBox.TabIndex = 14;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(383, 170);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(77, 15);
            this.DateLabel.TabIndex = 13;
            this.DateLabel.Text = "Date of Birth:";
            // 
            // VKBox
            // 
            this.VKBox.BackColor = System.Drawing.Color.White;
            this.VKBox.Location = new System.Drawing.Point(383, 238);
            this.VKBox.Name = "VKBox";
            this.VKBox.ReadOnly = true;
            this.VKBox.Size = new System.Drawing.Size(180, 20);
            this.VKBox.TabIndex = 16;
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VKLabel.Location = new System.Drawing.Point(383, 220);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(25, 15);
            this.VKLabel.TabIndex = 15;
            this.VKLabel.Text = "VK:";
            // 
            // AddContactButton
            // 
            this.AddContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddContactButton.BackColor = System.Drawing.Color.White;
            this.AddContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddContactButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddContactButton.FlatAppearance.BorderSize = 0;
            this.AddContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.AddContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContactButton.Image = global::ContactsApp.View.Properties.Resources.add_contact_32x32_gray;
            this.AddContactButton.Location = new System.Drawing.Point(12, 366);
            this.AddContactButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(80, 40);
            this.AddContactButton.TabIndex = 17;
            this.AddContactButton.UseVisualStyleBackColor = false;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            this.AddContactButton.MouseLeave += new System.EventHandler(this.AddContactButton_MouseLeave);
            this.AddContactButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddContactButton_MouseMove);
            // 
            // EditContactButton
            // 
            this.EditContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditContactButton.BackColor = System.Drawing.Color.White;
            this.EditContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditContactButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditContactButton.FlatAppearance.BorderSize = 0;
            this.EditContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.EditContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditContactButton.Image = global::ContactsApp.View.Properties.Resources.edit_contact_32x32_gray;
            this.EditContactButton.Location = new System.Drawing.Point(92, 366);
            this.EditContactButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(80, 40);
            this.EditContactButton.TabIndex = 18;
            this.EditContactButton.UseVisualStyleBackColor = false;
            this.EditContactButton.Click += new System.EventHandler(this.EditContactButton_Click);
            this.EditContactButton.MouseLeave += new System.EventHandler(this.EditContactButton_MouseLeave);
            this.EditContactButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditContactButton_MouseMove);
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveContactButton.BackColor = System.Drawing.SystemColors.Window;
            this.RemoveContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RemoveContactButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RemoveContactButton.FlatAppearance.BorderSize = 0;
            this.RemoveContactButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.RemoveContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveContactButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RemoveContactButton.Image = global::ContactsApp.View.Properties.Resources.remove_contact_32x32_gray;
            this.RemoveContactButton.Location = new System.Drawing.Point(172, 366);
            this.RemoveContactButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(80, 40);
            this.RemoveContactButton.TabIndex = 19;
            this.RemoveContactButton.UseVisualStyleBackColor = false;
            this.RemoveContactButton.Click += new System.EventHandler(this.RemoveContactButton_Click);
            this.RemoveContactButton.MouseLeave += new System.EventHandler(this.RemoveContactButton_MouseLeave);
            this.RemoveContactButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RemoveContactButton_MouseMove);
            // 
            // MessagePanel
            // 
            this.MessagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.MessagePanel.Controls.Add(this.CloseMessageButton);
            this.MessagePanel.Controls.Add(this.CelebrantsLabel);
            this.MessagePanel.Controls.Add(this.BirthdayLabel);
            this.MessagePanel.Controls.Add(this.InfoPicture);
            this.MessagePanel.Location = new System.Drawing.Point(277, 310);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(527, 96);
            this.MessagePanel.TabIndex = 21;
            // 
            // CloseMessageButton
            // 
            this.CloseMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseMessageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.CloseMessageButton.FlatAppearance.BorderSize = 0;
            this.CloseMessageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.CloseMessageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.CloseMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseMessageButton.Image = global::ContactsApp.View.Properties.Resources.close_32x32;
            this.CloseMessageButton.Location = new System.Drawing.Point(492, 3);
            this.CloseMessageButton.Name = "CloseMessageButton";
            this.CloseMessageButton.Size = new System.Drawing.Size(32, 32);
            this.CloseMessageButton.TabIndex = 4;
            this.CloseMessageButton.UseVisualStyleBackColor = true;
            this.CloseMessageButton.Click += new System.EventHandler(this.CloseMessageButton_Click);
            // 
            // CelebrantsLabel
            // 
            this.CelebrantsLabel.AutoSize = true;
            this.CelebrantsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.CelebrantsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CelebrantsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.CelebrantsLabel.Location = new System.Drawing.Point(71, 39);
            this.CelebrantsLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.CelebrantsLabel.Name = "CelebrantsLabel";
            this.CelebrantsLabel.Size = new System.Drawing.Size(76, 15);
            this.CelebrantsLabel.TabIndex = 3;
            this.CelebrantsLabel.Text = "Celebrants";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BirthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BirthdayLabel.Location = new System.Drawing.Point(71, 24);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(136, 15);
            this.BirthdayLabel.TabIndex = 1;
            this.BirthdayLabel.Text = "Today is Birthday of:";
            // 
            // InfoPicture
            // 
            this.InfoPicture.Image = global::ContactsApp.View.Properties.Resources.info_48x48;
            this.InfoPicture.InitialImage = global::ContactsApp.View.Properties.Resources.info_48x48;
            this.InfoPicture.Location = new System.Drawing.Point(16, 24);
            this.InfoPicture.Name = "InfoPicture";
            this.InfoPicture.Size = new System.Drawing.Size(48, 48);
            this.InfoPicture.TabIndex = 0;
            this.InfoPicture.TabStop = false;
            // 
            // ContactsList
            // 
            this.ContactsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsList.FormattingEnabled = true;
            this.ContactsList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ContactsList.IntegralHeight = false;
            this.ContactsList.ItemHeight = 15;
            this.ContactsList.Location = new System.Drawing.Point(12, 37);
            this.ContactsList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ContactsList.Name = "ContactsList";
            this.ContactsList.Size = new System.Drawing.Size(240, 329);
            this.ContactsList.TabIndex = 6;
            this.ContactsList.SelectedIndexChanged += new System.EventHandler(this.ContactsList_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 406);
            this.Controls.Add(this.MessagePanel);
            this.Controls.Add(this.RemoveContactButton);
            this.Controls.Add(this.EditContactButton);
            this.Controls.Add(this.AddContactButton);
            this.Controls.Add(this.VKBox);
            this.Controls.Add(this.VKLabel);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.FullNameBox);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.ContactsList);
            this.Controls.Add(this.PhotoBox);
            this.Controls.Add(this.FindBox);
            this.Controls.Add(this.FindLabel);
            this.Icon = global::ContactsApp.View.Properties.Resources.ContactsApp_96x96;
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainForm_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            this.MessagePanel.ResumeLayout(false);
            this.MessagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.TextBox FindBox;
        private System.Windows.Forms.PictureBox PhotoBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox FullNameBox;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox VKBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.Button EditContactButton;
        private System.Windows.Forms.Button RemoveContactButton;
        private System.Windows.Forms.Panel MessagePanel;
        private System.Windows.Forms.PictureBox InfoPicture;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label CelebrantsLabel;
        private System.Windows.Forms.Button CloseMessageButton;
        private System.Windows.Forms.ListBox ContactsList;
    }
}

