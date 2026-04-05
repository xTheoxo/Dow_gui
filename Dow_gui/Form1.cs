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
        string version = "";
        string choixVersion = "";


        //readonly string javapath = @"C:\Program Files\Java\latest\jdk-21\bin\java.exe";

        Dictionary<string, (string chem, string urljdk)> JDK = new Dictionary<string, (string chem, string urljdk)>()
            {
                { "21", ("C:/Program Files/Java/latest/jdk-21", "https://download.oracle.com/java/21/latest/jdk-21_windows-x64_bin.exe") },
                { "25", ("C:/Program Files/Java/latest/jdk-25", "https://download.oracle.com/java/21/latest/jdk-25_windows-x64_bin.exe") }
            };

        Dictionary<string, (string link, string somme)> version_choix_paper = new Dictionary<string, (string link, string somme)>()
        {
            //26.1
            { "Paper 26.1.1", ("https://fill-data.papermc.io/v1/objects/f3312f295d1fff36283dcc4bed504b20cd932e4ca700d6ad42bf917155537592/paper-26.1.1-18.jar","test") },
            
            //1.21x
            { "Paper 1.21.11", ("https://fill-data.papermc.io/v1/objects/7a6774a582b1c24328b779854f43f2d3ac3bd2daeb5cedbbd1074f0871635a18/paper-1.21.11-128.jar","test") },

            //1.20.x
            { "Paper 1.20.1", ("https://fill-data.papermc.io/v1/objects/234a9b32098100c6fc116664d64e36ccdb58b5b649af0f80bcccb08b0255eaea/paper-1.20.1-196.jar","test") },
            { "Paper 1.20.2", ("https://fill-data.papermc.io/v1/objects/ba340a835ac40b8563aa7eda1cd6479a11a7623409c89a2c35cd9d7490ed17a7/paper-1.20.2-318.jar","test") },
            { "Paper 1.20.4", ("https://fill-data.papermc.io/v1/objects/cabed3ae77cf55deba7c7d8722bc9cfd5e991201c211665f9265616d9fe5c77b/paper-1.20.4-499.jar","test") },
            { "Paper 1.20.5", ("https://fill-data.papermc.io/v1/objects/3cd7da2f8df92e082a501a39c674aab3c0343edd179b86f5baccaebfc9974132/paper-1.20.5-22.jar","test") },
            { "Paper 1.20.6", ("https://fill-data.papermc.io/v1/objects/4b011f5adb5f6c72007686a223174fce82f31aeb4b34faf4652abc840b47e640/paper-1.20.6-151.jar","test") },
        };

        Dictionary<string, (string link, string somme)> version_choix_vanilla = new Dictionary<string, (string link, string somme)>()
        {
            //{ "Paper 26.1.1", "https://fill-data.papermc.io/v1/objects/da497e12b43e5b61c5df150e4bfd0de0f53043e57d2ac98dd59289ee9da4ad68/paper-1.21.12-128.jar" },

            { "Vanilla 1.21.11", ("https://piston-data.mojang.com/v1/objects/64bb6d763bed0a9f1d632ec347938594144943ed/server.jar","test") },
            { "Vanilla 1.20.1", ("https://piston-data.mojang.com/v1/objects/84194a2f286ef7c14ed7ce0090dba59902951553/server.jar","test") }
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

                un21onzepaper.Visible = false;
                un21onzepaper.Checked = false;
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
                un20x.Visible = true;
            }
            else if (!vanillacheck.Checked && !Papercheck.Checked)
            {
                //1.21.1
                un21onzepaper.Visible = false;
                un21onzepaper.Checked = false;
                //1.20.1
                un20unpaper.Visible = false;
                un20unpaper.Checked = false;
                //1.21.x
                un21x.Visible = false;
                un21x.Checked = false;
                //1.20.x
                un20x.Visible = false;
                un20x.Checked = false;

                version = "";
            }

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (un21onzepaper.Checked)
            {

                un20unpaper.Checked = false;
                label_jdk21.Visible = true;
                button1.Visible = true;
                statutjdk.Visible = true;
                version = version_choix_paper["Paper 1.21.11"].link;
                version_mc.Text = "Paper 1.21.11";
            }
            else
            {
                version = "";
                label_jdk21.Visible = false;
                button1.Visible = false;
                statutjdk.Visible = false;
                version_mc.Text = "Choisir sa version";
            }
        }

        private async void version_mc_Click(object sender, EventArgs e)
        {
            if (version != "")
            {
                //url = version_choix[choixVersion];

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
            else
            {
                MessageBox.Show("Veuillez sélectionner une version de minecraft");
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
                un20x.Checked = false;

                un21onzepaper.Visible = true; ;

                un20unpaper.Visible = false;
                un20unpaper.Checked = false;
            }
            else
            {
                un21onzepaper.Visible = false;
                un21onzepaper.Checked = false;

                version = "";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (un20unpaper.Checked)
            {
                // Les autres versions de la même catégorie
                un20depaper.Checked = false;
                un20quatrepaper.Checked = false;
                un20cinqpaper.Checked = false;
                un20sixpaper.Checked = false;




                un21onzepaper.Checked = false;
                label_jdk21.Visible = true;
                button1.Visible = true;
                statutjdk.Visible = true;
                version = version_choix_paper["Paper 1.20.1"].link;
                version_mc.Text = "Paper 1.20.1";
            }
            else
            {
                version = "";
                label_jdk21.Visible = false;
                button1.Visible = false;
                statutjdk.Visible = false;
                version_mc.Text = "Choisir sa version";
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            return;
        }

        private void button3_Click_3(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_3(object sender, EventArgs e)
        {
            if (un20x.Checked)
            {
                //Les autres catégories
                un21x.Checked = false;

                //Les versions de cette catégories
                un20unpaper.Visible = true;
                un20depaper.Visible = true;
                un20quatrepaper.Visible = true;
                un20cinqpaper.Visible = true;
                un20sixpaper.Visible = true;

                //Les autres versions
                un21onzepaper.Visible = false;
                un21onzepaper.Checked = false;
            }
            else
            {
                // Les versions
                un20unpaper.Visible = false;
                un20unpaper.Checked = false;

                un20depaper.Visible = false;
                un20depaper.Checked = false;

                un20quatrepaper.Visible = false;
                un20quatrepaper.Checked = false;

                un20cinqpaper.Visible = false;
                un20cinqpaper.Checked = false;

                un20sixpaper.Visible = false;
                un20sixpaper.Checked = false;

                version = "";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (un20sixpaper.Checked)
            {
                // Les autres versions de la même catégorie
                un20unpaper.Checked = false;
                un20depaper.Checked = false;
                un20quatrepaper.Checked = false;
                un20cinqpaper.Checked = false;



                un21onzepaper.Checked = false;
                label_jdk21.Visible = true;
                button1.Visible = true;
                statutjdk.Visible = true;
                version = version_choix_paper["Paper 1.20.6"].link;
                version_mc.Text = "Paper 1.20.6";
            }
            else
            {
                version = "";
                label_jdk21.Visible = false;
                button1.Visible = false;
                statutjdk.Visible = false;
                version_mc.Text = "Choisir sa version";
            }
        }

        private void un20depaper_CheckedChanged(object sender, EventArgs e)
        {
            if (un20depaper.Checked)
            {
                // Les autres versions de la même catégorie
                un20unpaper.Checked = false;
                un20quatrepaper.Checked = false;
                un20cinqpaper.Checked = false;
                un20sixpaper.Checked = false;




                un21onzepaper.Checked = false;
                label_jdk21.Visible = true;
                button1.Visible = true;
                statutjdk.Visible = true;
                version = version_choix_paper["Paper 1.20.2"].link;
                version_mc.Text = "Paper 1.20.2";
            }
            else
            {
                version = "";
                label_jdk21.Visible = false;
                button1.Visible = false;
                statutjdk.Visible = false;
                version_mc.Text = "Choisir sa version";
            }
        }

        private void un20quatrepaper_CheckedChanged(object sender, EventArgs e)
        {
            if (un20quatrepaper.Checked)
            {
                // Les autres versions de la même catégorie
                un20unpaper.Checked = false;
                un20depaper.Checked = false;
                un20cinqpaper.Checked = false;
                un20sixpaper.Checked = false;




                un21onzepaper.Checked = false;
                label_jdk21.Visible = true;
                button1.Visible = true;
                statutjdk.Visible = true;
                version = version_choix_paper["Paper 1.20.4"].link;
                version_mc.Text = "Paper 1.20.4";
            }
            else
            {
                version = "";
                label_jdk21.Visible = false;
                button1.Visible = false;
                statutjdk.Visible = false;
                version_mc.Text = "Choisir sa version";
            }
        }

        private void un20cinqpaper_CheckedChanged(object sender, EventArgs e)
        {
            if (un20cinqpaper.Checked)
            {
                // Les autres versions de la même catégorie
                un20unpaper.Checked = false;
                un20depaper.Checked = false;
                un20quatrepaper.Checked = false;
                un20sixpaper.Checked = false;




                un21onzepaper.Checked = false;
                label_jdk21.Visible = true;
                button1.Visible = true;
                statutjdk.Visible = true;
                version = version_choix_paper["Paper 1.20.5"].link;
                version_mc.Text = "Paper 1.20.5";
            }
            else
            {
                version = "";
                label_jdk21.Visible = false;
                button1.Visible = false;
                statutjdk.Visible = false;
                version_mc.Text = "Choisir sa version";
            }
        }
    }
}