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
    public partial class Gemiddelde : Form
    {

        public Gemiddelde()
        {
            InitializeComponent();
        }

        private void btAddGetal_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();

            if(f.DialogResult == DialogResult.OK)
            {
                AddToList(f.getal);
                berekenGemiddelde();
                f.Dispose();
            }
           

        }

        public void AddToList(double number)
        {
            listBox1.Items.Add(number);
        }


        public void berekenGemiddelde()
        {

            double gem = 0;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                gem =+ double.Parse(listBox1.Items[i].ToString());
            }

            gem /= listBox1.Items.Count;  // het gemiddelde 
            tbGemiddelde.Text = gem.ToString();

        }
    }
}
