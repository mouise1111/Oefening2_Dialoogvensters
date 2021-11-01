using System;
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
    public partial class Form3 : Form
    {
        Gemiddelde gemiddelde = new Gemiddelde();

        public double getal { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            getal = double.Parse(tbWaarde.Text);
        }

        
    }
}
