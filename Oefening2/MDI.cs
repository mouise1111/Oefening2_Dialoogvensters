﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            Gemiddelde gemiddeldeForm = new Gemiddelde();

            this.IsMdiContainer = true;
            gemiddeldeForm.MdiParent = this;

            gemiddeldeForm.Show();
        }

    }
}
