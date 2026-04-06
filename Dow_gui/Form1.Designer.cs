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
            un21onzepaper = new CheckBox();
            button_start = new Button();
            label_start = new Label();
            label_version = new Label();
            un21xpaper = new CheckBox();
            un20unpaper = new CheckBox();
            button3 = new Button();
            un20xpaper = new CheckBox();
            un20depaper = new CheckBox();
            un20quatrepaper = new CheckBox();
            un20cinqpaper = new CheckBox();
            un20sixpaper = new CheckBox();
            un19xpaper = new CheckBox();
            un19unpaper = new CheckBox();
            un19depaper = new CheckBox();
            un19troispaper = new CheckBox();
            un19quatrepaper = new CheckBox();
            menuStrip1 = new MenuStrip();
            vanillaToolStripMenuItem = new ToolStripMenuItem();
            tToolStripMenuItem = new ToolStripMenuItem();
            ccToolStripMenuItem = new ToolStripMenuItem();
            faisToolStripMenuItem = new ToolStripMenuItem();
            xToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            spigotpluginsToolStripMenuItem = new ToolStripMenuItem();
            xToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(174, 164);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(116, 22);
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
            label_jdk21.Location = new Point(25, 168);
            label_jdk21.Name = "label_jdk21";
            label_jdk21.Size = new Size(50, 15);
            label_jdk21.TabIndex = 1;
            label_jdk21.Text = "  jdk 21  ";
            label_jdk21.Visible = false;
            // 
            // label_bat
            // 
            label_bat.AutoSize = true;
            label_bat.Location = new Point(34, 205);
            label_bat.Name = "label_bat";
            label_bat.Size = new Size(36, 15);
            label_bat.TabIndex = 2;
            label_bat.Text = "  Bat  ";
            label_bat.Visible = false;
            label_bat.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(174, 230);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(117, 22);
            button2.TabIndex = 3;
            button2.Text = "Choisir un dossier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Location = new Point(1034, 546);
            label1.Name = "label1";
            label1.Size = new Size(31, 17);
            label1.TabIndex = 0;
            label1.Text = "1.1";
            label1.Click += label1_Click;
            // 
            // label_Dossier_serv
            // 
            label_Dossier_serv.AutoSize = true;
            label_Dossier_serv.Location = new Point(11, 234);
            label_Dossier_serv.Name = "label_Dossier_serv";
            label_Dossier_serv.Size = new Size(98, 15);
            label_Dossier_serv.TabIndex = 5;
            label_Dossier_serv.Text = "  Dossier serveur  ";
            label_Dossier_serv.Click += label_Dossier_serv_Click;
            // 
            // button_bat
            // 
            button_bat.Location = new Point(174, 198);
            button_bat.Margin = new Padding(3, 2, 3, 2);
            button_bat.Name = "button_bat";
            button_bat.Size = new Size(117, 22);
            button_bat.TabIndex = 6;
            button_bat.Text = "Aucun dossier";
            button_bat.UseVisualStyleBackColor = true;
            button_bat.Visible = false;
            button_bat.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 237);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            label2.Click += label2_Click_1;
            // 
            // statutjdk
            // 
            statutjdk.AutoSize = true;
            statutjdk.Location = new Point(324, 164);
            statutjdk.Name = "statutjdk";
            statutjdk.Size = new Size(38, 15);
            statutjdk.TabIndex = 8;
            statutjdk.Text = "label3";
            statutjdk.Visible = false;
            statutjdk.Click += statutjdk_Click;
            // 
            // Version
            // 
            Version.AutoSize = true;
            Version.Location = new Point(11, 265);
            Version.Name = "Version";
            Version.Size = new Size(99, 15);
            Version.TabIndex = 9;
            Version.Text = "Version minecraft";
            Version.Visible = false;
            Version.Click += label3_Click;
            // 
            // version_mc
            // 
            version_mc.Location = new Point(175, 261);
            version_mc.Name = "version_mc";
            version_mc.Size = new Size(116, 23);
            version_mc.TabIndex = 10;
            version_mc.Text = "Choisir sa version";
            version_mc.UseVisualStyleBackColor = true;
            version_mc.Visible = false;
            version_mc.Click += version_mc_Click;
            // 
            // vanillacheck
            // 
            vanillacheck.AutoSize = true;
            vanillacheck.Location = new Point(525, 169);
            vanillacheck.Name = "vanillacheck";
            vanillacheck.Size = new Size(60, 19);
            vanillacheck.TabIndex = 12;
            vanillacheck.Text = "Vanilla";
            vanillacheck.UseVisualStyleBackColor = true;
            vanillacheck.Visible = false;
            vanillacheck.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Papercheck
            // 
            Papercheck.AutoSize = true;
            Papercheck.Location = new Point(860, 28);
            Papercheck.Name = "Papercheck";
            Papercheck.Size = new Size(56, 19);
            Papercheck.TabIndex = 13;
            Papercheck.Text = "Paper";
            Papercheck.UseVisualStyleBackColor = true;
            Papercheck.CheckedChanged += Papercheck_CheckedChanged;
            // 
            // un21onzepaper
            // 
            un21onzepaper.AutoSize = true;
            un21onzepaper.Location = new Point(902, 76);
            un21onzepaper.Name = "un21onzepaper";
            un21onzepaper.Size = new Size(62, 19);
            un21onzepaper.TabIndex = 14;
            un21onzepaper.Text = "1.21.11";
            un21onzepaper.UseVisualStyleBackColor = true;
            un21onzepaper.Visible = false;
            un21onzepaper.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // button_start
            // 
            button_start.Location = new Point(174, 294);
            button_start.Name = "button_start";
            button_start.Size = new Size(117, 23);
            button_start.TabIndex = 15;
            button_start.Text = "Démarrer";
            button_start.UseVisualStyleBackColor = true;
            button_start.Visible = false;
            button_start.Click += button3_Click_1;
            // 
            // label_start
            // 
            label_start.AutoSize = true;
            label_start.Location = new Point(11, 298);
            label_start.Name = "label_start";
            label_start.Size = new Size(109, 15);
            label_start.TabIndex = 16;
            label_start.Text = "Démarrer le serveur";
            label_start.Visible = false;
            label_start.Click += label3_Click_1;
            // 
            // label_version
            // 
            label_version.AutoSize = true;
            label_version.Location = new Point(324, 265);
            label_version.Name = "label_version";
            label_version.Size = new Size(38, 15);
            label_version.TabIndex = 17;
            label_version.Text = "label3";
            label_version.Visible = false;
            label_version.Click += label3_Click_2;
            // 
            // un21xpaper
            // 
            un21xpaper.AutoSize = true;
            un21xpaper.Location = new Point(901, 52);
            un21xpaper.Margin = new Padding(3, 2, 3, 2);
            un21xpaper.Name = "un21xpaper";
            un21xpaper.Size = new Size(52, 19);
            un21xpaper.TabIndex = 18;
            un21xpaper.Text = "1.21x";
            un21xpaper.UseVisualStyleBackColor = true;
            un21xpaper.Visible = false;
            un21xpaper.CheckedChanged += un21x_CheckedChanged;
            // 
            // un20unpaper
            // 
            un20unpaper.AutoSize = true;
            un20unpaper.Location = new Point(834, 77);
            un20unpaper.Name = "un20unpaper";
            un20unpaper.Size = new Size(56, 19);
            un20unpaper.TabIndex = 19;
            un20unpaper.Text = "1.20.1";
            un20unpaper.UseVisualStyleBackColor = true;
            un20unpaper.Visible = false;
            un20unpaper.CheckedChanged += checkBox1_CheckedChanged_2;
            // 
            // button3
            // 
            button3.Location = new Point(12, 325);
            button3.Name = "button3";
            button3.Size = new Size(278, 23);
            button3.TabIndex = 20;
            button3.Text = "Option";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click_3;
            // 
            // un20xpaper
            // 
            un20xpaper.AutoSize = true;
            un20xpaper.Location = new Point(834, 52);
            un20xpaper.Name = "un20xpaper";
            un20xpaper.Size = new Size(52, 19);
            un20xpaper.TabIndex = 21;
            un20xpaper.Text = "1.20x";
            un20xpaper.UseVisualStyleBackColor = true;
            un20xpaper.Visible = false;
            un20xpaper.CheckedChanged += checkBox1_CheckedChanged_3;
            // 
            // un20depaper
            // 
            un20depaper.AutoSize = true;
            un20depaper.Location = new Point(834, 101);
            un20depaper.Name = "un20depaper";
            un20depaper.Size = new Size(56, 19);
            un20depaper.TabIndex = 22;
            un20depaper.Text = "1.20.2";
            un20depaper.UseVisualStyleBackColor = true;
            un20depaper.Visible = false;
            un20depaper.CheckedChanged += un20depaper_CheckedChanged;
            // 
            // un20quatrepaper
            // 
            un20quatrepaper.AutoSize = true;
            un20quatrepaper.Location = new Point(834, 126);
            un20quatrepaper.Name = "un20quatrepaper";
            un20quatrepaper.Size = new Size(56, 19);
            un20quatrepaper.TabIndex = 24;
            un20quatrepaper.Text = "1.20.4";
            un20quatrepaper.UseVisualStyleBackColor = true;
            un20quatrepaper.Visible = false;
            un20quatrepaper.CheckedChanged += un20quatrepaper_CheckedChanged;
            // 
            // un20cinqpaper
            // 
            un20cinqpaper.AutoSize = true;
            un20cinqpaper.Location = new Point(835, 151);
            un20cinqpaper.Name = "un20cinqpaper";
            un20cinqpaper.Size = new Size(56, 19);
            un20cinqpaper.TabIndex = 25;
            un20cinqpaper.Text = "1.20.5";
            un20cinqpaper.UseVisualStyleBackColor = true;
            un20cinqpaper.Visible = false;
            un20cinqpaper.CheckedChanged += un20cinqpaper_CheckedChanged;
            // 
            // un20sixpaper
            // 
            un20sixpaper.AutoSize = true;
            un20sixpaper.Location = new Point(835, 176);
            un20sixpaper.Name = "un20sixpaper";
            un20sixpaper.Size = new Size(56, 19);
            un20sixpaper.TabIndex = 26;
            un20sixpaper.Text = "1.20.6";
            un20sixpaper.UseVisualStyleBackColor = true;
            un20sixpaper.Visible = false;
            un20sixpaper.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // un19xpaper
            // 
            un19xpaper.AutoSize = true;
            un19xpaper.Location = new Point(763, 52);
            un19xpaper.Name = "un19xpaper";
            un19xpaper.Size = new Size(52, 19);
            un19xpaper.TabIndex = 27;
            un19xpaper.Text = "1.19x";
            un19xpaper.UseVisualStyleBackColor = true;
            un19xpaper.CheckedChanged += un19xpaper_CheckedChanged;
            // 
            // un19unpaper
            // 
            un19unpaper.AutoSize = true;
            un19unpaper.Location = new Point(763, 75);
            un19unpaper.Name = "un19unpaper";
            un19unpaper.Size = new Size(56, 19);
            un19unpaper.TabIndex = 28;
            un19unpaper.Text = "1.19.1";
            un19unpaper.UseVisualStyleBackColor = true;
            // 
            // un19depaper
            // 
            un19depaper.AutoSize = true;
            un19depaper.Location = new Point(763, 99);
            un19depaper.Name = "un19depaper";
            un19depaper.Size = new Size(56, 19);
            un19depaper.TabIndex = 29;
            un19depaper.Text = "1.19.2";
            un19depaper.UseVisualStyleBackColor = true;
            // 
            // un19troispaper
            // 
            un19troispaper.AutoSize = true;
            un19troispaper.Location = new Point(764, 124);
            un19troispaper.Name = "un19troispaper";
            un19troispaper.Size = new Size(56, 19);
            un19troispaper.TabIndex = 30;
            un19troispaper.Text = "1.19.3";
            un19troispaper.UseVisualStyleBackColor = true;
            // 
            // un19quatrepaper
            // 
            un19quatrepaper.AutoSize = true;
            un19quatrepaper.Location = new Point(764, 147);
            un19quatrepaper.Name = "un19quatrepaper";
            un19quatrepaper.Size = new Size(56, 19);
            un19quatrepaper.TabIndex = 31;
            un19quatrepaper.Text = "1.19.4";
            un19quatrepaper.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { vanillaToolStripMenuItem, tToolStripMenuItem, spigotpluginsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1077, 24);
            menuStrip1.TabIndex = 32;
            menuStrip1.Text = "menuStrip1";
            // 
            // vanillaToolStripMenuItem
            // 
            vanillaToolStripMenuItem.Name = "vanillaToolStripMenuItem";
            vanillaToolStripMenuItem.Size = new Size(53, 20);
            vanillaToolStripMenuItem.Text = "Vanilla";
            // 
            // tToolStripMenuItem
            // 
            tToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ccToolStripMenuItem, xToolStripMenuItem, xToolStripMenuItem1 });
            tToolStripMenuItem.Name = "tToolStripMenuItem";
            tToolStripMenuItem.Size = new Size(99, 20);
            tToolStripMenuItem.Text = "Paper (plugins)";
            tToolStripMenuItem.Click += tToolStripMenuItem_Click;
            // 
            // ccToolStripMenuItem
            // 
            ccToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { faisToolStripMenuItem });
            ccToolStripMenuItem.Name = "ccToolStripMenuItem";
            ccToolStripMenuItem.Size = new Size(180, 22);
            ccToolStripMenuItem.Text = "1.21x";
            ccToolStripMenuItem.Click += ccToolStripMenuItem_Click;
            // 
            // faisToolStripMenuItem
            // 
            faisToolStripMenuItem.Name = "faisToolStripMenuItem";
            faisToolStripMenuItem.Size = new Size(180, 22);
            faisToolStripMenuItem.Text = "1.21.11";
            faisToolStripMenuItem.Click += faisToolStripMenuItem_Click;
            // 
            // xToolStripMenuItem
            // 
            xToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6 });
            xToolStripMenuItem.Name = "xToolStripMenuItem";
            xToolStripMenuItem.Size = new Size(180, 22);
            xToolStripMenuItem.Text = "1.20x";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(104, 22);
            toolStripMenuItem2.Text = "1.20.1";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(104, 22);
            toolStripMenuItem3.Text = "1.20.2";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(104, 22);
            toolStripMenuItem4.Text = "1.20.4";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(104, 22);
            toolStripMenuItem5.Text = "1.20.5";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(104, 22);
            toolStripMenuItem6.Text = "1.20.6";
            // 
            // spigotpluginsToolStripMenuItem
            // 
            spigotpluginsToolStripMenuItem.Name = "spigotpluginsToolStripMenuItem";
            spigotpluginsToolStripMenuItem.Size = new Size(103, 20);
            spigotpluginsToolStripMenuItem.Text = "Spigot (plugins)";
            // 
            // xToolStripMenuItem1
            // 
            xToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem7, toolStripMenuItem8, toolStripMenuItem9, toolStripMenuItem10 });
            xToolStripMenuItem1.Name = "xToolStripMenuItem1";
            xToolStripMenuItem1.Size = new Size(180, 22);
            xToolStripMenuItem1.Text = "1.19x";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(180, 22);
            toolStripMenuItem7.Text = "1.19.1";
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(180, 22);
            toolStripMenuItem8.Text = "1.19.2";
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(180, 22);
            toolStripMenuItem9.Text = "1.19.3";
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(180, 22);
            toolStripMenuItem10.Text = "1.19.4";
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1077, 572);
            Controls.Add(un19quatrepaper);
            Controls.Add(un19troispaper);
            Controls.Add(un19depaper);
            Controls.Add(un19unpaper);
            Controls.Add(un19xpaper);
            Controls.Add(un20sixpaper);
            Controls.Add(un20cinqpaper);
            Controls.Add(un20quatrepaper);
            Controls.Add(un20depaper);
            Controls.Add(un20xpaper);
            Controls.Add(button3);
            Controls.Add(un20unpaper);
            Controls.Add(un21xpaper);
            Controls.Add(label_version);
            Controls.Add(label_start);
            Controls.Add(button_start);
            Controls.Add(un21onzepaper);
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
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Dow";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private CheckBox un21onzepaper;
        private Button button_start;
        private Label label_start;
        private Label label_version;
        private CheckBox un21xpaper;
        private CheckBox un20unpaper;
        private Button button3;
        private CheckBox un20xpaper;
        private CheckBox un20depaper;
        private CheckBox un20quatrepaper;
        private CheckBox un20cinqpaper;
        private CheckBox un20sixpaper;
        private CheckBox un19xpaper;
        private CheckBox un19unpaper;
        private CheckBox un19depaper;
        private CheckBox un19troispaper;
        private CheckBox un19quatrepaper;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tToolStripMenuItem;
        private ToolStripMenuItem ccToolStripMenuItem;
        private ToolStripMenuItem faisToolStripMenuItem;
        private ToolStripMenuItem xToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem vanillaToolStripMenuItem;
        private ToolStripMenuItem spigotpluginsToolStripMenuItem;
        private ToolStripMenuItem xToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
    }
}
