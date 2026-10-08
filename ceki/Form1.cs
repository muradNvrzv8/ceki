using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace ceki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SifirHAl();
        }
        private void SifirHAl()
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double Bki;
        string BkiS;
        string kgS;
        int kg;
        string smS;
        int sm;

        private void button1_Click(object sender, EventArgs e)
        {
            SifirHAl();
            kgS = maskedTextBox1.Text;
            smS = maskedTextBox2.Text;
            if (string.IsNullOrEmpty(kgS) || string.IsNullOrEmpty(smS))
            {
                MessageBox.Show("Saheler bosdur","Xeta",MessageBoxButtons.OK);
            }
            else
            {
                
                kg = int.Parse(kgS);
                sm = int.Parse(smS);
                if (kg > 500 || kg < 1)
                {
                    MessageBox.Show("insan bu cekide olmur");
                }else if (sm > 300 || sm < 20)
                {
                    MessageBox.Show("insan bu olculerde olmur");
                }
                else
                {
                    Bki = kg * 10000.0 / (sm * sm);
                    if (Bki < 18.5)
                    {
                        pictureBox3.Visible = true;
                        label3.Text = "Ceki azdir";
                    }
                    if (Bki<24.9&&Bki>18.5)
                    {
                        pictureBox5.Visible = true;
                        label3.Text = "Ceki normaldir";
                    }
                    if (Bki<32&&Bki>25)
                    {
                        pictureBox4.Visible = true;
                        label3.Text = "Artiq ceki";
                    }
                    if (Bki<39&&Bki>33)
                    {
                        pictureBox6.Visible = true;
                        label3.Text = "1ci derece piylenme";
                    }
                    if (40<Bki)
                    {
                        pictureBox2.Visible = true;
                        label3.Text = "3cu derece piylenme";
                    }
                    BkiS = Bki.ToString();
                    label4.Text = BkiS;
                }
                    
            }



            


        }
    }
}
