using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetDotNet1
{
    public partial class Form3 : Form

    {
        private TextBox target;
        private bool debute ;
        private float DebutMax=0;
        private double TauxIntere=0;
        public Form3(bool debute, TextBox target)
        {
            InitializeComponent();
            this.target = target;
            this.debute = debute;
        }
        public Form3(bool debute,float debutMax, TextBox target)
        {
            InitializeComponent();
            this.target = target;
            this.debute = debute;
            DebutMax = debutMax;

        }
        public Form3(bool debute, double tauxIntere, TextBox target)
        {
            InitializeComponent();
            this.target = target;
            this.debute = debute;
            TauxIntere = tauxIntere;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
            if (debute)
            {
                float Montant = float.Parse(textBox1.Text);
                if (DebutMax!=0) 
                {
                    if (Montant <= DebutMax)
                    {
                        float newSolde = float.Parse(target.Text) - float.Parse(textBox1.Text);
                        target.Text = newSolde.ToString();
                        MessageBox.Show("Vous avez debuté " + float.Parse(textBox1.Text) + "avec succée");
                    }
                    else
                    {
                        MessageBox.Show("Vous avez dépassé le Debut Courant Maximal !\nChosir un autre montant");
                    }
                }
                else
                {
                    double newSolde = float.Parse(target.Text) - float.Parse(textBox1.Text)*(1+ TauxIntere);
                    target.Text = newSolde.ToString();
                    MessageBox.Show("Vous avez debuté " + float.Parse(textBox1.Text) * (1 + TauxIntere) + "DH \n(Montant d'intéré inclue)");
                }
                 
            }
            else
            {
                float newSolde = float.Parse(target.Text) + float.Parse(textBox1.Text);
                target.Text = newSolde.ToString();
                MessageBox.Show("Vous avez crédité "+ float.Parse(textBox1.Text) + "DH avec succée");
            }
           
        }
    }
}
