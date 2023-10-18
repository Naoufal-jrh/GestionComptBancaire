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
    public partial class Form4 : Form
    {
        private double tauxIntere = 0.4;
        private TextBox target;
        public Form4(TextBox target)
        {
            InitializeComponent();
            textBox1.Text = tauxIntere.ToString();
            this.target = target;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double result))
            {
                tauxIntere = result;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Taux d'intérée est : " + tauxIntere);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 credite = new Form3(false, target);
            credite.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 debute = new Form3(true, tauxIntere ,target);
            debute.ShowDialog();
        }
    }
}
