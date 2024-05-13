using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentinela
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void progressBar2_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value <= 98)
            {
                progressBar2.Value += 2;
            }
            else
            {
                progressBar2.Value = 100;
                timer1.Enabled = false;
                this.Visible = false;
                Form outro = new FormMenu();
                outro.ShowDialog();
            }
        }
    }
}
