using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ruleta
{
    public partial class Form1 : Form
    {
        long cislooduzivalete;
        int sazka;
        long money = 20000;
        public Form1()
        {
            InitializeComponent();
            label2.Text = money.ToString();
        }

        private void hlavniudelatko()
        {
            try
            {
            sazka = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("prvne zadej mnozstvi penez ktere chces vsadit!");
            }
            if ((sazka <= 0)||(sazka>money))
            {
                if (sazka == 0)
                {
                    MessageBox.Show("prvne zadej mnozstvi penez ktere chces vsadit!");
                }
                if (sazka < 0)
                {
                    MessageBox.Show("Nezadavej zaporne cislo!");
                }
                if (sazka > money)
                {
                    MessageBox.Show("pokousis se vsadit vic nez mas!");
                }
            }
            else
            {
                RNG();
            }
        }

        private void RNG()
        {
            Random rnd = new Random();
            int rngnumber = rnd.Next(1, 37);
            label4.Text = rngnumber.ToString();
            if(rngnumber == cislooduzivalete)
            {
                vyhra();
            }
            else
            {
                prohra();
            }
        }
        private void vyhra()
        {
            MessageBox.Show("Gratulujeme vyhral jste:" + sazka * 10);
            money += sazka * 10;
            label2.Text = money.ToString();
        }
        private void prohra()
        {
            MessageBox.Show("bohuzel jste prohral:" + sazka);
            money -= sazka;
            label2.Text = money.ToString();
        }

        private void vyhra2x()
        {
            MessageBox.Show("Gratulujeme vyhral jste:" + sazka * 2);
            money += sazka * 2;
            label2.Text = money.ToString();
        }
        private void prohra2x()
        {
            MessageBox.Show("bohuzel jste prohral:" + sazka);
            money -= sazka;
            label2.Text = money.ToString();
        }



        //_____________________________________________________________________________________ - hotovo

        private void Error()
        {
            MessageBox.Show("neco se pokazilo - nejspis zadavate zadnou/spatnou hodnotu");
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            cislooduzivalete = int.Parse((sender as Button).Text);
            hlavniudelatko();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {
                sazka = int.Parse(textBox1.Text);
                if ((sazka <= 0) || (sazka > money))
                {
                    if (sazka == 0)
                    {
                        MessageBox.Show("prvne zadej mnozstvi penez ktere chces vsadit!");
                    }
                    if (sazka < 0)
                    {
                        MessageBox.Show("Nezadavej zaporne cislo!");
                    }
                    if (sazka > money)
                    {
                        MessageBox.Show("pokousis se vsadit vic nez mas!");
                    }
                }
                else
                {
                    Random rnd = new Random();
                    int rngnumber = rnd.Next(1, 37);
                    label4.Text = rngnumber.ToString();

                    if (rngnumber <= 16)
                    {
                        vyhra2x();
                    }
                    else
                    {
                        prohra2x();
                    }
                }
            } catch (Exception ex)
            {
                Error();
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                sazka = int.Parse(textBox1.Text);
                if ((sazka <= 0) || (sazka > money))
                {
                    if (sazka == 0)
                    {
                        MessageBox.Show("prvne zadej mnozstvi penez ktere chces vsadit!");
                    }
                    if (sazka < 0)
                    {
                        MessageBox.Show("Nezadavej zaporne cislo!");
                    }
                    if (sazka > money)
                    {
                        MessageBox.Show("pokousis se vsadit vic nez mas!");
                    }
                }
                else
                {
                    Random rnd = new Random();
                    int rngnumber = rnd.Next(1, 37);
                    label4.Text = rngnumber.ToString();
                    if (rngnumber >= 17)
                    {
                        vyhra2x();
                    }
                    else
                    {
                        prohra2x();
                    }
                }
            }
            catch (Exception ex)
            {
                Error();
            }
        }
        //-------------------------------------------------------------------- normalni tlacitka done

        private void button39_Click(object sender, EventArgs e)
        {
            try
            {
                sazka = int.Parse(textBox1.Text);
                if ((sazka <= 0) || (sazka > money))
                {
                    if (sazka == 0)
                    {
                        MessageBox.Show("prvne zadej mnozstvi penez ktere chces vsadit!");
                    }
                    if (sazka < 0)
                    {
                        MessageBox.Show("Nezadavej zaporne cislo!");
                    }
                    if (sazka > money)
                    {
                        MessageBox.Show("pokousis se vsadit vic nez mas!");
                    }
                }
                else
                {
                    Random rnd = new Random();
                    int rngnumber = rnd.Next(1, 37);
                    label4.Text = rngnumber.ToString();
                    if (rngnumber%2 != 0)
                    {
                        vyhra2x();
                    }
                    else
                    {
                        prohra2x();
                    }
                }
            }
            catch (Exception ex)
            {
                Error();
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            try
            {
                sazka = int.Parse(textBox1.Text);
                if ((sazka <= 0) || (sazka > money))
                {
                    if (sazka == 0)
                    {
                        MessageBox.Show("prvne zadej mnozstvi penez ktere chces vsadit!");
                    }
                    if (sazka < 0)
                    {
                        MessageBox.Show("Nezadavej zaporne cislo!");
                    }
                    if (sazka > money)
                    {
                        MessageBox.Show("pokousis se vsadit vic nez mas!");
                    }
                }
                else
                {
                    Random rnd = new Random();
                    int rngnumber = rnd.Next(1, 37);
                    label4.Text = rngnumber.ToString();
                    if (rngnumber%2==0)
                    {
                        vyhra2x();
                    }
                    else
                    {
                        prohra2x();
                    }
                }
            }
            catch (Exception ex)
            {
                Error();
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            divkanabaru divkanabaru = new divkanabaru(); 
            divkanabaru.Show();
            button41.Visible = false;
        }
    }
}
