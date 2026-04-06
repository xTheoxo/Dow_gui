using System.Diagnostics;
using System.IO;
using System.Security.Policy;

namespace Dow_gui
{
    public partial class Form1 : Form
    {
        string urlJdk = "https://download.oracle.com/java/21/latest/jdk-21_windows-x64_bin.exe";
        readonly string urlPlayit = "https://github.com/playit-cloud/playit-agent/releases/download/v0.17.1/playit-windows-x86_64-signed.msi";
        string path = "";
        string cheminJar = "";
        string playitPath = "";
        string cheminBat, contenuBat = "";
        string cheminEula, contenuEula = "";
        string chemin = "";
        string pathBat = "";
        string pathEula = "";
        string pathjar = "";
        string version = "";
        //string choixVersion = "";


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
            { "Paper 1.21.10", ("https://fill-data.papermc.io/v1/objects/158703f75a26f842ea656b3dc6d75bf3d1ec176b97a2c36384d0b80b3871af53/paper-1.21.10-130.jar","test") },
            { "Paper 1.21.9", ("https://fill-data.papermc.io/v1/objects/aec002e77c7566e49494fdf05430b96078ffd1d7430e652d4f338fef951e7a10/paper-1.21.9-59.jar","test") },
            { "Paper 1.21.8", ("https://fill-data.papermc.io/v1/objects/8de7c52c3b02403503d16fac58003f1efef7dd7a0256786843927fa92ee57f1e/paper-1.21.8-60.jar","test") },
            { "Paper 1.21.7", ("https://fill-data.papermc.io/v1/objects/83838188699cb2837e55b890fb1a1d39ad0710285ed633fbf9fc14e9f47ce078/paper-1.21.7-32.jar","test") },
            { "Paper 1.21.6", ("https://fill-data.papermc.io/v1/objects/35e2dfa66b3491b9d2f0bb033679fa5aca1e1fdf097e7a06a80ce8afeda5c214/paper-1.21.6-48.jar","test") },
            { "Paper 1.21.5", ("https://fill-data.papermc.io/v1/objects/2ae6ae22adf417699746e0f89fc2ef6cb6ee050a5f6608cee58f0535d60b509e/paper-1.21.5-114.jar","test") },
            { "Paper 1.21.4", ("https://fill-data.papermc.io/v1/objects/5ee4f542f628a14c644410b08c94ea42e772ef4d29fe92973636b6813d4eaffc/paper-1.21.4-232.jar","test") },
            { "Paper 1.21.3", ("https://fill-data.papermc.io/v1/objects/87e973e1d338e869e7fdbc4b8fadc1579d7bb0246a0e0cf6e5700ace6c8bc17e/paper-1.21.3-83.jar","test") },
            { "Paper 1.21.1", ("https://fill-data.papermc.io/v1/objects/39bd8c00b9e18de91dcabd3cc3dcfa5328685a53b7187a2f63280c22e2d287b9/paper-1.21.1-133.jar","test") },
            { "Paper 1.21", ("https://fill-data.papermc.io/v1/objects/ab9bb1afc3cea6978a0c03ce8448aa654fe8a9c4dddf341e7cbda1b0edaa73f5/paper-1.21-130.jar","test") },

            //1.20x
            { "Paper 1.20.6", ("https://fill-data.papermc.io/v1/objects/4b011f5adb5f6c72007686a223174fce82f31aeb4b34faf4652abc840b47e640/paper-1.20.6-151.jar","test") },
            { "Paper 1.20.5", ("https://fill-data.papermc.io/v1/objects/3cd7da2f8df92e082a501a39c674aab3c0343edd179b86f5baccaebfc9974132/paper-1.20.5-22.jar","test") },
            { "Paper 1.20.4", ("https://fill-data.papermc.io/v1/objects/cabed3ae77cf55deba7c7d8722bc9cfd5e991201c211665f9265616d9fe5c77b/paper-1.20.4-499.jar","test") },
            { "Paper 1.20.2", ("https://fill-data.papermc.io/v1/objects/ba340a835ac40b8563aa7eda1cd6479a11a7623409c89a2c35cd9d7490ed17a7/paper-1.20.2-318.jar","test") },
            { "Paper 1.20.1", ("https://fill-data.papermc.io/v1/objects/234a9b32098100c6fc116664d64e36ccdb58b5b649af0f80bcccb08b0255eaea/paper-1.20.1-196.jar","test") },
            { "Paper 1.20", ("https://fill-data.papermc.io/v1/objects/1e4ccfc0599f491ee6fee4455d3722332ac5d78584fccd55cbb3b51e11504505/paper-1.20-17.jar","test") },

            //1.19x
            { "Paper 1.19.4", ("https://fill-data.papermc.io/v1/objects/e587d78cba3e99ef8c4bc24cf20cc3bdbbe89e33b0b572070446af4eb6be5ccf/paper-1.19.4-550.jar","test") },
            { "Paper 1.19.3", ("https://fill-data.papermc.io/v1/objects/3007f2c638d5f04ed32b6adaa33053fe3634ccfa74345c83d3ea4982d38db5dc/paper-1.19.3-448.jar","test") },
            { "Paper 1.19.2", ("https://fill-data.papermc.io/v1/objects/2eb5c7459ec94bcdc597ed711d549a3ab4b0fda13e412a0792a1a069b5903864/paper-1.19.2-307.jar","test") },
            { "Paper 1.19.1", ("https://fill-data.papermc.io/v1/objects/5afe23a1fade92c547124fa874bc7d908fa676f49f09879fa876224b62e9d51b/paper-1.19.1-111.jar","test") },

        };

        Dictionary<string, (string link, string somme)> version_choix_vanilla = new Dictionary<string, (string link, string somme)>()
        {
            //{ "Paper 26.1.1", "https://fill-data.papermc.io/v1/objects/da497e12b43e5b61c5df150e4bfd0de0f53043e57d2ac98dd59289ee9da4ad68/paper-1.21.12-128.jar" },

            //1.21.x
            { "Vanilla 1.21.11", ("https://piston-data.mojang.com/v1/objects/64bb6d763bed0a9f1d632ec347938594144943ed/server.jar","test") },
            { "Vanilla 1.21.8", ("https://piston-data.mojang.com/v1/objects/6bce4ef400e4efaa63a13d5e6f6b500be969ef81/server.jar","test") },
            { "Vanilla 1.21.1", ("https://piston-data.mojang.com/v1/objects/59353fb40c36d304f2035d51e7d6e6baa98dc05c/server.jar","test") },

            //1.20.x            
            { "Vanilla 1.20.6", ("https://piston-data.mojang.com/v1/objects/145ff0858209bcfc164859ba735d4199aafa1eea/server.jar","test") },
            { "Vanilla 1.20.5", ("https://piston-data.mojang.com/v1/objects/79493072f65e17243fd36a699c9a96b4381feb91/server.jar","test") },
            { "Vanilla 1.20.4", ("https://piston-data.mojang.com/v1/objects/8dd1a28015f51b1803213892b50b7b4fc76e594d/server.jar","test") },
            { "Vanilla 1.20.3", ("https://piston-data.mojang.com/v1/objects/4fb536bfd4a83d61cdbaf684b8d311e66e7d4c49/server.jar","test") },
            { "Vanilla 1.20.2", ("https://piston-data.mojang.com/v1/objects/5b868151bd02b41319f54c8d4061b8cae84e665c/server.jar","test") },
            { "Vanilla 1.20.1", ("https://piston-data.mojang.com/v1/objects/84194a2f286ef7c14ed7ce0090dba59902951553/server.jar","test") },
            { "Vanilla 1.20", ("https://piston-data.mojang.com/v1/objects/15c777e2cfe0556eef19aab534b186c0c6f277e1/server.jar","test") },

            //1.19x
            { "Vanilla 1.19.4", ("https://piston-data.mojang.com/v1/objects/8f3112a1049751cc472ec13e397eade5336ca7ae/server.jar","test") },
            { "Vanilla 1.19.3", ("https://piston-data.mojang.com/v1/objects/c9df48efed58511cdd0213c56b9013a7b5c9ac1f/server.jar","test") },
            { "Vanilla 1.19.2", ("https://piston-data.mojang.com/v1/objects/f69c284232d7c7580bd89a5a4931c3581eae1378/server.jar","test") },
            { "Vanilla 1.19.1", ("https://piston-data.mojang.com/v1/objects/8399e1211e95faa421c1507b322dbeae86d604df/server.jar","test") },
            { "Vanilla 1.19", ("https://piston-data.mojang.com/v1/objects/e00c4052dac1d59a1188b2aa9d5a87113aaf1122/server.jar","test") },
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
        void jdk21()
        {
            label_jdk21.Visible = true;
            button1.Visible = true;
            statutjdk.Visible = true;
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

                Playit_label.Visible = true;
                button_playit.Visible = true;



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
                MessageBox.Show("Veuillez sélectionner une version de minecraft. Pour ce faire allez dans un des menu en haut de l'application. Vous avez le choix entre 'Vanilla' 'Paper' 'Spigot'.");
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

        }
        private void label1_Click(object sender, EventArgs e)
        {

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


        private void un19xpaper_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void efefToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void ccToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void faisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.21.11"].link;
            version_mc.Text = "Paper 1.21.11";
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.20.1"].link;
            version_mc.Text = "Paper 1.20.1";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.20.2"].link;
            version_mc.Text = "Paper 1.20.2";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.20.4"].link;
            version_mc.Text = "Paper 1.20.4";
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.20.5"].link;
            version_mc.Text = "Paper 1.20.5";
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.20.6"].link;
            version_mc.Text = "Paper 1.20.6";
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.19.1"].link;
            version_mc.Text = "Paper 1.19.1";
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.19.2"].link;
            version_mc.Text = "Paper 1.19.2";
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.19.3"].link;
            version_mc.Text = "Paper 1.19.3";
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.19.4"].link;
            version_mc.Text = "Paper 1.19.4";
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_vanilla["Vanilla 1.21.11"].link;
            version_mc.Text = "Vanilla 1.21.11";
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_vanilla["Vanilla 1.20.6"].link;
            version_mc.Text = "Vanilla 1.20.6";
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_vanilla["Vanilla 1.20.5"].link;
            version_mc.Text = "Vanilla 1.20.5";
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_vanilla["Vanilla 1.20.4"].link;
            version_mc.Text = "Vanilla 1.20.4";
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_vanilla["Vanilla 1.20.3"].link;
            version_mc.Text = "Vanilla 1.20.3";
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_vanilla["Vanilla 1.20.2"].link;
            version_mc.Text = "Vanilla 1.20.2";
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_vanilla["Vanilla 1.20.1"].link;
            version_mc.Text = "Vanilla 1.20.1";
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_vanilla["Vanilla 1.20"].link;
            version_mc.Text = "Vanilla 1.20";
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.20"].link;
            version_mc.Text = "Paper 1.20";
        }

        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.21"].link;
            version_mc.Text = "Paper 1.21";
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.21.1"].link;
            version_mc.Text = "Paper 1.21.1";
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.21.3"].link;
            version_mc.Text = "Paper 1.21.3";
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.21.4"].link;
            version_mc.Text = "Paper 1.21.4";
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.21.5"].link;
            version_mc.Text = "Paper 1.21.5";
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.21.6"].link;
            version_mc.Text = "Paper 1.21.6";
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.21.7"].link;
            version_mc.Text = "Paper 1.21.7";
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.21.8"].link;
            version_mc.Text = "Paper 1.21.8";
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.21.9"].link;
            version_mc.Text = "Paper 1.21.9";
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_paper["Paper 1.21.10"].link;
            version_mc.Text = "Paper 1.21.10";
        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_vanilla["Vanilla 1.21.8"].link;
            version_mc.Text = "Vanilla 1.21.8";
        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_vanilla["Vanilla 1.21.1"].link;
            version_mc.Text = "Vanilla 1.21.1";
        }

        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_vanilla["Vanilla 1.19.4"].link;
            version_mc.Text = "Vanilla 1.19.4";
        }

        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_vanilla["Vanilla 1.19.3"].link;
            version_mc.Text = "Vanilla 1.19.3";
        }

        private void toolStripMenuItem34_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_vanilla["Vanilla 1.19.2"].link;
            version_mc.Text = "Vanilla 1.19.2";
        }

        private void toolStripMenuItem35_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_vanilla["Vanilla 1.19.1"].link;
            version_mc.Text = "Vanilla 1.19.1";
        }

        private void toolStripMenuItem36_Click(object sender, EventArgs e)
        {
            jdk21();
            version = version_choix_vanilla["Vanilla 1.19"].link;
            version_mc.Text = "Vanilla 1.19";
        }

        private async void button4_Click_1(object sender, EventArgs e)
        {
            button_playit.BackColor = Color.Red;
            playitPath = Path.Combine(chemin, "playit.msi");
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(urlPlayit))
            {
                response.EnsureSuccessStatusCode();

                using (FileStream fs = new FileStream(playitPath, FileMode.Create))
                {
                    await response.Content.CopyToAsync(fs);
                }
            }


            
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "msiexec",
                Arguments = $"/i \"{chemin}\\playit.msi\" /quiet",
                Verb = "runas", // admin
                UseShellExecute = true
            };
            
            Process.Start(psi);
            button_playit.BackColor = Color.LightGreen;
        }
    }
}