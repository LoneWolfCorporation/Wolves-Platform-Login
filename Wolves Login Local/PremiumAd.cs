﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wolves_Login_Local
{
    public partial class PremiumAd : Form
    {
        public PremiumAd()
        {
            InitializeComponent();
        }

        private void Button_Buy_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://shoppy.gg/@DonCorporation/groups/ts8vlwQ");
        }

        private void Button_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
