using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dow_gui
{
    public partial class Form2 : Form
    {
        private string chemin;
        string path;
        int MaxPlayer; // Valeur par défaut
        string Difficulte; // Valeur par défaut
        bool pvp; // Valeur par défaut
        int Maxdistance; // Valeur par défaut

        public Form2(string cheminRecu)
        {
            InitializeComponent();
            chemin = cheminRecu;


            path = Path.Combine(chemin, "server.properties");

            var lignes = File.ReadAllLines(path);

            string valeur = "";

            foreach (var ligne in lignes)
            {
                if (ligne.StartsWith("max-players="))
                {
                    valeur = ligne.Split('=')[1];
                    numUpDownClients.Value = Convert.ToInt32(valeur);
                }
            }


            lignes = File.ReadAllLines(path);

            valeur = "";

            foreach (var ligne in lignes)
            {
                if (ligne.StartsWith("view-distance="))
                {
                    valeur = ligne.Split('=')[1];
                    numericUpDowndistance.Value = Convert.ToInt32(valeur);
                }
            }


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MaxPlayer = (int)numUpDownClients.Value;

            path = Path.Combine(chemin, "server.properties");

            var lignes = File.ReadAllLines(path);

            for (int i = 0; i < lignes.Length; i++)
            {
                if (lignes[i].StartsWith("max-players="))
                {
                    lignes[i] = "max-players=" + MaxPlayer;
                }
            }

            File.WriteAllLines(path, lignes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Difficulte = comboBox1.Text;
            if (Difficulte == "Paisible")
            {
                Difficulte = "peaceful";
            }
            else if (Difficulte == "Facile")
            {
                Difficulte = "easy";
            }
            else if (Difficulte == "Normal")
            {
                Difficulte = "normal";
            }
            else if (Difficulte == "Difficile")
            {
                Difficulte = "hard";
            }

            path = Path.Combine(chemin, "server.properties");

            var lignes = File.ReadAllLines(path);

            for (int i = 0; i < lignes.Length; i++)
            {
                if (lignes[i].StartsWith("difficulty="))
                {
                    lignes[i] = "difficulty=" + Difficulte;
                }
            }

            File.WriteAllLines(path, lignes);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpvp.Checked)
                pvp = true;
            else
                pvp = false;

            path = Path.Combine(chemin, "server.properties");

            var lignes = File.ReadAllLines(path);

            for (int i = 0; i < lignes.Length; i++)
            {
                if (lignes[i].StartsWith("pvp="))
                {
                    lignes[i] = "pvp=" + pvp;
                }
            }
            File.WriteAllLines(path, lignes);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            Maxdistance = (int)numericUpDowndistance.Value;

            path = Path.Combine(chemin, "server.properties");

            var lignes = File.ReadAllLines(path);

            for (int i = 0; i < lignes.Length; i++)
            {
                if (lignes[i].StartsWith("view-distance="))
                {
                    lignes[i] = "view-distance=" + Maxdistance;
                }
            }

            File.WriteAllLines(path, lignes);
        }
    }
}
