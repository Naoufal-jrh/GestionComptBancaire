namespace projetDotNet1
{
    public partial class Form1 : Form
    {
        private string Titulaire = "Naoufal Jrhaider";
        public string Solde = "12000";
        private string Devise = "dh";
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Titulaire;
            textBox4.Text = Solde.ToString();
            textBox3.Text = Devise;
        }
        //useless functions________________________________________
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        //___________________________________________________________
        //compt courant button
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 compt_courant = new Form2(textBox4);
            compt_courant.ShowDialog();

        }
        //compte epargne button
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 compt_epargne = new Form4(textBox4);
            compt_epargne.ShowDialog();
        }
        //description button
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bonjour monsieur " + Titulaire +
                "\nSolde: " + Solde + " " + Devise);
        }
        //Text boxes______________________________________________________
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Titulaire = textBox1.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Solde = textBox4.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Devise = textBox3.Text;
        }
    }
}