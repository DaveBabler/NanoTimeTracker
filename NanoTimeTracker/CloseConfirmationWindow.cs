﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NanoTimeTracker
{
    public partial class CloseConfirmationWindow : Form
    {
        public CloseConfirmationWindow()
        {
            InitializeComponent();
        }

        public bool DontShowAgain
        {
            get
            {
                return chk_DontShowAgain.Checked;
            }
        }
    }
}
