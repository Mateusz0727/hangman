using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int punkty = 0;
        int ile_liter;
        public string slowo;
        int ile_pudel = 0;
        public Form1()
        {
            InitializeComponent();
            losuj_slowo();

        }
        

        private void restart()
        {
            losuj_slowo();
            ile_pudel = 0;

            label8.Text = "_";
            label9.Text = "_";
            label10.Text = "_";
            label11.Text = "_";
            label12.Text = "_";
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            button2.Visible = false;
            pictureBox1.Image = null;
        }
        private void sprawdź()
        {
            if (textBox1.Text != "")
            {
                if (ile_pudel < 8)
                {
                    string litera = textBox1.Text;
                    bool czy_trafiony = false;
                    int gdzie_trafiony = 0;

                    if (slowo.Length == 7)
                    {
                        for (int i = 1; i < 6; i++)
                        {
                            if (Convert.ToString(slowo[i]) == litera)
                            {
                                czy_trafiony = true;
                                gdzie_trafiony = i;
                                textBox1.Text = "";
                            }
                            string uzyta = "";
                            if (gdzie_trafiony == 1) { label2.Text = litera; } else uzyta = litera;
                            if (gdzie_trafiony == 2) { label3.Text = litera; } else uzyta = litera;
                            if (gdzie_trafiony == 3) { label4.Text = litera; } else uzyta = litera;
                            if (gdzie_trafiony == 4) { label5.Text = litera; } else uzyta = litera;
                            if (gdzie_trafiony == 5) { label6.Text = litera; } else uzyta = litera;
                        }
                    }
                    if (slowo.Length == 5)
                    {
                        for (int i = 1; i < 4; i++)
                        {
                            if (Convert.ToString(slowo[i]) == litera)
                            {
                                czy_trafiony = true;
                                gdzie_trafiony = i;
                                textBox1.Text = "";
                            }
                            string uzyta = "";
                            if (gdzie_trafiony == 1) { label2.Text = litera; } else uzyta = litera;
                            if (gdzie_trafiony == 2) { label3.Text = litera; } else uzyta = litera;
                            if (gdzie_trafiony == 3) { label4.Text = litera; } else uzyta = litera;
                            if (gdzie_trafiony == 4) { label5.Text = litera; } else uzyta = litera;
                            if (gdzie_trafiony == 5) { label6.Text = litera; } else uzyta = litera;
                        }
                    }

                    if (czy_trafiony == false)
                    {
                        ile_pudel++;
                        if (ile_pudel == 1) { pictureBox1.Image = WindowsFormsApp1.Properties.Resources._1; }
                        if (ile_pudel == 2) { pictureBox1.Image = WindowsFormsApp1.Properties.Resources._2; }
                        if (ile_pudel == 3) { pictureBox1.Image = WindowsFormsApp1.Properties.Resources._3; }
                        if (ile_pudel == 4) { pictureBox1.Image = WindowsFormsApp1.Properties.Resources._4; }
                        if (ile_pudel == 5) { pictureBox1.Image = WindowsFormsApp1.Properties.Resources._5; }
                        if (ile_pudel == 6) { pictureBox1.Image = WindowsFormsApp1.Properties.Resources._6; }
                        if (ile_pudel == 7) { pictureBox1.Image = WindowsFormsApp1.Properties.Resources._7; }
                        if (ile_pudel == 8) { pictureBox1.Image = WindowsFormsApp1.Properties.Resources._8; }
                        if (ile_pudel == 9) { pictureBox1.Image = WindowsFormsApp1.Properties.Resources._9; }
                        textBox1.Text = "";
                        if (label8.Text == "_") { label8.Visible = true; label8.Text = litera; }
                        else if (label9.Text == "_") { label9.Visible = true; label9.Text = litera; }
                        else if (label10.Text == "_") { label10.Visible = true; label10.Text = litera; }
                        else if (label11.Text == "_") { label11.Visible = true; label11.Text = litera; }
                        else if (label12.Text == "_") { label12.Visible = true; label12.Text = litera; }
                        else if (label16.Text == "_") { label16.Visible = true; label12.Text = litera; }
                        else if (label17.Text == "_") { label17.Visible = true; label12.Text = litera; }
                        else if (label18.Text == "_") { label18.Visible = true; label12.Text = litera; }
                        else if (label19.Text == "_") { label19.Visible = true; label12.Text = litera; }

                    }

                    wygrana();
                }
                else
                {
                    pictureBox1.Image = WindowsFormsApp1.Properties.Resources.lose;
                    button2.Visible = true;
                }


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sprawdź();
        }
        private void losuj_slowo()
        {

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;

            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
            label5.Text = "_";
            label6.Text = "_";
            string[] slowa7 = { "krokusy", "liliput", "telefon", "krakers", "magia", };
            string[] slowa5 = { "janek", "ameba", "antyk", "autor", "czary" };
            Random rnd = new Random();
            int wylosowana = rnd.Next(1, 3);
            if (wylosowana == 1)
            {
                string[] slowa = slowa5;
                int ile_slow = slowa.Length;
                Random gen = new Random();
                int indeks_slowa = gen.Next(0, ile_slow);
                slowo = slowa[indeks_slowa];
                ile_liter = slowo.Length;
                label1.Text = Convert.ToString(slowo[0]);
                label5.Text = Convert.ToString(slowo[4]);
                label6.Visible = false;
                label7.Visible = false;
            }
            else if (wylosowana == 2)
            {
                string[] slowa = slowa7;
                int ile_slow = slowa.Length;
                Random gen = new Random();
                int indeks_slowa = gen.Next(0, ile_slow - 1);
                slowo = slowa[indeks_slowa];
                ile_liter = slowo.Length;
                label1.Text = Convert.ToString(slowo[0]);
                label7.Text = Convert.ToString(slowo[6]);
            }



        }
        private void wygrana()
        {
            if (ile_liter == 7)
            {
                if (label2.Text != "_")
                {
                    if (label3.Text != "_")
                    {
                        if (label4.Text != "_")
                        {
                            if (label5.Text != "_")
                            {
                                if (label6.Text != "_")
                                {
                                    pictureBox1.Image = WindowsFormsApp1.Properties.Resources.win;
                                    button2.Visible = true;
                                    punkty++;
                                    string punkty1 = Convert.ToString(punkty);
                                    label15.Visible = true;
                                    label15.Text = punkty1;
                                }
                            }
                        }
                    }
                }
            }
            if (ile_liter == 5)
            {
                if (label2.Text != "_")
                {
                    if (label3.Text != "_")
                    {
                        if (label4.Text != "_")
                        {
                            pictureBox1.Image = WindowsFormsApp1.Properties.Resources.win;
                            button2.Visible = true;
                            punkty++;
                            string punkty1 = Convert.ToString(punkty);
                            label15.Text = punkty1;

                        }
                    }
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            restart();
        }
        private void zacznijOdNowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label15.Text = "_";
            punkty = 0;
            losuj_slowo();
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sprawdź();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }


    
    }
}
