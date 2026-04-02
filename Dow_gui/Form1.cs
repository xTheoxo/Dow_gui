using System.Diagnostics;
using System.IO;
using System.Security.Policy;

namespace Dow_gui
{
    public partial class Form1 : Form
    {
        string urlJdk = "https://download.oracle.com/java/21/latest/jdk-21_windows-x64_bin.exe";
        string path = "";
        string cheminJar = "";
        string cheminBat, contenuBat = "";
        string cheminEula, contenuEula = "";
        string chemin = "";
        string pathBat = "";
        string pathEula = "";
        string pathjar = "";
        string version = "https://fill-data.papermc.io/v1/objects/da497e12b43e5b61c5df150e4bfd0de0f53043e57d2ac98dd59289ee9da4ad68/paper-1.21.11-127.jar";
        string choixVersion = "";


        //readonly string javapath = @"C:\Program Files\Java\latest\jdk-21\bin\java.exe";

        Dictionary<string, (string chem, string urljdk)> JDK = new Dictionary<string, (string chem, string urljdk)>()
            {
                { "21", ("C:/Program Files/Java/latest/jdk-21", "https://download.oracle.com/java/21/latest/jdk-21_windows-x64_bin.exe") },
                { "25", ("C:/Program Files/Java/latest/jdk-25", "https://download.oracle.com/java/21/latest/jdk-25_windows-x64_bin.exe") }
            };




        public Form1()
        {
            InitializeComponent();

            if (Path.Exists("C:/Program Files/Java/latest/jdk-21"))
            {
                button1.Text = "Installer";

                label_jdk21.BackColor = Color.LightGreen;
                statutjdk.Text = "JDK 21 est installé";
            }
            else
            {
                statutjdk.Text = "JDK 21 n'est pas installé";

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

                // Le met dans le dossier créé précédement et le renomme en jdk-21.exe
                cheminJar = Path.Combine(chemin, "jdk-21.exe");

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
                    FileName = chemin + "/" + "jdk-21.exe",
                    Arguments = "/s",
                    Verb = "runas", // demande admin
                    UseShellExecute = true
                };

                Process process = Process.Start(psi);


                // Supprime le fichier d'installation après l'installation du JDK
                if (process != null)
                {
                    process.WaitForExit(); // Attend la fin de l'installation

                    Console.WriteLine("Installation terminée !");
                    File.Delete(chemin + "/" + "jdk-21.exe");
                }
                statutjdk.Text = "JDK 21 est installé";
                label_jdk21.BackColor = Color.LightGreen;
            }
            if (File.Exists(pathBat) && File.Exists(pathEula) && (File.Exists(pathjar)))
            {
                label_start.Visible = true;
                button_start.Visible = true;
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
                pathjar = Path.Combine(chemin, "server.jar");

                label_bat.Visible = true;
                button_bat.Visible = true;

                Version.Visible = true;
                version_mc.Visible = true;
                label_version.Visible = true;



                if (File.Exists(pathBat) && File.Exists(pathEula))
                {
                    label_bat.BackColor = Color.LightGreen;
                    button_bat.Text = "Installer";
                }
                else
                {
                    label_bat.BackColor = Color.Red;

                    label_start.Visible = false;
                    button_start.Visible = false;
                }
                if (File.Exists(pathjar))
                {
                    Version.BackColor = Color.LightGreen;
                    label_version.Text = "Déja installé";
                }
                else
                {
                    label_version.Text = "Non installé";
                    Version.BackColor = Color.Red;
                }

                if (File.Exists(pathBat) && File.Exists(pathEula) && (File.Exists(pathjar)))
                {
                    label_start.Visible = true;
                    button_start.Visible = true;
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

            /*Form2 form = new Form2();
            form.ShowDialog();*/

            label_bat.BackColor = Color.Yellow;

            // EULA
            path = chemin;
            cheminEula = Path.Combine(chemin, "eula.txt");
            contenuEula = @"eula=true";
            File.WriteAllText(cheminEula, contenuEula);

            //Console.WriteLine("Création du fichier start.bat");
            cheminBat = Path.Combine(chemin, "start.bat");

            contenuBat =
            $@"@echo off
cd /d %~dp0
java -Xmx4G -jar server.jar nogui
pause";

            File.WriteAllText(cheminBat, contenuBat);

            label_bat.BackColor = Color.LightGreen;



            if (File.Exists(pathBat) && File.Exists(pathEula) && (File.Exists(pathjar)))
            {
                label_start.Visible = true;
                button_start.Visible = true;
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (vanillacheck.Checked)
            {
                version_mc.Text = "Vanilla";
                Papercheck.Checked = false;

                un21onze.Visible = false;
                un21onze.Checked = false;
            }
            else if (!vanillacheck.Checked && !Papercheck.Checked)
            {
                version_mc.Text = "Choisir sa version";
            }
        }

        private void Papercheck_CheckedChanged(object sender, EventArgs e)
        {
            if (Papercheck.Checked)
            {
                vanillacheck.Checked = false;
                un21x.Visible = true;
            }
            else if (!vanillacheck.Checked && !Papercheck.Checked)
            {
                un21onze.Visible = false;
                un21onze.Checked = false;
                un21x.Visible = false;
                un21x.Checked = false;
            }

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (un21onze.Checked)
            {
                version_mc.Text = "Paper 1.21.11";
                label_jdk21.Visible = true;
                button1.Visible = true;
                statutjdk.Visible = true;
            }
            else
            {
                label_jdk21.Visible = false;
                button1.Visible = false;
                statutjdk.Visible = false;
                version_mc.Text = "Choisir sa version";
            }

        }

        private async void version_mc_Click(object sender, EventArgs e)
        {
            //url = version_choix[choixVersion];
            //Console.WriteLine("Téléchargement de la version " + choixVersion);

            // Le met dans le dossier créé précédement et le renomme en server.jar
            Version.BackColor = Color.Yellow;
            label_version.Text = "En cours d'installation...";
            cheminJar = Path.Combine(chemin, "server.jar");

            // Voir doc Microsoft > HttpClient
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(version))
            {
                response.EnsureSuccessStatusCode();

                using (FileStream fs = new FileStream(cheminJar, FileMode.Create))
                {
                    await response.Content.CopyToAsync(fs);
                }
            }
            Version.BackColor = Color.LightGreen;
            label_version.Text = "Installé";


            if (File.Exists(pathBat) && File.Exists(pathEula) && (File.Exists(pathjar)))
            {
                label_start.Visible = true;
                button_start.Visible = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(pathBat) && File.Exists(pathEula) && (File.Exists(pathjar)))
            {
                label_start.BackColor = Color.Yellow;

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "start.bat",
                    WorkingDirectory = chemin,
                    UseShellExecute = true
                };

                Process.Start(psi);

                label_start.BackColor = Color.LightGreen;
            }
            else
            {
                MessageBox.Show("Veuillez installer le bat et le jdk et n'oublier pas de sélectionner votre version minecraft");
            }

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void statutjdk_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void un21x_CheckedChanged(object sender, EventArgs e)
        {
            if (un21x.Checked)
            {
                un21onze.Visible = true; ;
            }
            else
            {
                un21onze.Visible = false;
                un21onze.Checked = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}