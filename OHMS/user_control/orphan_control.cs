﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OHMS.user_control
{
    public partial class orphan_control : UserControl
    {
        public orphan_control()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (orphan fw = new orphan())
            {
                fw.ShowDialog();
                this.OnLoad(e);
            }

        }
    }
}
