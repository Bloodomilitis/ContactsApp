﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void ChoosePhotoButton_MouseMove(object sender, MouseEventArgs e)
        {
            ChoosePhotoButton.Image = Properties.Resources.add_photo_32x32;
        }

        private void ChoosePhotoButton_MouseLeave(object sender, EventArgs e)
        {
            ChoosePhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
        }
    }
}