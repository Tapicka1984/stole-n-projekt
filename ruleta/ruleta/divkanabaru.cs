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
    public partial class divkanabaru : Form
    {
        public divkanabaru()
        {
            InitializeComponent();
        }

        int Disunit = 1;
        private void button3_Click(object sender, EventArgs e)
        {
            divkanabaru.ActiveForm.BackgroundImage = Properties.Resources.Angry;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            Label lbl = new Label();
            this.Controls.Add(lbl);

            lbl.Top = Disunit * 250;
            lbl.Left = 15;
            Disunit = Disunit + 1;
            lbl.Font = new Font("Arial",20.25F, FontStyle.Regular);
            lbl.Width = 1000;
            lbl.Height = 100;
            lbl.BackColor = Color.Transparent;
            lbl.Text = "Dívka se na tebe naštvala a před nosem ti bouchla s dveřmi, bohužel jsi zmařil svojí jedinou šanci (pravděpodobně v celém tvém životě) komunikovat s dívkou";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rozhovor rozhovor = new rozhovor();
            rozhovor.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dějoválinie2 dějoválinie2 = new dějoválinie2();
            dějoválinie2.Show();
            this.Close();
        }
    }
}
