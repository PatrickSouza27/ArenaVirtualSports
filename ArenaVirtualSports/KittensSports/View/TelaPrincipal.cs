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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //colocar as informações no label
            //mudar nome label
            EditLabel("eFooteball");
            if(guna2HtmlLabel1.Text == "Cronograma")
            {
                //faz tal coisa (lembrar)
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            EditLabel("eBasketball");
            if (guna2HtmlLabel1.Text == "Cronograma")
            {
                //faz tal coisa (lembrar)
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            EditLabel("eHockey");
            if (guna2HtmlLabel1.Text == "Cronograma")
            {
                //faz tal coisa (lembrar)
            }
        }
        public void EditLabel(string modalidade)
        {
            guna2HtmlLabel2.Text = modalidade;
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            if (guna2HtmlLabel1.Text == "Cronograma")
            {
                //faz tal coisa (lembrar)
            }
        }
    }
}
