namespace Dow_gui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label_jdk21 = new Label();
            label_bat = new Label();
            button2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label1 = new Label();
            label_Dossier_serv = new Label();
            button_bat = new Button();
            label2 = new Label();
            statutjdk = new Label();
            Version = new Label();
            version_mc = new Button();
            vanillacheck = new CheckBox();
            Papercheck = new CheckBox();
            un21onze = new CheckBox();
            button_start = new Button();
            label_start = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(199, 33);
            button1.Name = "button1";
            button1.Size = new Size(133, 29);
            button1.TabIndex = 0;
            button1.Text = "Installer";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // label_jdk21
            // 
            label_jdk21.AutoSize = true;
            label_jdk21.BackColor = Color.Red;
            label_jdk21.Location = new Point(29, 39);
            label_jdk21.Name = "label_jdk21";
            label_jdk21.Size = new Size(65, 20);
            label_jdk21.TabIndex = 1;
            label_jdk21.Text = "  jdk 21  ";
            label_jdk21.Visible = false;
            // 
            // label_bat
            // 
            label_bat.AutoSize = true;
            label_bat.Location = new Point(39, 88);
            label_bat.Name = "label_bat";
            label_bat.Size = new Size(47, 20);
            label_bat.TabIndex = 2;
            label_bat.Text = "  Bat  ";
            label_bat.Visible = false;
            label_bat.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(199, 121);
            button2.Name = "button2";
            button2.Size = new Size(134, 29);
            button2.TabIndex = 3;
            button2.Text = "Choisir un dossier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Location = new Point(681, 240);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 0;
            // 
            // label_Dossier_serv
            // 
            label_Dossier_serv.AutoSize = true;
            label_Dossier_serv.Location = new Point(13, 127);
            label_Dossier_serv.Name = "label_Dossier_serv";
            label_Dossier_serv.Size = new Size(125, 20);
            label_Dossier_serv.TabIndex = 5;
            label_Dossier_serv.Text = "  Dossier serveur  ";
            label_Dossier_serv.Click += label_Dossier_serv_Click;
            // 
            // button_bat
            // 
            button_bat.Location = new Point(199, 79);
            button_bat.Name = "button_bat";
            button_bat.Size = new Size(134, 29);
            button_bat.TabIndex = 6;
            button_bat.Text = "Aucun dossier";
            button_bat.UseVisualStyleBackColor = true;
            button_bat.Visible = false;
            button_bat.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 131);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 7;
            label2.Click += label2_Click_1;
            // 
            // statutjdk
            // 
            statutjdk.AutoSize = true;
            statutjdk.Location = new Point(370, 33);
            statutjdk.Name = "statutjdk";
            statutjdk.Size = new Size(50, 20);
            statutjdk.TabIndex = 8;
            statutjdk.Text = "label3";
            statutjdk.Visible = false;
            // 
            // Version
            // 
            Version.AutoSize = true;
            Version.Location = new Point(13, 168);
            Version.Name = "Version";
            Version.Size = new Size(124, 20);
            Version.TabIndex = 9;
            Version.Text = "Version minecraft";
            Version.Visible = false;
            Version.Click += label3_Click;
            // 
            // version_mc
            // 
            version_mc.Location = new Point(200, 163);
            version_mc.Margin = new Padding(3, 4, 3, 4);
            version_mc.Name = "version_mc";
            version_mc.Size = new Size(133, 31);
            version_mc.TabIndex = 10;
            version_mc.Text = "Choisir sa version";
            version_mc.UseVisualStyleBackColor = true;
            version_mc.Visible = false;
            version_mc.Click += version_mc_Click;
            // 
            // vanillacheck
            // 
            vanillacheck.AutoSize = true;
            vanillacheck.Location = new Point(533, 32);
            vanillacheck.Margin = new Padding(3, 4, 3, 4);
            vanillacheck.Name = "vanillacheck";
            vanillacheck.Size = new Size(75, 24);
            vanillacheck.TabIndex = 12;
            vanillacheck.Text = "Vanilla";
            vanillacheck.UseVisualStyleBackColor = true;
            vanillacheck.Visible = false;
            vanillacheck.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Papercheck
            // 
            Papercheck.AutoSize = true;
            Papercheck.Location = new Point(608, 32);
            Papercheck.Margin = new Padding(3, 4, 3, 4);
            Papercheck.Name = "Papercheck";
            Papercheck.Size = new Size(68, 24);
            Papercheck.TabIndex = 13;
            Papercheck.Text = "Paper";
            Papercheck.UseVisualStyleBackColor = true;
            Papercheck.CheckedChanged += Papercheck_CheckedChanged;
            // 
            // un21onze
            // 
            un21onze.AutoSize = true;
            un21onze.Location = new Point(608, 65);
            un21onze.Margin = new Padding(3, 4, 3, 4);
            un21onze.Name = "un21onze";
            un21onze.Size = new Size(77, 24);
            un21onze.TabIndex = 14;
            un21onze.Text = "1.21.11";
            un21onze.UseVisualStyleBackColor = true;
            un21onze.Visible = false;
            un21onze.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // button_start
            // 
            button_start.Location = new Point(199, 207);
            button_start.Margin = new Padding(3, 4, 3, 4);
            button_start.Name = "button_start";
            button_start.Size = new Size(134, 31);
            button_start.TabIndex = 15;
            button_start.Text = "Démarrer";
            button_start.UseVisualStyleBackColor = true;
            button_start.Visible = false;
            button_start.Click += button3_Click_1;
            // 
            // label_start
            // 
            label_start.AutoSize = true;
            label_start.Location = new Point(13, 212);
            label_start.Name = "label_start";
            label_start.Size = new Size(139, 20);
            label_start.TabIndex = 16;
            label_start.Text = "Démarrer le serveur";
            label_start.Visible = false;
            label_start.Click += label3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(886, 448);
            Controls.Add(label_start);
            Controls.Add(button_start);
            Controls.Add(un21onze);
            Controls.Add(Papercheck);
            Controls.Add(vanillacheck);
            Controls.Add(version_mc);
            Controls.Add(Version);
            Controls.Add(statutjdk);
            Controls.Add(label2);
            Controls.Add(button_bat);
            Controls.Add(label_Dossier_serv);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(label_bat);
            Controls.Add(label_jdk21);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Dow";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label_jdk21;
        private Label label_bat;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private Label label_Dossier_serv;
        private Button button_bat;
        private Label label2;
        private Label statutjdk;
        private Label Version;
        private Button version_mc;
        private CheckBox vanillacheck;
        private CheckBox Papercheck;
        private CheckBox un21onze;
        private Button button_start;
        private Label label_start;
    }
}
