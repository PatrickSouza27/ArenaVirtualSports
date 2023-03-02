using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KittensSports.View
{
    public partial class ProgressoTela : Form
    {
        public ProgressoTela()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelPro.Text = (int.Parse(labelPro.Text) + 1).ToString();
            progress.Value += 1;
            if(labelPro.Text == "99")
            {
                timer1.Stop();
                this.Close();
                new TelaPrincipal().ShowDialog();
            }
        }
    }
}
