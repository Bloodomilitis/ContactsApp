using System;

namespace ContactsApp.View
{
    partial class ContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.VKBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.MailLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.ChoosePhotoButton = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // VKBox
            // 
            this.VKBox.Location = new System.Drawing.Point(118, 240);
            this.VKBox.Name = "VKBox";
            this.VKBox.Size = new System.Drawing.Size(180, 20);
            this.VKBox.TabIndex = 27;
            this.VKBox.TextChanged += new System.EventHandler(this.VKBox_TextChanged);
            this.VKBox.Enter += new System.EventHandler(this.VKBox_Enter);
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VKLabel.Location = new System.Drawing.Point(118, 222);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(25, 15);
            this.VKLabel.TabIndex = 26;
            this.VKLabel.Text = "VK:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(118, 172);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(77, 15);
            this.DateLabel.TabIndex = 24;
            this.DateLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(118, 140);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(180, 20);
            this.PhoneNumberBox.TabIndex = 23;
            this.PhoneNumberBox.Text = " ";
            this.PhoneNumberBox.TextChanged += new System.EventHandler(this.PhoneNumberBox_TextChanged);
            this.PhoneNumberBox.Enter += new System.EventHandler(this.PhoneNumberBox_Enter);
            this.PhoneNumberBox.Leave += new System.EventHandler(this.PhoneNumberBox_Leave);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(118, 122);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(91, 15);
            this.PhoneNumberLabel.TabIndex = 22;
            this.PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // MailTextBox
            // 
            this.MailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailTextBox.Location = new System.Drawing.Point(118, 90);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(381, 20);
            this.MailTextBox.TabIndex = 21;
            this.MailTextBox.TextChanged += new System.EventHandler(this.MailTextBox_TextChanged);
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MailLabel.Location = new System.Drawing.Point(118, 72);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(46, 15);
            this.MailLabel.TabIndex = 20;
            this.MailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(118, 39);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(3, 35, 3, 3);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(381, 20);
            this.FullNameTextBox.TabIndex = 19;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.Location = new System.Drawing.Point(118, 22);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(67, 15);
            this.FullNameLabel.TabIndex = 18;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // PhotoBox
            // 
            this.PhotoBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoBox.InitialImage = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoBox.Location = new System.Drawing.Point(12, 12);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(100, 100);
            this.PhotoBox.TabIndex = 17;
            this.PhotoBox.TabStop = false;
            // 
            // ChoosePhotoButton
            // 
            this.ChoosePhotoButton.FlatAppearance.BorderSize = 0;
            this.ChoosePhotoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ChoosePhotoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ChoosePhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoosePhotoButton.Image = global::ContactsApp.View.Properties.Resources.add_photo_32x32_gray;
            this.ChoosePhotoButton.Location = new System.Drawing.Point(48, 118);
            this.ChoosePhotoButton.Name = "ChoosePhotoButton";
            this.ChoosePhotoButton.Size = new System.Drawing.Size(32, 32);
            this.ChoosePhotoButton.TabIndex = 28;
            this.ChoosePhotoButton.UseVisualStyleBackColor = true;
            this.ChoosePhotoButton.MouseLeave += new System.EventHandler(this.ChoosePhotoButton_MouseLeave);
            this.ChoosePhotoButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoosePhotoButton_MouseMove);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(118, 190);
            this.DatePicker.MaxDate = new System.DateTime(2023, 3, 30, 16, 54, 58, 962);
            this.DatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(180, 20);
            this.DatePicker.TabIndex = 29;
            this.DatePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DatePicker.CloseUp += new System.EventHandler(this.BirthdayPicker_CloseUp);
            this.DatePicker.DropDown += new System.EventHandler(this.BirthdayPicker_DropDown);
            // 
            // AcceptButton
            // 
            this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AcceptButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AcceptButton.FlatAppearance.BorderSize = 0;
            this.AcceptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AcceptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Image = ((System.Drawing.Image)(resources.GetObject("AcceptButton.Image")));
            this.AcceptButton.Location = new System.Drawing.Point(418, 265);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(32, 32);
            this.AcceptButton.TabIndex = 30;
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = global::ContactsApp.View.Properties.Resources.close_32x32_white;
            this.CloseButton.Location = new System.Drawing.Point(456, 265);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 32);
            this.CloseButton.TabIndex = 31;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.AcceptButton;
            this.ClientSize = new System.Drawing.Size(511, 309);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.ChoosePhotoButton);
            this.Controls.Add(this.VKBox);
            this.Controls.Add(this.VKLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.PhotoBox);
            this.Icon = global::ContactsApp.View.Properties.Resources.ContactsApp_96x96;
            this.Name = "ContactForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Contact";
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VKBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.PictureBox PhotoBox;
        private System.Windows.Forms.Button ChoosePhotoButton;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CloseButton;
    }
}