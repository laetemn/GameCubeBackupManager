﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCubeBackupManager
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void tsmiConfig_Click(object sender, EventArgs e)
        {
            formConfig frmConfig = new formConfig();
            frmConfig.ShowDialog();
        }

        private void tsmiPrincipalExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}