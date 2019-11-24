using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MCF___ShutdownApps
{
    public partial class Form1 : Form
    {
        int heure;
        int minute;
        int resultat;
        bool valideShutdown;
        string msg;
        int newHeure;
        int newMinute;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime actualDate = DateTime.Now;
            string[] split = actualDate.ToString().Split(new Char[] { ' ', '/' });
            string actualHeure = split[3];
            string[] NewSplit = actualHeure.Split(':');
            newHeure = Convert.ToInt32(NewSplit[0]);
            newMinute = Convert.ToInt32(NewSplit[1]);
            valideShutdown = true;
            msg = "Opération validé !\nMerci d'avoir urilisé :\nMCF - ShutdownApps";


            if (EditHeure.Text.Trim() != "")
            {
                heure = Convert.ToInt32(EditHeure.Text.Trim());
            }
            if (EditMinute.Text.Trim() != "")
            {
                minute = Convert.ToInt32(EditMinute.Text.Trim());
            }

            if (minute != 0)
            {
                if (minute >= 60)
                {
                    valideShutdown = false;
                    msg = "Opération impossible !\nMerci de renseigner les minutes entre 0 et 59";
                }
                else
                {
                    newMinute += minute;
                    if (newMinute > 60)
                    {
                        newHeure++;
                        newMinute = newMinute -= 60;
                    }
                    minute = minute * 60;
                }
            }

            if (heure != 0)
            {
                newHeure += heure;
                heure = heure * 60;
                heure = heure * 60;
            }

            MessageBox.Show(msg, "MCF - ShutdownApps");
            if (valideShutdown)
            {
                resultat = heure + minute;
                Process.Start("shutdown", "/s /f /t " + resultat);
                string heureShutdown = "Arrêt à : \n" + newHeure + "H" + newMinute + "Min";
                label4.Text = heureShutdown;
                button2.Text = "Annuler l'arrêt";
                button1.Enabled = false;
                button2.Enabled = true;
                Properties.Settings.Default.isActive = true;
                Properties.Settings.Default.heureShut = heureShutdown;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isActive)
            {
                button2.Text = "Annuler l'arrêt";
                button1.Enabled = false;
                label4.Text = Properties.Settings.Default.heureShut;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isActive)
            {
                Process.Start("shutdown", "/a");
                button2.Text = "Aucun arrêt";
                label4.Text = "Arrêt à : ";
                button1.Enabled = true;
                button2.Enabled = false;
                Properties.Settings.Default.isActive = false;
                Properties.Settings.Default.heureShut = string.Empty;
                MessageBox.Show("Vous venez d'annuler l'arrêt programmé.");
            }
            else
            {
                MessageBox.Show("Aucun arrêt programmé n'est en cours");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
