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
    public partial class Form2 : Form
    {
        private string numCB = "D3517CD1718JK9";
        private string debutMax = "10000";
        private TextBox target;//the textbox of the solde 
        //we will change it's content later in form 3
        public Form2(TextBox source)
        {
            InitializeComponent();
            this.target = source;
            textBox1.Text = numCB;
            textBox3.Text = debutMax;
        }
        //Text Boxes____________________________________________________
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numCB = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            debutMax = textBox3.Text;
        }

        //Buttons _______________________________________________________
        //Credité Button
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 credite = new Form3(false, target);
            credite.ShowDialog();
        }
        //Débuté Button
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 debute = new Form3(true, float.Parse(debutMax),target);
            debute.ShowDialog();
        }
        //Details Button
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numero Compt Bancaire : " + numCB + "\nDebut Courant Max : " + debutMax);
        }
    }
}
