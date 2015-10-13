using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Simulateur_des
{
    public partial class Form1 : Form
    {
        int face;
        String Condition = "";
        String show;
        Historique journal;
        Random randy= new Random();

        public Form1()
        {
            InitializeComponent();
            piped_values.Text= "";
            journal = new Historique();
        }

        private void d4_Click(object sender, EventArgs e)
        {
            face = 4;
            d4.Image = Resource.d4_selected;
            d6.Image = Resource.d6;
            d8.Image = Resource.d8;
            d10.Image = Resource.d10;
            d12.Image = Resource.d12;
            d20.Image = Resource.d20;
            d100.Image = Resource.d100;
        }

        private void d6_Click(object sender, EventArgs e)
        {
            face = 6;
            d4.Image = Resource.d4;
            d6.Image = Resource.d6_selected;
            d8.Image = Resource.d8;
            d10.Image = Resource.d10;
            d12.Image = Resource.d12;
            d20.Image = Resource.d20;
            d100.Image = Resource.d100;
        }

        private void d8_Click(object sender, EventArgs e)
        {
            face = 8;
            d4.Image = Resource.d4;
            d6.Image = Resource.d6;
            d8.Image = Resource.d8_selected;
            d10.Image = Resource.d10;
            d12.Image = Resource.d12;
            d20.Image = Resource.d20;
            d100.Image = Resource.d100;
        }

        private void d10_Click(object sender, EventArgs e)
        {
            face = 10;
            d4.Image = Resource.d4;
            d6.Image = Resource.d6;
            d8.Image = Resource.d8;
            d10.Image = Resource.d10_selected;
            d12.Image = Resource.d12;
            d20.Image = Resource.d20;
            d100.Image = Resource.d100;
        }

        private void d12_Click(object sender, EventArgs e)
        {
            face = 12;
            d4.Image = Resource.d4;
            d6.Image = Resource.d6;
            d8.Image = Resource.d8;
            d10.Image = Resource.d10;
            d12.Image = Resource.d12_selected;
            d20.Image = Resource.d20;
            d100.Image = Resource.d100;
        }

        private void d20_Click(object sender, EventArgs e)
        {
            face = 20;
            d4.Image = Resource.d4;
            d6.Image = Resource.d6;
            d8.Image = Resource.d8;
            d10.Image = Resource.d10;
            d12.Image = Resource.d12;
            d20.Image = Resource.d20_selected;
            d100.Image = Resource.d100;
        }

        private void d100_Click(object sender, EventArgs e)
        {
            face = 100;
            d4.Image = Resource.d4;
            d6.Image = Resource.d6;
            d8.Image = Resource.d8;
            d10.Image = Resource.d10;
            d12.Image = Resource.d12;
            d20.Image = Resource.d20;
            d100.Image = Resource.d100_selected;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //results = new int[int.Parse(textBox3.Text)];
        }

        public void calcul()
        {
            if (face == 0)
            {
                MessageBox.Show("Vous n'avez pas choisi de dé.");
            }
            else
            {
                if (verif_nb(nb_des.Text))
                {
                    DeGenerique dg = new DeGenerique(face);
                    Lancer l = new Lancer(dg, int.Parse(nb_des.Text));
                    l.roll();
                    Thread.Sleep(2500);
                    journal.maj(l);
                    for (int i = 0; i < l.Lancers.Length - 1; i++)
                    {
                        show += l.Lancers[i] + " + ";
                    }
                    show += l.Lancers[l.Lancers.Length - 1] + " = " + l.resultat + " .";

                    if(obj_text.Text != "")
                    {
                        if (((int.Parse(obj_text.Text) <= int.Parse(nb_des.Text)) && (Condition == "<")) || ((int.Parse(obj_text.Text) < (int.Parse(nb_des.Text)) && Condition == "=") || (int.Parse(obj_text.Text) >= (int.Parse(nb_des.Text) * face) && Condition == ">")))
                        {
                            MessageBox.Show("Votre objectif ne peut pas être atteint.");
                            show = "";
                        }
                        else
                        {
                            Jeu j = new Jeu(int.Parse(obj_text.Text), Condition, l);
                            j.ResultatJeu();
                        }
                    }

                    AffRes.Invoke((Action)(() =>
                    {
                        AffRes.Text = show;
                        Jeter.Image = Resource.dice_game_gamble_roll_label_64;
                    }));
                }
                else
                {
                    MessageBox.Show("Vérifiez le nombre de dés que vous avez entré.");
                }
            }
        }

        public void calcul_pipe()
        {
            bool erreur = false;
            if (piped_values.Text != "")
            {
                String[] val_pip = piped_values.Text.Split(';');
                int[] temp_val = new int[val_pip.Length];
                for (int i = 0; i < val_pip.Length; i++)
                {
                    try
                    {
                        temp_val[i] = int.Parse(val_pip[i]);
                    }
                    catch
                    {
                        erreur = true;
                    }
                }
                if (erreur)
                {
                    MessageBox.Show("Vérifiez les faces du dés. Seuls les chiffres sont admis, et s'il y a plusieurs faces, elles doivent être séparées par des points-virgules.");
                    Jeter.Image = Resource.dice_game_gamble_roll_label_64;
                }
                else
                {
                    if (verif_nb(nb_des.Text))
                    {
                        DePipe dp = new DePipe(temp_val.Length, temp_val);
                        Lancer l = new Lancer(dp, int.Parse(nb_des.Text));
                        l.roll();
                        journal.maj(l);
                        for (int i = 0; i < l.Lancers.Length; i++)
                        {
                            if (i < l.Lancers.Length - 1)
                            {
                                show += l.Lancers[i] + " + ";
                            }
                        }
                        show += l.Lancers[l.Lancers.Length - 1] + " = " + l.resultat + " .";
                        Thread.Sleep(2500);
                        AffRes.Invoke((Action)(() =>
                        {
                            if (obj_text.Text != "")
                            {
                                Jeu j = new Jeu(int.Parse(obj_text.Text), Condition, l);
                                j.ResultatJeu();
                                AffRes.Text = show;
                            }
                            Jeter.Image = Resource.dice_game_gamble_roll_label_64;
                        }));
                    }
                    else
                    {
                        MessageBox.Show("Vérifiez le nombre de dés que vous avez entré.");
                        Jeter.Image = Resource.dice_game_gamble_roll_label_64;
                    }
            }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas indiqué de faces pour votre dé.");
                Jeter.Image = Resource.dice_game_gamble_roll_label_64;
            }
        }

        private bool verif_nb(String test)
        {
            try
            {
                int test2 = int.Parse(test);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void jeter_Click(object sender, EventArgs e)
        {
            show = "";
            if (piped_values.Text == "")
            {
                Thread waiting = new Thread(calcul);

                if (face == 4)
                {
                    Jeter.Image = Resource.d4_gif;
                }
                else if (face == 6)
                {
                    Jeter.Image = Resource.d6_gif;
                }
                else if (face == 8)
                {
                    Jeter.Image = Resource.d8_gif;
                }
                else if (face == 10)
                {
                    Jeter.Image = Resource.d10_gif;
                }
                else if (face == 12)
                {
                    Jeter.Image = Resource.d12_gif;
                }
                else if (face == 20)
                {
                    Jeter.Image = Resource.d20_gif;
                }
                else if (face == 100)
                {
                    Jeter.Image = Resource.d100_gif;
                }
                waiting.Start();

            }
            else
            {
                Thread waiting = new Thread(calcul_pipe);
                Jeter.Image = Resource.des3d_d30rot;
                waiting.Start();
            }
        }

        public void historique_Click(object sender, EventArgs e)
        {
            show = "";
            for(int i = 0; i < journal.histo.Count; i++)
            {
                if(journal.histo[i].De.pipe)
                {
                    show = "Dé personnalisé: ";
                }
                else
                {
                    show += "Dé à " + journal.histo[i].De.Face + " face: ";
                }
                for (int j = 0; j < journal.histo[i].Lancers.Length; j++)
                {
                    if (j < journal.histo[i].Lancers.Length - 1)
                    {
                        show += journal.histo[i].Lancers[j] + " + ";
                    }
                }
                show += journal.histo[i].Lancers[journal.histo[i].Lancers.Length - 1] + " = " + journal.histo[i].resultat + " ."+Environment.NewLine;
            }
            
            MessageBox.Show(show,"Historique de vos lancers.");
        }

        private void obj_inf_Click(object sender, EventArgs e)
        {
            Condition = "<";
            obj_inf.BackColor = Color.LightBlue;
            obj_egal.BackColor = Color.Transparent;
            obj_sup.BackColor = Color.Transparent;

        }

        private void obj_egal_Click(object sender, EventArgs e)
        {
            Condition = "=";
            obj_inf.BackColor = Color.Transparent;
            obj_egal.BackColor = Color.LightBlue;
            obj_sup.BackColor = Color.Transparent;
        }

        private void obj_sup_Click(object sender, EventArgs e)
        {
            Condition = ">";
            obj_inf.BackColor = Color.Transparent;
            obj_egal.BackColor = Color.Transparent;
            obj_sup.BackColor = Color.LightBlue;
        }

        private void ajout_de_Click(object sender, EventArgs e)
        {
            if (nb_des.Text == "")
            {
                nb_des.Text = "1";
            }
            else
            {
                int val = Int32.Parse(nb_des.Text) + 1;
                nb_des.Text = "" + val;
            }
        }

        private void soustraction_de_Click(object sender, EventArgs e)
        {
            if (nb_des.Text == "")
            {
            }
            else if(nb_des.Text == "1")
            {
                nb_des.Text = "";
            }
            else
            {
                int val = Int32.Parse(nb_des.Text) - 1;
                nb_des.Text = "" + val;
            }

        }

        private void jeu_421_Click(object sender, EventArgs e)
        {
            DeGenerique dg = new DeGenerique(6);
            bool victoire = false;
            while (!victoire)
            {
                Lancer l = new Lancer(dg, 3);
                l.roll();
                journal.maj(l);
                if (l.Lancers[0] == 4 || l.Lancers[1] == 4 || l.Lancers[2] == 4)
                {
                    if (l.Lancers[0] == 2 || l.Lancers[1] == 2 || l.Lancers[2] == 2)
                    {
                        if (l.Lancers[0] == 1 || l.Lancers[1] == 1 || l.Lancers[2] == 1)
                        {
                            victoire = true;
                            show = "Félicitations! Vous avez gagné!";
                        }
                        else
                        {
                            show = "Loupé! Au joueur suivant! Votre résultat: " + l.Lancers[0] + " " + l.Lancers[1] + " " + l.Lancers[2];
                        }

                    }
                    else
                    {
                        show = "Loupé! Au joueur suivant! Votre résultat: " + l.Lancers[0] + " " + l.Lancers[1] + " " + l.Lancers[2];
                    }

                }
                else
                {
                    show = "Loupé! Au joueur suivant! Votre résultat: " + l.Lancers[0] + " " + l.Lancers[1] + " " + l.Lancers[2];
                    //}
                    //Thread.Sleep(2500);
                    //AffRes.Invoke((Action)(() =>
                    //{
                    //    AffRes.Text = show;
                    //    Jeter.Image = Resource.dice_game_gamble_roll_label_64;
                    //}));
                }
                DialogResult dialogResult = MessageBox.Show(show, "421", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.Cancel)
                {
                    victoire = true;
                }
            }
        }
    }
}
