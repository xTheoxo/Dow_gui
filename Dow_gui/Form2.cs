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

        public Form2(string cheminRecu)
        {
            InitializeComponent();
            chemin = cheminRecu;


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
    }
}
