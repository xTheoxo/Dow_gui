using System.Diagnostics;
using System.IO;

namespace Dow_gui
{
    public partial class Form1 : Form
    {
        bool jdk21 = false;
        string urlJdk = "https://download.oracle.com/java/21/latest/jdk-21_windows-x64_bin.exe";
        string path = "C:\\Users\\Théo\\source\\repos\\xTheoxo\\Dow_gui\\Dow_gui\\bin\\Debug\\net9.0-windows";
        string cheminJar = "";
        string cheminBat, contenuBat = "";
        string cheminEula, contenuEula = "";
        string chemin = "";
        string pathBat = "";
        string pathEula = "";


        public Form1()
        {
            InitializeComponent();

            if (Path.Exists("C:/Program Files/Java/latest/jdk-21"))
            {
                button1.Text = "Installer";
                jdk21 = true;
                label_jdk21.BackColor = Color.LightGreen;
                statutjdk.Text = "JDK 21 est installé";
            }
            else
            {
                statutjdk.Text = "JDK 21 n'est pas installé";
                button1.Text = "Installer";
                jdk21 = false;
                label_jdk21.BackColor = Color.Red;

            }
            label_Dossier_serv.BackColor = Color.Red;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (Path.Exists("C:/Program Files/Java/latest/jdk-21"))
            {
                MessageBox.Show("Le jdk 21 est déja installé");
                statutjdk.Text = "JDK 21 est installé";


            }
            else
            {
                label_jdk21.BackColor = Color.Yellow;
                //MessageBox.Show("Le jdk 21 est en cours d'installation, veuillez patienter...");
                statutjdk.Text = "En cours d'installation...";


                Console.WriteLine("Téléchargement du JDK en cours...");

                // Le met dans le dossier créé précédement et le renomme en jdk-21.exe
                cheminJar = Path.Combine(path, "jdk-21.exe");

                // Voir doc Microsoft > HttpClient
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = await client.GetAsync(urlJdk))
                {
                    response.EnsureSuccessStatusCode();

                    using (FileStream fs = new FileStream(cheminJar, FileMode.Create))
                    {
                        await response.Content.CopyToAsync(fs);
                    }
                }


                // Installation du JDK
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = path + "/" + "jdk-21.exe",
                    Arguments = "/s",
                    Verb = "runas", // demande admin
                    UseShellExecute = true
                };

                Process process = Process.Start(psi);

                if (process != null)
                {
                    process.WaitForExit(); // Attend la fin de l'installation

                    Console.WriteLine("Installation terminée !");
                    File.Delete(path + "/" + "jdk-21.exe");
                }
                statutjdk.Text = "JDK 21 est installé";
                label_jdk21.BackColor = Color.LightGreen;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dossier = new FolderBrowserDialog();

            if (dossier.ShowDialog() == DialogResult.OK)
            {
                chemin = dossier.SelectedPath;
                label_Dossier_serv.BackColor = Color.LightGreen;
                label2.Text = chemin;

                pathBat = Path.Combine(chemin, "start.bat");
                pathEula = Path.Combine(chemin, "eula.txt");

                if (File.Exists(pathBat) && File.Exists(pathEula))
                {
                    label_bat.BackColor = Color.LightGreen;
                }
                else
                {
                    label_bat.BackColor = Color.Red;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label_Dossier_serv_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chemin == "")
            {
                MessageBox.Show("Veuillez sélectionner un dossier pour le serveur avant de continuer.");
            }
            else
            {
                /*Form2 form = new Form2();
                form.ShowDialog();*/

                //if 
                // EULA
                //Console.WriteLine("Acceptation du EULA");
                path = chemin;
                cheminEula = Path.Combine(path, "eula.txt");
                contenuEula = @"eula=true";
                File.WriteAllText(cheminEula, contenuEula);

                //Console.WriteLine("Création du fichier start.bat");
                cheminBat = Path.Combine(path, "start.bat");

                contenuBat =
                @"@echo off
cd /d %~dp0
java -Xmx4G -jar server.jar nogui
pause";

                File.WriteAllText(cheminBat, contenuBat);

                Console.WriteLine("Fichier .bat créé avec succès !");
            }

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}