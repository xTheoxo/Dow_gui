using System.Diagnostics;
using System.IO;

namespace Dow_gui
{
    public partial class Form1 : Form
    {
        bool jdk21 = false;
        string urlJdk = "https://download.oracle.com/java/21/latest/jdk-21_windows-x64_bin.exe";
        string path = "C:\\Users\\theoa\\source\\repos\\Dow_gui\\Dow_gui\\bin\\Debug\\net9.0-windows";
        string cheminJar = "";
        public Form1()
        {
            InitializeComponent();

            if (Path.Exists("C:/Program Files/Java/latest/jdk-21"))
            {
                button1.Text = "Installer";
                jdk21 = true;
                label_jdk21.BackColor = Color.Lime;
            }
            else
            {
                button1.Text = "Installer";
                jdk21 = false;
                label_jdk21.BackColor = Color.Red;

            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (Path.Exists("C:/Program Files/Java/latest/jdk-21"))
            {
                MessageBox.Show("Le jdk 21 est déja installé");
                
            }
            else
            {
                label_jdk21.BackColor = Color.Red;
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
                label_jdk21.BackColor = Color.Lime;
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
                string chemin = dossier.SelectedPath;
                label_Dossier_serv.BackColor = Color.Lime;
                label2.Text = chemin;

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
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}